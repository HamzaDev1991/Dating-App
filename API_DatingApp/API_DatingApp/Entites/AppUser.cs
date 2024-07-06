using System.ComponentModel.DataAnnotations;

namespace API_DatingApp.Entites
{
    public class AppUser
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
    }
}
