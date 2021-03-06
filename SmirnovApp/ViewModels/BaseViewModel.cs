using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using SmirnovApp.Common;
using SmirnovApp.Model;
using SmirnovApp.Model.Annotations;

namespace SmirnovApp.ViewModels
{
    public class BaseViewModel : NotifyPropertyChanged
    {
        public Command NavigateCommand => new(o =>
        {
            var type = (Type)o;
            Navigation.Navigate(type);
        });

        public Command GoBackCommand => new(_ =>
        {
            Navigation.GoBack();
        }, _ => Navigation.CanGoBack);

        public bool CanGoBack => Navigation.CanGoBack;

        public Command ShowDialogWindowCommand => new(o =>
        {
            var type = (Type)o;
            var window = (Window)Activator.CreateInstance(type);
            window?.ShowDialog();
        });
    }
}
