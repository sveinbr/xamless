using System;
using System.Windows;
using System.ComponentModel;
using System.Timers;

namespace xamless.demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new generate_image_as_bytes_ViewModel();
            InitializeComponent();
            this.Closing += (obj,evt) =>
            {
                (DataContext as generate_image_as_bytes_ViewModel).Close();
            };
        }
    }
}
