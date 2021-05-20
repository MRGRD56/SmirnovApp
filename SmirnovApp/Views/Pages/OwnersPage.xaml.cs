﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SmirnovApp.Model.DbContext;
using SmirnovApp.ViewModels.PagesViewModels;

namespace SmirnovApp.Views.Pages
{
    /// <summary>
    /// Interaction logic for OwnersPage.xaml
    /// </summary>
    public partial class OwnersPage : Page
    {
        public OwnersPage()
        {
            InitializeComponent();
            DataContext = new ItemsListViewModel<Owner>();
        }
    }
}