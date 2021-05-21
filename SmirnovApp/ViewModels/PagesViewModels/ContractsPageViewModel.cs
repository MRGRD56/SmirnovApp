using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmirnovApp.Model.DbModels;

namespace SmirnovApp.ViewModels.PagesViewModels
{
    public class ContractsPageViewModel : ItemsListViewModel<Contract>
    {
        public ContractsPageViewModel() 
            : base(typeof(Client), typeof(Employee), typeof(Estate), typeof(Service), typeof(Owner))
        {
            
        }
    }
}
