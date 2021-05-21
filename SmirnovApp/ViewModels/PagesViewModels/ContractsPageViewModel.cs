using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using SmirnovApp.Common;
using SmirnovApp.Context;
using SmirnovApp.Extensions;
using SmirnovApp.Model.DbModels;
using SmirnovApp.Views.Windows;

namespace SmirnovApp.ViewModels.PagesViewModels
{
    public class ContractsPageViewModel : ItemsListViewModel<Contract>
    {
        private string _contractNameSearchQuery = "";
        private string _employeeSearchQuery = "";
        private string _clientSearchQuery = "";
        private string _ownerSearchQuery = "";

        public ContractsPageViewModel()
            : base(typeof(Client), typeof(Employee), typeof(Estate), typeof(Service), typeof(Owner))
        {
            ContractsView = CollectionViewSource.GetDefaultView(Items);
            ContractsView.Filter += ContractsViewFilter;
        }

        private bool ContractsViewFilter(object o)
        {
            var contract = (Contract)o;

            return CheckMatch(ContractNameSearchQuery, contract.Name)
                && CheckMatch(EmployeeSearchQuery, contract.Employee.FullName)
                && CheckMatch(ClientSearchQuery, contract.Client.FullName)
                && CheckMatch(OwnerSearchQuery, contract.Estate.Owner.FullName);
        }

        private static bool CheckMatch(string query, string value)
        {
            return string.IsNullOrWhiteSpace(query)
                || value.Trim().ToLower().Contains(query.Trim().ToLower());
        }

        public string ContractNameSearchQuery
        {
            get => _contractNameSearchQuery;
            set
            {
                _contractNameSearchQuery = value;
                OnPropertyChanged();
                ContractsView.Refresh();
            }
        }

        public string EmployeeSearchQuery
        {
            get => _employeeSearchQuery;
            set
            {
                _employeeSearchQuery = value;
                OnPropertyChanged();
                ContractsView.Refresh();
            }
        }

        public string ClientSearchQuery
        {
            get => _clientSearchQuery;
            set
            {
                _clientSearchQuery = value;
                OnPropertyChanged();
                ContractsView.Refresh();
            }
        }

        public string OwnerSearchQuery
        {
            get => _ownerSearchQuery;
            set
            {
                _ownerSearchQuery = value;
                OnPropertyChanged();
                ContractsView.Refresh();
            }
        }

        public ICollectionView ContractsView { get; }

        public Contract SelectedContract { get; set; }

        public Command AddCommand => new(async _ =>
        {
            var dialogWindow = new ContractEditDialogWindow();
            if (dialogWindow.ShowDialog() != true) return;

            var contract = dialogWindow.Contract;
            await using var db = new AppDbContext();
            var dbContract = new Contract();
            await dbContract.CopyPropertiesAsync(contract, db);
            await db.AddAsync(dbContract);
            await db.SaveChangesAsync();
            Items.Add(dbContract);
        });

        public Command EditCommand => new(async _ =>
        {
            var dialogWindow = new ContractEditDialogWindow(SelectedContract);
            if (dialogWindow.ShowDialog() != true) return;

            var contract = dialogWindow.Contract;
            await using var db = new AppDbContext();
            var dbContract = await db.Contracts.FindAsync(contract.Id);
            await dbContract.CopyPropertiesAsync(contract, db);
            await SelectedContract.CopyPropertiesAsync(dbContract, db);
            await db.SaveChangesAsync();
        }, _ => SelectedContract != null);

        public Command RemoveCommand => new(async _ =>
        {
            var mbox = MessageBox.Show($"Удалить договор №{SelectedContract.Id}?", "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mbox != MessageBoxResult.OK) return;

            await using var db = new AppDbContext();
            var dbContract = await db.Contracts.FindAsync(SelectedContract.Id);
            db.Remove(dbContract);
            Items.Remove(SelectedContract);
            await db.SaveChangesAsync();
        }, _ => SelectedContract != null);

        public Command CreateDocumentCommand => new(_ =>
        {

        }, _ => SelectedContract != null);

        public Command ExportAllCommand => new(_ =>
        {

        });

        public Command ResetFilterCommand => new(_ => 
        {
            ContractNameSearchQuery = "";
            EmployeeSearchQuery = "";
            ClientSearchQuery = "";
            OwnerSearchQuery = "";
        });
    }
}
