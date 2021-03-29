using System;
using System.Collections.Generic;
using System.Text;

namespace Junckers_el
{
   public class Kabel
    {
        public int KabelId { get; set; }
        public string KabelName { get; set; }

        public string FavekodeFase { get; set;  }
        public string FarvekodeNul { get; set; }


        public Kabel(int kabelId, string kabelName, string farvekodeFase, string farvekodeNul )
        {
            KabelId = kabelId;
            KabelName = kabelName;          
            FavekodeFase = farvekodeFase;
            FarvekodeNul = farvekodeNul;


        }

    }
}
