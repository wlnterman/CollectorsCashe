using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class UserWithCollectionsViewModel : AppUserViewModel
    {
        public IEnumerable<CollectionViewModel> Collections { get; set; }

        public UserWithCollectionsViewModel() { }
        public UserWithCollectionsViewModel(AppUser user, IEnumerable<Collection> collections) : base(user)
        {
            Collections = collections.Select(collection => new CollectionViewModel(collection));
        }
    }
}
