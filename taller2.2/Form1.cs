using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double edad, total;
            edad = double.Parse(txtfecha.Text);

            total = (2019 - edad) ;

            lbledad.Text = total.ToString();

            if (total >= 18)
            {
                MessageBox.Show("Es mayor de edad!");
            }
            else
            {
                MessageBox.Show("Es menor de edad!");
            }
            }
                }

            }
        
    
