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
        }
    }
}
