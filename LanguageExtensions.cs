using System;
using System.Windows.Forms;
using System.Data;

/// <summary>
/// Contains two methods for moving DataRows up/down. 
/// You could easily tweak the code to work for say a ListBox.
/// </summary>
/// <remarks></remarks>
public static class LanguageExtensions
{

	



    public static void MoveRowUp(this DataGridView sender, BindingSource bs)
    {
        
        int CurrentColumnIndex = sender.CurrentCell.ColumnIndex;							// get column 
        Int32 NewIndex = Convert.ToInt32((bs.Position == 0) ? 0 : bs.Position - 1);
        var dt = (DataTable)bs.DataSource;
        DataRow RowToMove = ((DataRowView)bs.Current).Row;
        DataRow NewRow = dt.NewRow();

        NewRow.ItemArray = RowToMove.ItemArray;
        dt.Rows.RemoveAt(bs.Position);
        dt.Rows.InsertAt(NewRow, NewIndex);
        dt.AcceptChanges();
        bs.Position = NewIndex;
        sender.CurrentCell = sender[CurrentColumnIndex, NewIndex];
    }





	public static void MoveRowDown(this DataGridView sender, BindingSource bs)
	{
		
		int CurrentColumnIndex = sender.CurrentCell.ColumnIndex;
		Int32 UpperLimit = bs.Count - 1;
		Int32 NewIndex = Convert.ToInt32((bs.Position + 1 >= UpperLimit) ? UpperLimit : bs.Position + 1);
		var dt = (DataTable)bs.DataSource;
		DataRow RowToMove = ((DataRowView)bs.Current).Row;
		DataRow NewRow = dt.NewRow();

		NewRow.ItemArray = RowToMove.ItemArray;
		dt.Rows.RemoveAt(bs.Position);
		dt.Rows.InsertAt(NewRow, NewIndex);
		dt.AcceptChanges();
		bs.Position = NewIndex;
		sender.CurrentCell = sender[CurrentColumnIndex, NewIndex];
	}





	
}