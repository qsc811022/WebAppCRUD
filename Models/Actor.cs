using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictrueURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}
