using System.Linq;

namespace ComputerThingsShop.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public string GetInitials()
        {
            var result = "";
            result += this.UserName.First();
            result += this.Surname.First();
            return result;
        }
    }
}
