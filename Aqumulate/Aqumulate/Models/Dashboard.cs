using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aqumulate.Models
{

    public class Dashboard : INotifyPropertyChanged
    {
        public List<DashBoardChart> dashboardchart { get; }

        public List<TopHoldingsList> topholdings { get; }

        public Dashboard()
        {
            topholdings = new List<TopHoldingsList>()
            {
                new TopHoldingsList { Symbol = "Vanguard I",Description = "VANGUARD INDEX FUNDS VANGUARD TOTAL STOC",Quantity = "2569.477",Marketvalue = "$132,153.44"},
                new TopHoldingsList { Symbol = "KSCVX",Description = "KEELEY SMALL CAP VALUE CLASS A",Quantity = "2569.477",Marketvalue = "$102,166.87"},
                new TopHoldingsList { Symbol = "TRRMX",Description = "Retirement 2050 Fund",Quantity = "4679.587",Marketvalue = "$61,739.39"},
                new TopHoldingsList { Symbol = "PIEQX",Description = "International Equity Index",Quantity = "3593.719",Marketvalue = "$41,417.05"},
            };

            dashboardchart = new List<DashBoardChart>()
            {
                new DashBoardChart { AssetsType = "Investment", Value = 501388.91},
                new DashBoardChart { AssetsType = "Retirement", Value = 60009.00},
                new DashBoardChart { AssetsType = "Insurance", Value = 35809.5 },
                new DashBoardChart { AssetsType = "Banking", Value = 47790.04 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DashBoardChart
    {
        public string AssetsType { get; set; }

        public double Value { get; set; }
    }

    public class TopHoldingsList
    {
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Marketvalue { get; set; }
    }
}
