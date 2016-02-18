using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleMsAccess
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
          
            DataTable dt = new DataTable();
		  dt = uti.Utility.FillDTWithRandomData(100);

            bs.DataSource = dt;
            DataGridView1.DataSource = bs;
            ActiveControl = textBox1;
        }




		



        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				LanguageExtensions.MoveRowUp(DataGridView1, bs);
				DataGridView1.Refresh();

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			for (int i = 0; i < 10; i++)
			{
				LanguageExtensions.MoveRowDown(DataGridView1, bs);
				LanguageExtensions.MoveRowDown(DataGridView1, bs);
				LanguageExtensions.MoveRowDown(DataGridView1, bs);
				LanguageExtensions.MoveRowDown(DataGridView1, bs);
				DataGridView1.Refresh();

			}

			
		}

		private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e, MouseEventArgs me)
		{
			if ()
			{

			}
		}
	}
}