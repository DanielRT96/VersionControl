﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webService.Entities;
using webService.MnbServiceReference;

namespace webService
{
    public partial class Form1 : Form
    {
        BindingList<RateData> rates = new BindingList<RateData>();
         
        public Form1()
        {
            InitializeComponent();
            GetExchangeRates();
            dataGridView1.DataSource = rates;
        }

        private void GetExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }
    }
}
