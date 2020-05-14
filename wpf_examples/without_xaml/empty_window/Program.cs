using System.Windows;
using System.Windows.Media;

namespace Program
{
    public class MainWindow : Window
    {
        [System.STAThread()]
        public static void Main()
        {
            var app = new Application();
            app.MainWindow = new MainWindow
            {
                Title = "XAMLess demo: Empty Window",
                Background =  new SolidColorBrush(Color.FromRgb(0x40, 0x40, 0x40))
            };
            app.MainWindow.Show();
            app.Run();
        }
    }
}
