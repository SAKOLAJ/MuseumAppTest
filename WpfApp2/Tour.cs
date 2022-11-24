using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    public class Tour
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public Tour()
        {
        }

        public Tour(string name, string price, string date, string content) => (Name, Price, Date, Content) = (name, price, date, content);
    }
}