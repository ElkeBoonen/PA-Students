using System;
using System.IO;

namespace Les4
{
    class DC
    {
        public string AantalStukken(int lengte, int breedte)
        {
            int stuk = Perceel(lengte, breedte);
            int aantal = (lengte*breedte)/(stuk*stuk);
            return aantal + " stukken van " + stuk + " op " + stuk + " passen in het perceel";
        }

        public int Perceel(int lengte, int breedte)
        {
            if (lengte % breedte == 0) return breedte;
            int rest = lengte % breedte;
            return Perceel(breedte,rest);
        }
    }
}