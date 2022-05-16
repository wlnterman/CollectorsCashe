using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class LikeViewModel
    {
        public int LikeId { get; set; }
        public int AppUserId { get; set; }
        public int ItemId { get; set; }

        public LikeViewModel() { }
        public LikeViewModel(Like like)
        {
            this.LikeId = like.LikeId;
            this.AppUserId = like.AppUserId;
            this.ItemId = like.ItemId;
        }
    }
}