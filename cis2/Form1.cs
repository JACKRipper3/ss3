using System;

namespace cis2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void result1_Click(object sender, EventArgs e)
        {
            //เลขทศนิยม
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert strimg to number (intrger)
            //double / float = ใส่ค่าเลขจำนวนเต็มเป็นทศนิยม
            //int / tnteger =
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 + iNum2;

            result.Text = iResult.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //เลขทศนิยม
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert strimg to number (intrger)
            //double / float = ใส่ค่าเลขจำนวนเต็มเป็นทศนิยม
            //int / tnteger =
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 * iNum2;

            result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //เลขทศนิยม
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert strimg to number (intrger)
            //double / float = ใส่ค่าเลขจำนวนเต็มเป็นทศนิยม
            //int / tnteger =
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 - iNum2;

            result.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //เลขทศนิยม
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert strimg to number (intrger)
            //double / float = ใส่ค่าเลขจำนวนเต็มเป็นทศนิยม
            //int / tnteger =
            int iNum1 = Int32.Parse(inputNum1);
            int iNum2 = Int32.Parse(inputNum2);
            int iResult = iNum1 / iNum2;

            result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
