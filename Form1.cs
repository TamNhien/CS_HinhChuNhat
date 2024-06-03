using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HinhChuNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "")
            {
                MessageBox.Show("Phai nhap chieu ngang va chieu doc");
                return;
            }
            double a, b, P;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);

            P = (a + b) * 2;

            txtKQ.Text = P.ToString(); 
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "")
            {
                MessageBox.Show("Phai nhap chieu ngang va chieu doc");
                return;
            }
            double a, b, S;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);

            S = a * b;

            txtKQ.Text = S.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnThoat.Text = "Exit";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (rdbCV.Checked)
            {
                if (txta.Text == "" || txtb.Text == "")
                {
                    MessageBox.Show("Phai nhap chieu ngang va chieu doc");
                    return;
                }
                double a, b, P;
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);

                P = (a + b) * 2;

                txtKQ.Text = P.ToString();
            }

            if (rdbDT.Checked)
            {
                if (txta.Text == "" || txtb.Text == "")
                {
                    MessageBox.Show("Phai nhap chieu ngang va chieu doc");
                    return;
                }
                double a, b, S;
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);

                S = a * b;

                txtKQ.Text = S.ToString();
            }    
        }
    }
}
