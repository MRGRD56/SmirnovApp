using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmirnovApp.Model.DbModels;

namespace SmirnovApp.ViewModels.WindowsViewModels
{
    public class ContractEditDialogWindowViewModel : BaseViewModel
    {
        public Contract Contract { get; }

        public bool IsEdit { get; }

        public string WindowTitle => IsEdit ? "Редактирование договора" : "Добавление договора";

        public ContractEditDialogWindowViewModel()
        {
            Contract = new Contract();
            IsEdit = false;
        }

        public ContractEditDialogWindowViewModel(Contract contract)
        {
            Contract = contract;
            IsEdit = true;
        }
    }
}
