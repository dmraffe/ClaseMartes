using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class TableBase
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedByName { get; set; }

        public DateTime? UpdateDate { get; set; }
        public string? UpdateByName { get; set; }
    }
}
