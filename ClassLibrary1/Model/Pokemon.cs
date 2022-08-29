using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Pokemon : BaseModel
    {
        public string Nome { get; set; }
        public float Hp { get; set; }
        public string Tipo { get; set; }

    }
}
