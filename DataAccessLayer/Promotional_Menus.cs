using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Promotional_Menus
    {

        public int ID { get; set; }

        public string Name { get; set; }
        public string Photo { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveStr { get; set; }
    }
}
