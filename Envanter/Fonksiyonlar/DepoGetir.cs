using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter.Fonksiyonlar
{
    public class DepoGetir
    {
        private int depoID;
        private string depoAdi;

        public DepoGetir(int depoID, string depoAdi)
        {
            this.depoID = depoID;
            this.depoAdi = depoAdi;
        }
        public int DepoId
        {
            get { return depoID; }
            set { depoID = value; }
        }
        public string DepoAdi
        {
            get { return depoAdi; }
            set { depoAdi = value; }
        }
    }
}
