using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalcIntervall_Click(object sender, EventArgs e)
        {
            try
            {
                time int1from = new time(Convert.ToInt32(txt_int1_from_hour.Text), Convert.ToInt32(txt_int1_from_minute.Text));
                time int1to = new time(Convert.ToInt32(txt_int1_to_hour.Text), Convert.ToInt32(txt_int1_to_minute.Text));
                time int2from = new time(Convert.ToInt32(txt_int2_from_hour.Text), Convert.ToInt32(txt_int2_from_minute.Text));
                time int2to = new time(Convert.ToInt32(txt_int2_to_hour.Text), Convert.ToInt32(txt_int2_to_minute.Text));
                intervall int1 = new intervall(int1from, int1to);
                intervall int2 = new intervall(int2from, int2to);

                MessageBox.Show(intervall.GetIntervallState(int1, int2));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ungültige Eingabe!");
            }

            catch (ArgumentException i)
            {
                MessageBox.Show(i.Message);
            }

            
            
        }

        private void btn_ResetForm_Click(object sender, EventArgs e) {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

    }
}
