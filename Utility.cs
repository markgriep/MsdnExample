using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;



namespace uti
{
	public static class Utility
	{


		public static void FillDataGridViewWithRandomData(int NumberOfRecords, DataGridView DataGridViewDestination)
		{

			DataSet DS1 = new DataSet();								// instantiate a DS and a DT
			DataTable dt1 = new DataTable();
		
			DS1.Tables.Add(dt1);

			dt1.Columns.Add("Row", typeof(int));
			dt1.Columns.Add("ProductID", typeof(string));
			dt1.Columns.Add("ProductDescription", typeof(string));
			dt1.Columns.Add("Quantity", typeof(int));
			

			for (int i = 0; i < NumberOfRecords; i++)					// loop through and add number of items
			{
				dt1.Rows.Add(i, RandomData.GetRandNum(), RandomData.GetProductName(), RandomData.GetRandNum());
			}

			DataGridViewDestination.DataSource = dt1;					// push datasource out to the DGV
			DataGridViewDestination.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;	// set columns so you can see them fully.


		}



		public static DataTable FillDTWithRandomData(int NumberOfRecords)
		{

			DataSet DS1 = new DataSet();								// instantiate a DS and a DT
			DataTable dt1 = new DataTable();
		
			DS1.Tables.Add(dt1);

			dt1.Columns.Add("Row", typeof(int));
			dt1.Columns.Add("ProductID", typeof(string));
			dt1.Columns.Add("ProductDescription", typeof(string));
			dt1.Columns.Add("Quantity", typeof(int));
			

			for (int i = 0; i < NumberOfRecords; i++)					// loop through and add number of items
			{
				dt1.Rows.Add(i, RandomData.GetRandNum(), RandomData.GetProductName(), RandomData.GetRandNum());
			}

			return dt1;

			//DataGridViewDestination.DataSource = dt1;					// push datasource out to the DGV
			//DataGridViewDestination.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;	// set columns so you can see them fully.


		}




	}
}
