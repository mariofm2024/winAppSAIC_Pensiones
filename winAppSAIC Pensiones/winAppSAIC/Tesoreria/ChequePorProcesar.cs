using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.Tesoreria
{
    public class ChequePorProcesar
    {
        private ChequesLineItemList listCheques;
        
        public ChequePorProcesar()
        {
            listCheques = new ChequesLineItemList();
        }

        public ChequesLineItemList ListCheques
        {
            get
            {
                return listCheques;
            }
        }
    }
}
