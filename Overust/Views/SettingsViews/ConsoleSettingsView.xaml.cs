﻿using Overust.ViewModels.SettingsViewModels;
using System;
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

namespace Overust.Views.SettingsViews
{
    /// <summary>
    /// Interaction logic for ConsoleSettingsView.xaml
    /// </summary>
    public partial class ConsoleSettingsView : UserControl
    {
        public ConsoleSettingsViewModel ViewModel {get; set;}

        public ConsoleSettingsView()
        {
            ViewModel = new ConsoleSettingsViewModel();
            InitializeComponent();
        }
    }
}
