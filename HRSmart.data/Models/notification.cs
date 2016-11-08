using System;
using System.Collections.Generic;

namespace HRSmart.data.Models
{
    public partial class notification
    {
        public int id { get; set; }
        public string notificationText { get; set; }
        public Nullable<int> user_id { get; set; }
        public virtual user user { get; set; }
    }
}
