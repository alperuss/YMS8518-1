using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int PageCount { get; set; }

    }
}
