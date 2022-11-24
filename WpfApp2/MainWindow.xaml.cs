using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace Museum
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        private List<Tour> anything;
        public Window1(List<Tour> tours)
        {
            InitializeComponent();
            anything = tours;
            foreach (Tour item in tours)
            {
                ToursChooserBox.Items.Add(item.Name);
            }

        }
        public void BuyButtonClick(object sender, System.EventArgs e)
        {
            string clientName = ClientNimput.Text;
            string clientSureName = ClientNimput.Text;
            string email = ClientNimput.Text;
            string price = (string)PriceBox.Content;
            string date = (string)PriceBox.Content;
            string content = (string)PriceBox.Content;
            string tour = ToursChooserBox.Text;
            DateTime now = DateTime.Now;
            string fileName = @"E:\test";
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));

            

                static async Task ExampleAsync(string clientName, string clientSureName, string email, string price, string date, string content, string tour, string now)
                {
                string folder = @"E:\test";
                string fileName = clientName;
                string fullPath = folder + fileName;
                string[] lines =
                    {
                 "Ths message was sent to this email: " + email,
                 "Thank you for your purchase " + clientName + " " + clientSureName + " !",
                 "Yor tour is: " + tour,
                 "Price: " + price,
                 "Date: " + date,
                 "Tour Content: " + content,
                 now.ToString()

                };

                File.WriteAllLines(fullPath, lines);
            }
            
        }

        private void onSelection(object sender, SelectionChangedEventArgs e)
        {
            var a = ToursChooserBox.SelectedItem as string;
            for (var i = 0; i < anything.Count; i++)
            {
                if (anything[i].Name == a)
                {
                    PriceBox.Content = anything[i].Price;
                    DateBox.Content = anything[i].Date;
                    PriceBox.Content = anything[i].Content;

                    break;
                }
            }
        }
    }
}