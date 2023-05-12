using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name must be between 1 and 20 symbols.")]
        public string Name { get; set; }

        public HashSet<User> Users { get; set; } = new HashSet<User> {};
        public Category Category { get; set; }

        public Interest()
        {
            
        }

        public Interest(string name)
        {
            this.Name = name;
        }
    }
}
