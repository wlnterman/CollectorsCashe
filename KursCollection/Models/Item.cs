using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class Item
    {
        //Required
        public int ItemId { get; set; }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Like> Likes { get; set; } = new List<Like>();
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public String ItemName { get; set; }
        

        //Optional
        public int ItemInt1 { get; set; }
        public int ItemInt2 { get; set; }
        public int ItemInt3 { get; set; }

        public String ItemStr1 { get; set; } //3 strokovih i 3 tekstovih - raznica
        public String ItemStr2 { get; set; }
        public String ItemStr3 { get; set; }

        public String ItemTxt1 { get; set; }
        public String ItemTxt2 { get; set; }
        public String ItemTxt3 { get; set; }

        public DateTime ItemDate1 { get; set; }
        public DateTime ItemDate2 { get; set; }
        public DateTime ItemDate3 { get; set; }

        public bool ItemCheckBox1 { get; set; }
        public bool ItemCheckBox2 { get; set; }
        public bool ItemCheckBox3 { get; set; }


        //строка поиска в шапке сайта
        //уточнить у владоса про админский доступ ко всему, юзать айдентити или как со статусом в 4 таске (иф юзернейм = имя создателя или админ)
        //

        //public CollectionItems() { }
        public Item(int collectionId, string itemName,
           int itemInt1, int itemInt2, int itemInt3,
           string itemStr1, string itemStr2, string itemStr3,
           string itemTxt1, string itemTxt2, string itemTxt3,
           DateTime itemDate1, DateTime itemDate2, DateTime itemDate3,
           bool itemCheckBox1, bool itemCheckBox2, bool itemCheckBox3)
        {
            CollectionId = collectionId;
            ItemName = itemName;

            ItemInt1 = itemInt1;
            ItemInt2 = itemInt2;
            ItemInt3 = itemInt3;
            ItemStr1 = itemStr1;
            ItemStr2 = itemStr2;
            ItemStr3 = itemStr3;
            ItemTxt1 = itemTxt1;
            ItemTxt2 = itemTxt2;
            ItemTxt3 = itemTxt3;
            ItemDate1 = itemDate1;
            ItemDate2 = itemDate2;
            ItemDate3 = itemDate3;
            ItemCheckBox1 = itemCheckBox1;
            ItemCheckBox2 = itemCheckBox2;
            ItemCheckBox3 = itemCheckBox3;
        }

    }
}
