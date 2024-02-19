using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class User
    {
        public int Id { get; set; }

        public Cart Cart { get; set; }
    }
}