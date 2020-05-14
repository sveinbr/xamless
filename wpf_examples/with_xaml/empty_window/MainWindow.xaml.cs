using System.Windows;

namespace MainApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closing += _Closing;
        }

        void _Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        void _onError(string msg)
        {
            MessageBox.Show(msg, "MainApplication._onError");
        }
    }
}
