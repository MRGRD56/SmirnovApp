using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmirnovApp.Context;

namespace SmirnovApp.ViewModels.PagesViewModels
{
    public class ItemsListViewModel<T> : BaseViewModel where T : class
    {
        public ObservableCollection<T> Items { get; set; }

        private readonly SynchronizationContext _syncContext = SynchronizationContext.Current;

        public ItemsListViewModel()
        {
            Items = new();
            LoadItems();
        }

        private async void LoadItems()
        {
            await using var db = new AppDbContext();
            var items = db.Set<T>();
            await items.ForEachAsync(x =>
            {
                _syncContext.Send(_ => Items.Add(x), null);
            });
        }
    }
}
