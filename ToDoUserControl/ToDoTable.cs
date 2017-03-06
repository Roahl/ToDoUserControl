using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoUserControl
{
    public partial class ToDoTable : UserControl
    {
        public ToDoTable()
        {
            InitializeComponent();
        }

        private void AddRow(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            tableLayoutPanel1.Controls.Add(new CheckBox() { Text = "", Margin = new Padding(8, 0, 0, 0) }, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new TextBox() { Text = "", BackColor = SystemColors.Control, BorderStyle = BorderStyle.None }, 1, tableLayoutPanel1.RowCount - 1);
        }
    }
}
