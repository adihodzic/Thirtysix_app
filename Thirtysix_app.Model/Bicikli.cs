using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirtysix_app.Model
{
    public class Bicikli
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Model { get; set; }
        public string TipBicikla { get; set; }
        public byte[] Slika { get; set; }

    }
}
