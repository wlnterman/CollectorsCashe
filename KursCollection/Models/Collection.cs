using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<Item> Collections { get; set; } = new List<Item>();
        //public List<Theme> Themes { get; set; } = new List<Theme>();

        public String CollectionName { get; set; }          //название
        public String CollectionDescription { get; set; }   //краткое описание с поддержкой форматирования markdown
        public String ThemeId { get; set; }                 // "тема" (из фиксированного набора, например, "Alcohol", "Books" и проч.)
        public String CollectionImageLink { get; set; }     // опционального изображения (хранится в облаке, загружается drag-n-drop-ом).

        public String ItemInt1 { get; set; }
        public String ItemInt2 { get; set; }
        public String ItemInt3 { get; set; }
        public String ItemStr1 { get; set; }
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
        //public List<String> CollectionFields { get; set; }  // Помимо этого, у коллекции есть возможность указать поля, которые будут у каждого айтема в ней

        //public Collection() { }
        //public Collection(int appUserId, string collectionName, string collectionDescription, string themeId, string collectionImageLink)
        //{
        //    AppUserId = appUserId;
        //    CollectionName = collectionName;
        //    CollectionDescription = collectionDescription;
        //    ThemeId = themeId;
        //    CollectionImageLink = collectionImageLink;
        //}

        public Collection( int appUserId, string collectionName, string collectionDescription, string themeId, string collectionImageLink, 
            string itemInt1, string itemInt2, string itemInt3, 
            string itemStr1, string itemStr2, string itemStr3,
            string itemTxt1, string itemTxt2, string itemTxt3, 
            string itemDate1, string itemDate2, string itemDate3, 
            string itemCheckBox1, string itemCheckBox2, string itemCheckBox3)
        {
            //CollectionId = collectionId;
            AppUserId = appUserId;
            CollectionName = collectionName;
            CollectionDescription = collectionDescription;
            ThemeId = themeId;
            CollectionImageLink = collectionImageLink;
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
