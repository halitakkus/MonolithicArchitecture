using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class Customers
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Adress { get; set; }
        public string Gps { get; set; }
        public int Point { get; set; }
        public List<News> News { get; set; }
    }
}
