using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class Admin:BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<DevirDaim> DevirDaim { get; set; }
    }
}
