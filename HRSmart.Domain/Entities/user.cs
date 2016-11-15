using System;
using System.Collections.Generic;

namespace HRSmart.Domain.Entities
{
    public partial class user
    {
        public user()
        {
            this.notifications = new List<notification>();
            this.postulations = new List<postulation>();
            this.userskills = new List<userskill>();
            this.userbuisnesses = new List<userbuisness>();
        }

        public int id { get; set; }
        public string adresse { get; set; }
        public int age { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string numTel { get; set; }
        public string password { get; set; }
        public virtual ICollection<notification> notifications { get; set; }
        public virtual ICollection<postulation> postulations { get; set; }
        public virtual ICollection<userskill> userskills { get; set; }
        public virtual ICollection<userbuisness> userbuisnesses { get; set; }
    }
}
