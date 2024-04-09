using System;
using System.Text.RegularExpressions;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            List<double> grades =
            [
                Convert.ToDouble(grade1.Text),
                Convert.ToDouble(grade2.Text),
                Convert.ToDouble(grade3.Text),
                Convert.ToDouble(grade4.Text),
            ];
            gradesAvg.Text = grades.Average().ToString();
            lowestGrade.Text = grades.Min().ToString();
            condition.Text = grades.Average() >= 5 ? "Aprobado" : "Suspendido";
        }

        private void grade1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string ErrorMessage = "Please enter a valid grade nº1 between 0 and 10";
            string pattern = @"^[0-9]+([,][0-9]+)?$";
            Regex regex = new Regex(pattern);
            if (!Regex.IsMatch(grade1.Text, pattern))
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
            else if (Convert.ToDouble(grade1.Text) < 0 || Convert.ToDouble(grade1.Text) > 10)
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
        }

        private void grade2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string ErrorMessage = "Please enter a valid grade nº2 between 0 and 10";
            string pattern = @"^[0-9]+([,][0-9]+)?$";
            Regex regex = new Regex(pattern);
            if (!Regex.IsMatch(grade2.Text, pattern))
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
            else if (Convert.ToDouble(grade2.Text) < 0 || Convert.ToDouble(grade2.Text) > 10)
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
        }

        private void grade3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string ErrorMessage = "Please enter a valid grade nº3 between 0 and 10";
            string pattern = @"^[0-9]+([,][0-9]+)?$";
            Regex regex = new Regex(pattern);
            if (!Regex.IsMatch(grade3.Text, pattern))
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
            else if (Convert.ToDouble(grade3.Text) < 0 || Convert.ToDouble(grade3.Text) > 10)
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
        }

        private void grade4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string ErrorMessage = "Please enter a valid grade nº4 between 0 and 10";
            string pattern = @"^[0-9]+([,][0-9]+)?$";
            Regex regex = new Regex(pattern);
            if (!Regex.IsMatch(grade4.Text, pattern))
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
            else if (Convert.ToDouble(grade4.Text) < 0 || Convert.ToDouble(grade4.Text) > 10)
            {
                MessageBox.Show(ErrorMessage);
                e.Cancel = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
