using System;
using System.ComponentModel.DataAnnotations;

namespace _20211215_EF_ShopApp.Models
{
    public class Entity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public int IsDeleted { get; set; } = 0;
    }
}
