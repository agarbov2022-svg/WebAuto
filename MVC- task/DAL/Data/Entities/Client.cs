using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Client
    {
        public Client()
        {
            this.Purchases = new HashSet<Purchase>();


        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Phone {  get; set; } = null!;

        [Required]
        [MaxLength(30)]

        public string Email { get; set; } = null!;

        public ICollection<Purchase> Purchases { get; set; }
    }
}
