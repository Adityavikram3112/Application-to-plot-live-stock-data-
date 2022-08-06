using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Stock_App_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpadateColumnBox();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            StockProcesor sp0 = new StockProcesor();
            string selected = this.CompanyBox.GetItemText(this.CompanyBox.SelectedItem);
            sp0.GetCSV(selected);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StockProcesor sp2 = new StockProcesor();
            sp2.DeleteResources();
        }

        int x = 0;
       
        public void populate()
        {
            StockData sd = new StockData();
            StockProcesor sp = new StockProcesor();
            sd = sp.GetDataStock();
            int y = sd.timestamp.Count;
            for (int i = 0; i <y; i++)
            {
                if (sd.timestamp[i] > StartDate.Value && sd.timestamp[i] < EndDate.Value)
                {
                    DataChart1.Series["Open"].Points.AddXY(x, sd.open[i]);
                    DataChart1.Series["Close"].Points.AddXY(x ,sd.close[i]);
                    DataChart1.Series["High"].Points.AddXY(x, sd.high[i]);
                    DataChart1.Series["Low"].Points.AddXY(x, sd.low[1]);
                    x++;
                }

                else
                {
                    continue;
                }
                    
            }   
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populate();
            StockProcesor sp1 = new  StockProcesor();
            HighestOpenText.Text = sp1.GetOHigh();
            HighestCloseText.Text = sp1.GetChigh();
        }


        public void UpadateColumnBox()
        {
            string[] cmpnynames = { "IBM", "ITC", "AAPL" ,"TSCO","SHOP"}; 
            CompanyBox.Items.AddRange(cmpnynames);
        }
    }
}
