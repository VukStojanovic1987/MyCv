using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Library
{
    class clsSelectRow
    {
        public void LastAdded(DataGridView dataGridView, DataTable table)
        {
            DataRow lastRow = table.Rows[table.Rows.Count - 1];

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(lastRow["ID"]))
                {
                    dataGridView.CurrentCell = row.Cells[1];
                    row.Selected = true;
                }
            }
        }
    }
}