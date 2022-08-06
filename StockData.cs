using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper.Expressions;
using CsvHelper.Configuration.Attributes;

namespace Project3_Stock_App_
{
    public class StockData
    {

        [Name("timestamp")]
        public List<DateTime> timestamp { get; set; } = new List<DateTime>();
        [Name("open")]
        public List<double> open { get; set; } = new List<double>();
        [Name("high")]
        public List<double> high { get; set; } = new List<double>();
        [Name("low")]
        public List<double> low { get; set; } = new List<double>();
        [Name("close")]
        public List<double> close { get; set; } = new List<double>();
        [Name("volume")]
        public List<double> volume { get; set; } = new List<double>();



    }
    
}
