using System.Linq;
using Microsoft.AspNetCore.Mvc;

using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();
        const string adminCode = "132405120102";

        [HttpPost]
        public void Post(UserToAdd userToCheck)
        {
            if (adminCode == userToCheck.CheckString &&
                db.Users.All(u => u.Login != userToCheck.Login))
            {
                db.Users.Add(new User
                {
                    Login = userToCheck.Login,
                    Hash = Hash(userToCheck.Password)
                });
                db.SaveChanges();
            }
        }

        [HttpPost("check")]
        public bool Check(User userToCheck) => Get(userToCheck);

        [HttpDelete("{login}")]
        public void Delete(string login)
        {
            db.Users.Remove(db.Users.First(o => o.Login == login));
            db.SaveChanges();
        }

        [HttpGet]
        public bool Get(User userToCheck) => db.Users.Any(u => u.Login == userToCheck.Login &&
                                                               u.Hash == Hash(userToCheck.Hash));

        private string Hash(string password) => System.Convert.ToBase64String(
            System.Security.Cryptography.MD5.Create()
            .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
        );

        public class UserToAdd
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string CheckString { get; set; }
        }
    }
}