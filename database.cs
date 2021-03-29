using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox_İnceleme
{
   public class database
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun()
            {
                id=1,urunAdi="Bir Ömür Nasıl Yaşanır",stokAdet=10,urunKategori="Roman",aciklama=@"CESUR OLUN...",yazar="İlber Ortaylı",urunResim=@"C:\Users\ASUS\Desktop\csharpprogramlama\bir ömür nasıl yaşanır.jpg"
            },

            new Urun()
            {
                id=2,urunAdi="Şeker Portakalı",stokAdet=20,urunKategori="Roman",aciklama=@"Ne güzel bir şeker portakalı fidanıymış bu!",yazar="jose mauro de vasconcelos",urunResim=@"C:\Users\ASUS\Desktop\csharpprogramlama\şeker portakalı.jpg"
            }

        };



    }
}
