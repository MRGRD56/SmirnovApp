using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SmirnovApp.Views.Windows;

namespace SmirnovApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal const string AppName = "AppName";

        internal new static MainWindow MainWindow => (MainWindow) Current.MainWindow;
    }
}
