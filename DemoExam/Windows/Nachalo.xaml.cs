using DemoExam.Pages;
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

namespace DemoExam.Windows
{
    /// <summary>
    /// Логика взаимодействия для Nachalo.xaml
    /// </summary>
    public partial class Nachalo : Window
    {

        DemoEntities Demo;
        public Nachalo()
        {  
            Demo=new DemoEntities();
            BitmapImage bi3 = new BitmapImage();
            InitializeComponent();
            frame.Navigate(new Pages.Menu());
            bi3.BeginInit();
            bi3.UriSource = new Uri("/Resources/Черновик.png",UriKind.Relative);
            bi3.EndInit();
            IMG.Stretch=Stretch.Uniform;
            IMG.Source =bi3;
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            while (frame.CanGoForward)
            {
                frame.GoForward();
            }
        }

        private void PerviousPage(object sender, RoutedEventArgs e)
        { 
            while (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        private void ToMaterials(object sender, RoutedEventArgs e)
        {
            Page material = new Pages.MaterialPage();
            frame.Navigate(material);
        }
    }
}
