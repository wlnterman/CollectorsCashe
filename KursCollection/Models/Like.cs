using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class Like
    {
        public int LikeId { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }


        public Like(int appUserId, int itemId)
        {
            AppUserId = appUserId;
            ItemId = itemId;
        }
    }
}
