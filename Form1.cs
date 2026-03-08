using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox txtOutput;
        Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        Button btnPlus, btnEqual;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Kalkulator";
            this.Size = new System.Drawing.Size(240, 360);

            txtOutput = new TextBox();
            txtOutput.Location = new System.Drawing.Point(20, 20);
            txtOutput.Size = new System.Drawing.Size(180, 40);
            txtOutput.TextAlign = HorizontalAlignment.Right;
            txtOutput.Text = "0";
            txtOutput.ReadOnly = true;

            btn1 = new Button(); btn1.Text = "1"; btn1.Size = new System.Drawing.Size(50, 50); btn1.Location = new System.Drawing.Point(20, 80);
            btn2 = new Button(); btn2.Text = "2"; btn2.Size = new System.Drawing.Size(50, 50); btn2.Location = new System.Drawing.Point(85, 80);
            btn3 = new Button(); btn3.Text = "3"; btn3.Size = new System.Drawing.Size(50, 50); btn3.Location = new System.Drawing.Point(150, 80);

            btn4 = new Button(); btn4.Text = "4"; btn4.Size = new System.Drawing.Size(50, 50); btn4.Location = new System.Drawing.Point(20, 140);
            btn5 = new Button(); btn5.Text = "5"; btn5.Size = new System.Drawing.Size(50, 50); btn5.Location = new System.Drawing.Point(85, 140);
            btn6 = new Button(); btn6.Text = "6"; btn6.Size = new System.Drawing.Size(50, 50); btn6.Location = new System.Drawing.Point(150, 140);

            btn7 = new Button(); btn7.Text = "7"; btn7.Size = new System.Drawing.Size(50, 50); btn7.Location = new System.Drawing.Point(20, 200);
            btn8 = new Button(); btn8.Text = "8"; btn8.Size = new System.Drawing.Size(50, 50); btn8.Location = new System.Drawing.Point(85, 200);
            btn9 = new Button(); btn9.Text = "9"; btn9.Size = new System.Drawing.Size(50, 50); btn9.Location = new System.Drawing.Point(150, 200);

            btnPlus = new Button(); btnPlus.Text = "+"; btnPlus.Size = new System.Drawing.Size(50, 50); btnPlus.Location = new System.Drawing.Point(20, 260);
            btn0 = new Button(); btn0.Text = "0"; btn0.Size = new System.Drawing.Size(50, 50); btn0.Location = new System.Drawing.Point(85, 260);
            btnEqual = new Button(); btnEqual.Text = "="; btnEqual.Size = new System.Drawing.Size(50, 50); btnEqual.Location = new System.Drawing.Point(150, 260);

            this.Controls.Add(txtOutput);
            this.Controls.Add(btn1); this.Controls.Add(btn2); this.Controls.Add(btn3);
            this.Controls.Add(btn4); this.Controls.Add(btn5); this.Controls.Add(btn6);
            this.Controls.Add(btn7); this.Controls.Add(btn8); this.Controls.Add(btn9);
            this.Controls.Add(btnPlus); this.Controls.Add(btn0); this.Controls.Add(btnEqual);
        }
    }
}