using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Data;
using xamless.demo;

namespace Program
{

    public class MainWindow : Window
    {
        [System.STAThread()]
        public static void Main()
        {
            var binding = new Binding
            {
                Source = new generate_image_as_bytes_ViewModel(),
                Path = new PropertyPath("MyImage"),
            };
            var image = new Image();
            image.SetBinding(Image.SourceProperty, binding);

            var app = new Application();
            app.MainWindow = new MainWindow
            {
                Title = "XAMLess demo: Bind image to byte[]",
                Background = new SolidColorBrush(Color.FromRgb(0x40, 0x40, 0x40)),
                Content = image,
            };

            app.MainWindow.Closing += (obj, args) => { (binding.Source as generate_image_as_bytes_ViewModel).Close(); };
            app.MainWindow.Show();
            app.Run();
        }
    }

}
