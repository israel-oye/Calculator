using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double A, B, ans;
        ArithmenticOperation operation;

        public Form1()
        {
            InitializeComponent();
           // operation = ArithmenticOperation.Addition;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            txtBox.Text = "Enter the arithmetic operation";
        }

        private void btnOn_MouseLeave(object sender, EventArgs e)
        {
            txtBox.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "1";
            //A = double.Parse(txtBox.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "2";
             //A = double.Parse(txtBox.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "3";
              //A = double.Parse(txtBox.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "4";
               //A = double.Parse(txtBox.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "5";
               //A = double.Parse(txtBox.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "6";
               //A = double.Parse(txtBox.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "7";
               //A = double.Parse(txtBox.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "8";
               //A = double.Parse(txtBox.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "9";
              // A = double.Parse(txtBox.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
             // A = double.Parse(txtBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           char[] C = txtBox.Text.ToCharArray();
            
            txtBox.Text = "";
                for(int i=0; i <= C.Length - 2; i++)
            {
                txtBox.Text += C[i].ToString();
            }
           
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + ".";
        }

        

        
        //operations
           
       /* public class Operations
        {
            double FindSum(double Soln )
            {
                double SS = Soln;
                return SS;
            }


        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
            // MessageBox.Show(A.ToString());
            operation = ArithmenticOperation.Addition;
            txtBox.Clear();

            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
          //  txtBox.Text = txtBox.Text + " - ";
            operation = ArithmenticOperation.Subtraction;
            txtBox.Clear();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
          //  txtBox.Text = txtBox.Text + "*";
            operation = ArithmenticOperation.Multiplication;
            txtBox.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
         //   txtBox.Text = txtBox.Text + "/";
            operation = ArithmenticOperation.Division;
            txtBox.Clear();
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
            txtBox.Clear();

            ans = Math.Sqrt(A);
            txtBox.Text = ans.ToString(); 
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
            txtBox.Clear();
            ans = Math.Sin(A);
            txtBox.Text = ans.ToString();
            
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
            txtBox.Clear();
            ans = Math.Cos(A);
            txtBox.Text = ans.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtBox.Text);
            txtBox.Clear();
            ans = Math.Tan(A);
            txtBox.Text = ans.ToString();
        }


        private string SolveArith(double A, double B, ArithmenticOperation operation)
        {   
            double answer = 0;
            switch (operation)
            {
                case ArithmenticOperation.Multiplication:
                    ans = A * B;
                    break;
                case ArithmenticOperation.Division:
                    ans = A / B;
                    break;
                case ArithmenticOperation.Addition:
                    ans = A + B;
                    break;
                case ArithmenticOperation.Subtraction:
                    ans = A - B;
                    break;
               
                default:
                    ans = A;
                    break;
            }

            return ans.ToString();
        }

        //Answer

        private void btnSolve_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(ans.ToString());
            double B = double.Parse(txtBox.Text);
            var ans = SolveArith(A, B, operation);
            // MessageBox.Show(ans);

            txtBox.Text = ans;

            A = double.Parse(ans);

        }
    }

    public enum ArithmenticOperation
    {
        Multiplication,
        Division,
        Addition,
        Subtraction
    }
}
