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

namespace Museum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Tour> anything;
        public MainWindow()
        {
            InitializeComponent();
            anything = new List<Tour>();
        }
        private void Delete_click(object sender, EventArgs e)
        {
            if (TourList.SelectedItems.Count > 0)
            {
                for (int n = TourList.Items.Count - 1; n >= 0; --n)
                {
                    TourList.Items.Remove(TourList.SelectedItem);
                }
                var a = TourList.SelectedItem as string;
                for (var i = 0; i < anything.Count; i++)
                {
                    if (anything[i].Name == a)
                    {
                        anything.RemoveAt(i);

                        break;
                    }
                }
            }
            else
                MessageBox.Show("Can not delete this element");
        }
        private void TourAdd_click(object sender, EventArgs e)
        {
            if (TourPrice.Text.Length >= 5 && TourName.Text.Length >= 1 && TourDate.Text.Length >= 6)
            {
                var t = new Tour();
                t.Price = TourPrice.Text;
                t.Name = TourName.Text;
                t.Content = TourProgram.Text;
                t.Date = TourDate.Text;
                anything.Add(t);

                TourList.Items.Add(t.Name + ", " + t.Price + ", " + t.Date + ", " + t.Content);
            }
            else
            {
                MessageBox.Show("Plese, fill in all the parametrs" +
                    "Name min 4 symbols" +
                    "Price min 5 symbors" +
                    "Date min 6 symbols");
            }
        }
        
        private void GoShop_click(object sender, EventArgs e)
        {
            var w = new Window1(anything);
            w.Show();
            Close();
        }


    }
}