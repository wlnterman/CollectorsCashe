using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class CollectionViewModel
    {
        public int CollectionId { get; set; }
        public int UserId { get; set; }
        public String CollectionName { get; set; }          //название
        public String CollectionDescription { get; set; }   //краткое описание с поддержкой форматирования markdown
        public String ThemeId { get; set; }         // "тема" (из фиксированного набора, например, "Alcohol", "Books" и проч.)
        public String CollectionImageLink { get; set; }     // опционального изображения (хранится в облаке, загружается drag-n-drop-ом).
       
        public String ItemInt1 { get; set; }
        public String ItemInt2 { get; set; }
        public String ItemInt3 { get; set; }

        public String ItemStr1 { get; set; } //3 strokovih i 3 tekstovih - raznica
        public String ItemStr2 { get; set; }
        public String ItemStr3 { get; set; }

        public String ItemTxt1 { get; set; }
        public String ItemTxt2 { get; set; }
        public String ItemTxt3 { get; set; }

        public String ItemDate1 { get; set; }
        public String ItemDate2 { get; set; }
        public String ItemDate3 { get; set; }

        public String ItemCheckBox1 { get; set; }
        public String ItemCheckBox2 { get; set; }
        public String ItemCheckBox3 { get; set; }

        //optional fields
        //public List<String> CollectionFields { get; set; }

        public CollectionViewModel() { }
        public CollectionViewModel(Models.Collection collection)
        {
            this.CollectionId = collection.CollectionId;
            this.UserId = collection.AppUserId;
            this.CollectionName = collection.CollectionName;
            this.CollectionDescription = collection.CollectionDescription;
            this.ThemeId = collection.ThemeId;
            this.CollectionImageLink = collection.CollectionImageLink;
            this.ItemInt1 = collection.ItemInt1;
            this.ItemInt2 = collection.ItemInt2;
            this.ItemInt3 = collection.ItemInt3;
            this.ItemStr1 = collection.ItemStr1;
            this.ItemStr2 = collection.ItemStr2;
            this.ItemStr3 = collection.ItemStr3;
            this.ItemTxt1 = collection.ItemTxt1;
            this.ItemTxt2 = collection.ItemTxt2;
            this.ItemTxt3 = collection.ItemTxt3;
            this.ItemDate1 = collection.ItemDate1;
            this.ItemDate2 = collection.ItemDate2;
            this.ItemDate3 = collection.ItemDate3;
            this.ItemCheckBox1 = collection.ItemCheckBox1;
            this.ItemCheckBox2 = collection.ItemCheckBox2;
            this.ItemCheckBox3 = collection.ItemCheckBox3;
        }
    }
}
