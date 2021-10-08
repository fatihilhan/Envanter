using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter.Fonksiyonlar
{
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();

        public int StokKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.Stoklars
                                        orderby s.ID descending
                                        select s).First().ID.ToString());
                Numara++;
                //string Num = Numara.ToString().PadLeft(7, '0');
                return Numara;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public int StokKartNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.StokKartlaris
                                        orderby s.ID descending
                                        select s).First().ID.ToString());
                Numara++;
                //string Num = Numara.ToString().PadLeft(7, '0');
                return Numara;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public int StokGrupKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.StokGruplaris
                                        orderby s.ID descending
                                        select s).First().ID.ToString());
                Numara++;
                //string Num = Numara.ToString().PadLeft(7, '0');
                return Numara;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public int DepoKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.Depolars
                                        orderby s.ID descending
                                        select s).First().ID.ToString());
                Numara++;
                //string Num = Numara.ToString().PadLeft(7, '0');
                return Numara;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public string CariKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.Carilers
                                        orderby s.ID descending
                                        select s).First().CariKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

        public string KurumKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.Kurumlars
                                        orderby s.ID descending
                                        select s).First().KurumKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
