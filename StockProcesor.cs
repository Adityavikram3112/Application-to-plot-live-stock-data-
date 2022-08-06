using System;
using System.Collections.Generic;
using System.Net;
using System.Data;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper.Expressions;

namespace Project3_Stock_App_
{
    class StockProcesor
    {
       public static  StockData svalue = new StockData();
  
        public void GetCSV(string cmpnyname="IBM")
        {
            
            string QUERY_URL = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={cmpnyname}&apikey=6JQGC3PKB6GU58DL&datatype=csv";
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient web1 = new WebClient())
            {
   
                string temp = "DSD.csv";
                web1.DownloadFile(queryUri, temp);
                 
            }  
        }

        public StockData GetDataStock()
        {
            
            var path = Directory.GetCurrentDirectory();
            path = path + "\\DSD.csv";
            
            using (var streamReader = new StreamReader(path))
            {
                int pc = 0;
                while (!streamReader.EndOfStream)
                {
                    var lines = streamReader.ReadLine();
                    var values = lines.Split(',');
                    if (pc < 1)
                    {
                        pc++;
                        continue;
                    }
                    else
                    { 
                            int x = values.Length;
                            for (int i = 0; i < x; i++)
                            {
                                if (i % 6 == 0)
                                {
                                    svalue.timestamp.Add( Convert.ToDateTime(values[i]));
                                }
                                else if (i % 6 == 1)
                                {
                                    svalue.open.Add( Convert.ToDouble(values[i]));
                                }

                                else if (i % 6 == 2)
                                {
                                    svalue.high.Add( Convert.ToDouble(values[i]));
                                }

                                else if (i % 6 == 3)
                                {
                                   svalue.low.Add(Convert.ToDouble(values[i]));
                                }    

                                else if (i % 6 == 4)
                                {
                                    svalue.close.Add(Convert.ToDouble(values[i]));
                                }

                                else if (i % 6 == 5)
                                {
                                    svalue.volume.Add(Convert.ToDouble(values[i]));
                                }
                            }
                            pc++;
                        

                    }
                }
                 

                  
            }
            //File.Delete(path);
            return svalue;

        }


        public string GetOHigh()
        {
            double ohighest = 0;
            
            int x = svalue.timestamp.Count;
            for (int i = 0; i <x; i++)
            {
                if (svalue.open[i]> ohighest)
                {
                    ohighest = svalue.open[i];
                }
                else
                {
                    continue;
                }
            }
            return Convert.ToString(ohighest);
            
           

            
             
        }
        public string GetChigh()
        {
            double chighest = 0;
            int x = svalue.timestamp.Count;
            for (int j = 0; j < x; j++)
            {
                if (svalue.close[j] > chighest)
                {
                    chighest = svalue.close[j];
                }
                else
                {
                    continue;
                }
            }
            return Convert.ToString(chighest);

        }
    

        public void DeleteResources()
        {
            string path = Directory.GetCurrentDirectory();
            path = path + "\\DSD.csv";
            File.Delete(path);
        }
        
    }   
    


}

