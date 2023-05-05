using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMlab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        const double k = 0.07;
        double rateEuro, rateDollar;
		Random random = new Random();

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Stop")
            {
                buttonStart.Text = "Start again";
                timer1.Stop();

				CurEuro.Visible = true;
				CurDollar.Visible = true;
				CurEuro.Text = "Final Euro Price: " + rateEuro.ToString();
				CurDollar.Text = "Final Dollar Price: " + rateDollar.ToString();
			}
            else
            {
                rateEuro = (double)editExRateEuro.Value;
                rateDollar = (double)editExRateDollar.Value;

                chartLines.Series[0].Points.Clear();
                chartLines.Series[0].Points.AddXY(0, rateEuro);

                chartLines.Series[1].Points.Clear();
                chartLines.Series[1].Points.AddXY(0, rateDollar);

				buttonStart.Text = "Stop";
                timer1.Start();
            }
        }

		private void buttonClear_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			chartLines.Series[0].Points.Clear();
			chartLines.Series[1].Points.Clear();

			CurEuro.Visible = false;
			CurDollar.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
        {
			int days = 0;
			rateEuro = rateEuro * (1 + k * (random.NextDouble() - 0.5));
            rateDollar = rateDollar * (1 + k * (random.NextDouble() - 0.5));

            chartLines.Series[0].Points.AddXY(days, rateEuro);
            chartLines.Series[1].Points.AddXY(days, rateDollar);
        }
    }
}
