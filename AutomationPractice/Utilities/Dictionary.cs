using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Utilities
{
    class Dictionary
    {
        public static Dictionary<string, string> EngDictionary = new Dictionary<string, string>
        {
            //Authentification
            {"Authentication", "AUTHENTICATION"},
            //Registration

            //Shopping Cart
            {"Bank card", "BANK-WIRE PAYMENT."},
            {"ckeck", "Check payment"},
            {"Order confirmation", "Your order on My Store is complete."}
        };
    }
}
