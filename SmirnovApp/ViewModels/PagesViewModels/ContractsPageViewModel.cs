using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmirnovApp.Common;
using SmirnovApp.Model.DbModels;
using SmirnovApp.Views.Windows;

namespace SmirnovApp.ViewModels.PagesViewModels
{
    public class ContractsPageViewModel : ItemsListViewModel<Contract>
    {
        public ContractsPageViewModel() 
            : base(typeof(Client), typeof(Employee), typeof(Estate), typeof(Service), typeof(Owner))
        { }

        public Contract SelectedContract { get; set; }

        public Command AddCommand => new(_ =>
        {
            var dialogWindow = new ContractEditDialogWindow();
            if (dialogWindow.ShowDialog() != true) return;
        });

        public Command EditCommand => new(_ =>
        {
            var dialogWindow = new ContractEditDialogWindow(SelectedContract);
            if (dialogWindow.ShowDialog() != true) return;
        }, _ => SelectedContract != null);

        public Command RemoveCommand => new(_ =>
        {

        }, _ => SelectedContract != null);

        public Command CreateDocumentCommand => new(_ =>
        {

        }, _ => SelectedContract != null);

        public Command ExportAllCommand => new(_ =>
        {

        });
    }
}
