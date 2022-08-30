using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DCABot
{
    public class Configuration
    {
        public struct InteractiveBrokerSettings
        {
            public string APIKey { get; set; }
            public bool paperTrading { get; set; }
        }

        public struct Trades
        {
            public string asset { get; set; }
            public double orderQty { get; set; }
            public string currency { get; set; }
            public string schedule { get; set; }
        }
    }
}
