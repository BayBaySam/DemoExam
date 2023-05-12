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

namespace DemoExam.Pages
{
    /// <summary>
    /// Логика взаимодействия для Material.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
       
        DemoEntities Demo = new DemoEntities();
        public MaterialPage()
        {
            var s = Demo.TipMaterial.ToList();
            InitializeComponent();
            RefreshType();
            cbfilter.SelectedIndex = 0;
            cbfilter.Items.Add("Все типы");
            foreach(var item in s)
            {
                cbfilter.Items.Add(item.Tip);
            }
            
        }
        private int curentPage = 1;
        private int countdoc = 15;
        private int maxPages;
        List<Postavki> documlist;
        private void RefreshType()
        {
            documlist = Demo.Postavki.ToList();
            maxPages = (int)Math.Ceiling(documlist.Count * 1.0 / countdoc);

            var listdoc = documlist.Skip((curentPage - 1) * countdoc).Take(countdoc).ToList();
            int left, right, midl;
            left = curentPage;
            midl = curentPage + 1;
            right = curentPage + 2;
            if (left >= midl)
            {
                left = midl;
            }
            if (midl == right)
            {
                midl = right - 1;
            }
            if (right > maxPages)
            {
                right = maxPages;
            }
            Left.Content = left.ToString();
            Right.Content = right.ToString();
            Midl.Content = midl.ToString();
            LV_MAT.ItemsSource = listdoc;
            
        }

        private void CbSort(object sender, SelectionChangedEventArgs e)
        {
            var x = Demo.Postavki.ToList();
            switch (cbsort.SelectedIndex)
            {
                case 0:
                    x = x.OrderBy(p => p.Name).Where(p => (p.Tip == cbfilter.SelectedIndex)).ToList();
                    LV_MAT.ItemsSource = x;
                    break;
                case 1:
                    x = x.OrderByDescending(p => p.Name).Where(p => (p.Tip == cbfilter.SelectedIndex)).ToList();
                    LV_MAT.ItemsSource = x;
                    break;
                case 2:
                    x = x.OrderBy(p => p.CurrKol).Where(p => (p.Tip == cbfilter.SelectedIndex)).ToList();
                    LV_MAT.ItemsSource = x;
                    break;
                case 3:
                    x = x.OrderByDescending(p => p.CurrKol).Where(p => (p.Tip == cbfilter.SelectedIndex)).ToList();
                    LV_MAT.ItemsSource = x;
                    break;
               
            }
        }

        private void Cbfilter(object sender, SelectionChangedEventArgs e)
        {
             var x = Demo.Postavki.ToList();
            x = x.Where(p => (p.Tip == cbfilter.SelectedIndex)).ToList();
            LV_MAT.ItemsSource = x;
           if(cbfilter.SelectedIndex == 0)
            {
                RefreshType();
            }
        }

        private void Find(object sender, TextChangedEventArgs e)
        {
            string finder = FindText.Text;
            var x = Demo.Postavki.ToList();
            x=x.Where(p=>(p.))
        }
    }
}
