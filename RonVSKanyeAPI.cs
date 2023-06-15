using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace APIsAndJSONex
{
    public class RonVSKanyeAPI
    {
        public static void Conversation()
        {
            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
            }
        }
    }
}
