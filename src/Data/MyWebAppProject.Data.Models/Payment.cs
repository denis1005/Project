using MyWebAppProject.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebAppProject.Data.Models
{
   public class Payment: BaseModel<int>
    {
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Decimal Ammounnt { get; set; }
    }
}
