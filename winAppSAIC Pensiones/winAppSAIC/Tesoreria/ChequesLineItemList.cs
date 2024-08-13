using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.Tesoreria
{
    public class ChequesLineItemList: List<ChequesLineItem>
    {

        new public ChequesLineItem this[int i]
        {
            get
            {
                if (i < 0 || i > base.Count - 1)
                    return null;
                else
                    return base[i];
            }
        }
    }
}
