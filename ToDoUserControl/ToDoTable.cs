using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoUserControl
{
    public partial class ToDoTable : UserControl
    {
        public ToDoTable()
        {
            InitializeComponent();
        }

        public void AddRow(object sender, EventArgs e)
        {
            tlpToDo.RowCount = tlpToDo.RowCount + 1;
            tlpToDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            tlpToDo.Controls.Add(new CheckBox() { Text = "", Margin = new Padding(8, 0, 0, 0) }, 0, tlpToDo.RowCount - 1);
            Control c = tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1);
            c.Click += new EventHandler(evento);
            tlpToDo.Controls.Add(new TextBox() { Text = "", BackColor = SystemColors.Control, BorderStyle = BorderStyle.None, Dock = DockStyle.Fill }, 1, tlpToDo.RowCount - 1);
        }

        public void evento(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition tlpcp = tlpToDo.GetPositionFromControl((Control)sender);
            
            Control c = tlpToDo.GetControlFromPosition(tlpcp.Column+1, tlpcp.Row);

            if (c.Enabled)
                c.Enabled = false;
            else
                c.Enabled = true;
        }
    }
}
