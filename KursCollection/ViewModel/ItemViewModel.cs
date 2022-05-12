using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class ItemViewModel
    {
        

        //todo

        public int ItemId { get; set; }

        public int CollectionId { get; set; }

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

        public ItemViewModel() { }
        public ItemViewModel(Models.Item item)
        {
            this.ItemId = item.ItemId;
            this.CollectionId = item.CollectionId;
            this.ItemName = item.ItemName;
            this.ItemInt1 = item.ItemInt1;
            this.ItemInt2 = item.ItemInt2;
            this.ItemInt3 = item.ItemInt3;
            this.ItemStr1 = item.ItemStr1;
            this.ItemStr2 = item.ItemStr2;
            this.ItemStr3 = item.ItemStr3;
            this.ItemTxt1 = item.ItemTxt1;
            this.ItemTxt2 = item.ItemTxt2;
            this.ItemTxt3 = item.ItemTxt3;
            this.ItemDate1 = item.ItemDate1;
            this.ItemDate2 = item.ItemDate2;
            this.ItemDate3 = item.ItemDate3;
            this.ItemCheckBox1 = item.ItemCheckBox1;
            this.ItemCheckBox2 = item.ItemCheckBox2;
            this.ItemCheckBox3 = item.ItemCheckBox3;
        }
    }
}
