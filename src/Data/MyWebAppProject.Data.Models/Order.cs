using MyWebAppProject.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Data.Models
{
    public class Order : BaseModel<int>
    {
        public DateTime OrderDate { get; set; }

        public DateTime ShipedDate { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int OrderDetailsId { get; set; }
        public virtual OrderDetailes OrderDetailes { get; set; }
    }
}
