using KursCollection.Data;
using KursCollection.Models;
using KursCollection.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Services
{
    public class UserService
    {
        IUserRepository<AppUser> userRepository;
        private readonly ApplicationDbContext _context;

        public UserService(IUserRepository<AppUser> urepository, ApplicationDbContext db)
        {
            this.userRepository = urepository;
            _context = db;
        }
        //public AppUser GetuserId(int? id)
        //{
        //    var currentUserEmail = HttpContext.User.Identity.Name;
        //    //userRepository.GetUser(id)
        //    AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserEmail == currentUserEmail);
        //    return user;
        //}
    }
}
