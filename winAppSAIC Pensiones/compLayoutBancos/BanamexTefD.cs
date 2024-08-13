using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
   public  class  BanamexTefD:Banamex 
    {
       //CONTROL
       public string TipoCargo
       {
           get;
           set;
       }

       public string TotalAbonos
       {
           get;
           set;
       }
    }
}
