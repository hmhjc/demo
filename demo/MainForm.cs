using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Multiplicationtable_Click(object sender, EventArgs e)
        {
            MultiplicationtableForm mf = new MultiplicationtableForm();
            mf.Show();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.Show();
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            DatabaseForm df = new DatabaseForm();
            df.Show();
        }

        private void btn_Notepad_Click(object sender, EventArgs e)
        {
            NotepadForm nf = new NotepadForm();
            nf.Show();
        }
    }
}