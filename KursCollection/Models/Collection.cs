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

        
        //optional fields
        //public List<String> CollectionFields { get; set; }  // Помимо этого, у коллекции есть возможность указать поля, которые будут у каждого айтема в ней

        //public Collection() { }
        public Collection(int appUserId, string collectionName, string collectionDescription, string themeId, string collectionImageLink)
        {
            AppUserId = appUserId;
            CollectionName = collectionName;
            CollectionDescription = collectionDescription;
            ThemeId = themeId;
            CollectionImageLink = collectionImageLink;
        }
    }
}
