using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEprueba
    {
        public BEprueba()
        {
        }

        public BEprueba(byte[] file, string exten)
        {
            this.file = file;
            this.exten = exten;
        }

        public byte [] file { get; set; }
        public string exten { get; set; }
    }
}
