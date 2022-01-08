using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class StatisticsViewModel
    {
        public int CategoryCount { get; set; }
        public int HeadingsByYazilimCategory { get; set; }
        public int WritersContainA { get; set; }
        public Category CategoryHasMostHeading { get; set; }
        public int DifferenceBetweenStatus { get; set; }
    }
}