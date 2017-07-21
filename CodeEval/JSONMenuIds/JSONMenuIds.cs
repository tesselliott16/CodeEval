using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace JSONMenuIds
{
    class JSONMenuIds
    {
        static void Main(string[] args)
        {
            string f = "JSONMenuIdsText.txt";
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    var json = line;
                    var menu = JsonConvert.DeserializeObject<RootObject>(json);
                    var total = 0;
                    foreach (var item in menu.Menu.Items)
                    {
                        if (item?.Label != null)
                        {
                            total += item.Id;
                        }
                    }
                    Console.WriteLine(total);
                }
                Console.ReadLine();
            }
        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }

    public class Menu
    {
        public string Header { get; set; }
        public List<Item> Items { get; set; }
    }

    public class RootObject
    {
        public Menu Menu { get; set; }
    }
}
