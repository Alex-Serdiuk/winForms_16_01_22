using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_01_22
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Label label3;
        public Form1()
        {
            InitializeComponent();
            label3 = new Label();
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(208, 126);
            this.label3.Name = "label2";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "новая метка";
            this.Controls.Add(label3);
            this.label3.Click += new System.EventHandler(this.label2_Click_1);
        }

        //private void label2_Click(Object Sender, EventArgs e)
        //{
        //    MessageBox.Show("Нажата метка", "Сообщение");

        //}

        private void label2_Click_1(object sender, EventArgs e)
        {
            Label labelX = (Label)sender;
            labelX.BackColor = Color.DarkCyan;
            MessageBox.Show("Нажата метка\n"+labelX.Text, "Сообщение");
     
                string buff = label1.Text;
                label1.Text = label2.Text;
                label2.Text = buff;
                label2.Text = label3.Text;
                label3.Text = buff;
        }

        private void acceptBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (.CheckState)
        }

        private void Включено_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                acceptBox.CheckState = CheckState.Unchecked;
            }
            else
            {
                acceptBox.CheckState = CheckState.Indeterminate;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (acceptBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Принято", "Состояние чекбокса", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            if (acceptBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Не принято", "Состояние чекбокса", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            else
            if (acceptBox.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("не выяснено", "Состояние чекбокса", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            monthCalendar1.SelectionStart = new DateTime(2022, 1, 2);
            monthCalendar1.SelectionEnd = new DateTime(2022, 1, 28);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker tim = sender as DateTimePicker;
            Text = tim.Value.ToLongDateString() + ' ' + tim.Value.ToLongTimeString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar tim = sender as MonthCalendar;
            Text = tim.SelectionStart.ToLongDateString()+" до "+tim.SelectionEnd.ToLongDateString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender != this)
            {
                Control control = sender as Control;
                Point xy = control.Location;
                Text = $"[{e.X+xy.X}:{e.Y+xy.Y}] {e.Button}";
            }
            else
            {
                Text = $"[{e.X}:{e.Y}] {e.Button}";
            }
           
        }
        int tiks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counterBox2.Text = tiks++.ToString();
            if (tiks > 10)
                timer1.Stop();
        }
    }
}
