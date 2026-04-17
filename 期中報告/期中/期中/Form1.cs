using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal OVERTIME_RATE = 1.5m;
            const decimal REGULAR_HOURS = 40m;

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= REGULAR_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (REGULAR_HOURS * hourlyPayRate) +
                               ((hoursWorked - REGULAR_HOURS) *
                                hourlyPayRate * OVERTIME_RATE);
                }
                grossPayLabel.TextAlign = ContentAlignment.MiddleRight;
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric values for " +
                                "hours worked and hourly pay rate.",
                                "Input Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The values you entered are too large or too small.",
                                "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }
    }
}
