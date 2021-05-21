using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmirnovApp.Context;

namespace SmirnovApp.ViewModels.PagesViewModels
{
    public class ItemsListViewModel<T> : BaseViewModel where T : class
    {
        private readonly Type[] _typesToLoad;
        public ObservableCollection<T> Items { get; set; }

        private readonly SynchronizationContext _syncContext = SynchronizationContext.Current;

        public ItemsListViewModel(params Type[] typesToLoad)
        {
            _typesToLoad = typesToLoad;
            Items = new();
            LoadItems();
        }

        /// <summary>
        /// Загружает коллекцию элементов из базы данных.
        /// </summary>
        private async void LoadItems()
        {
            await using var db = new AppDbContext();

            //Если есть коллекции, которые нужно загрузить, загружаем.
            if (_typesToLoad?.Any() == true)
            {
                await LoadRelatedEntitiesAsync(db);
            }
            
            var items = db.Set<T>();
            await items.ForEachAsync(x =>
            {
                _syncContext.Send(_ => Items.Add(x), null);
            });
        }

        /// <summary>
        /// Асинхронно загружает связанные сущности указанных в <see cref="_typesToLoad"/> типов.
        /// </summary>
        /// <returns></returns>
        private async Task LoadRelatedEntitiesAsync(DbContext db)
        {
            var dbType = db.GetType();

            //Метод DbContext.Set<T>();
            var setMethod = dbType.GetMethod("Set", new Type[0])
                            ?? throw new Exception("ItemsListViewModel.LoadRelatedEntitiesAsync: setMethod is null");

            var entityFrameworkQueryableExtensionsType = typeof(EntityFrameworkQueryableExtensions);

            //Метод static async EntityFrameworkQueryableExtensions.LoadAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken = default);
            var loadAsyncMethod = entityFrameworkQueryableExtensionsType.GetMethod("LoadAsync")
                                  ?? throw new Exception("ItemsListViewModel.LoadRelatedEntitiesAsync: loadAsyncMethod is null");

            foreach (var type in _typesToLoad)
            {
                //Выполняем для каждого типа.
                //await db.Set<T>().LoadAsync(); Где T - обобщённый тип type.

                //Метод DbContext.Set<[type]>()
                var setGenericMethod = setMethod.MakeGenericMethod(type);

                //DbSet<[type]>, коллекция, которая будет загружена.
                var itemsToLoad = setGenericMethod.Invoke(db, null)
                                  ?? throw new Exception("ItemsListViewModel.LLoadRelatedEntitiesAsyncoadItems: itemsToLoad is null");

                //Метод EntityFrameworkQueryableExtensions.LoadAsync<[type]>(...)
                var loadAsyncGenericMethod = loadAsyncMethod.MakeGenericMethod(type);

                //Выполняем метод LoadAsync и получаем Task.
                var loadAsyncMethodTask = (Task) loadAsyncGenericMethod.Invoke(null, new[] { itemsToLoad, default(CancellationToken) })
                                          ?? throw new Exception("ItemsListViewModel.LoadRelatedEntitiesAsync: loadAsyncMethod is null");

                await loadAsyncMethodTask.ConfigureAwait(false);

                //Получаем результат Task, в данном случае, void.
                loadAsyncMethodTask.GetAwaiter().GetResult();
            }
        }
    }
}
