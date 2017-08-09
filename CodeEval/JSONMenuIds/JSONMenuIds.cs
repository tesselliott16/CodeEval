using System;
using System.Collections.Generic;
using Newtonsoft.Json;

//https://www.codeeval.com/open_challenges/102/
//To view the requirements for the below project, click the link above

namespace JSONMenuIds
{
    class JSONMenuIds
    {
        static void Main(string[] args)
        {
            //read the text file containing the jsonobjects
            string f = "JSONMenuIdsText.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //deserialize the json objects into a list of root objects containing menus of items
                var menu = JsonConvert.DeserializeObject<RootObject>(line);
                var total = 0;
                //for each item in the menu, if it contains a label, then add the amount of the label to the total
                foreach (var item in menu.Menu.Items)
                {
                    if (item?.Label != null)
                    {
                        total += item.Id;
                    }
                }
                //print the total
                Console.WriteLine(total);
            }
            Console.ReadLine();
        }
    }
    //create an object for the item that contains an ID and a label
    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }
    //create an object of the menu, which contains a header and a list of items
    public class Menu
    {
        public string Header { get; set; }
        public List<Item> Items { get; set; }
    }
    //create an object that contains a menu

    public class RootObject
    {
        public Menu Menu { get; set; }
    }
}
