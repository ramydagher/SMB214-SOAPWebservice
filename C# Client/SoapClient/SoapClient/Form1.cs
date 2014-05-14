using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoapClient
{
    public partial class Form1 : Form
    {
        WeightService.WeightConvert converterservice = new WeightService.WeightConvert();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKGtoPound_Click(object sender, EventArgs e)
        {
            nudToPound.Value = (decimal)converterservice.KgToPound((double)nudFromkg.Value);
        }

        private void btnPoundToKg_Click(object sender, EventArgs e)
        {
            nudToKg.Value = (decimal)converterservice.PoundToKg((double)nudFromPound.Value);
        }
    }
}
