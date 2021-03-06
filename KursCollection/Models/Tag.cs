using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public List<Item> CollectionItems { get; set; } = new List<Item>();

        public Tag(string tagName)
        {
            TagName = tagName;
        }
    }
}
