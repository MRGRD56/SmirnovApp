using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SmirnovApp.Common;
using SmirnovApp.Model;
using SmirnovApp.Model.Annotations;

namespace SmirnovApp.ViewModels
{
    public abstract class BaseViewModel : NotifyPropertyChanged
    {
        public Command NavigateCommand => new(o =>
        {
            var type = (Type) o;
            Navigation.Navigate(type);
        });

        public Command ShowDialogWindowCommand => new(o =>
        {
            var type = (Type)o;
            var window = (Window)Activator.CreateInstance(type);
            window.ShowDialog();
        });
    }
}
