using RssReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ViewModel
{
    public class FakeRssHelper : IRssHelper
    {
        public List<Item> GetPosts()
        {
            List<Item> items = new List<Item>();

            items.Add(new Item()
            {
                Title ="title 01",
                PubDate = "Thu, 22 Nov 2018 6:13:30 GMT"
            });

            items.Add(new Item()
            {
                Title = "Title 02",
                PubDate = "Fri, 23 Nov 2018 9:27:14 GMT"
            });

            return items;
        } 
    }
}
