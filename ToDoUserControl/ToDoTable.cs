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
            tlpToDo.AllowDrop = true;
            tlpToDo.DragDrop += tlpToDo_DragDrop;
            tlpToDo.DragEnter += tlpToDo_DragEnter;
        }



        private void AddRow(object sender, EventArgs e)
        {
            tlpToDo.RowCount = tlpToDo.RowCount + 1;
            tlpToDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            tlpToDo.Controls.Add(new CheckBox() { Text = "", Margin = new Padding(8, 0, 0, 0) }, 0, tlpToDo.RowCount - 1);
            Control cb = tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1);
            cb.Click += new EventHandler(ClickEvent);
            tlpToDo.Controls.Add(new TextBox() { Text = "", BackColor = SystemColors.Control, BorderStyle = BorderStyle.None, Dock = DockStyle.Fill }, 1, tlpToDo.RowCount - 1);
            Control tb = tlpToDo.GetControlFromPosition(1, tlpToDo.RowCount - 1);
            tb.MouseDown += new MouseEventHandler(tbMouseDown);
            
        }

        public void tbMouseDown(object sender, EventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.Move);
        }

        public void tlpToDo_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = e.Data.GetData(typeof(TextBox)) as TextBox;
            Point location = tlpToDo.PointToClient(new Point(e.X, e.Y));
            int columnIndex = -1;
            int rowIndex = -1;
            int x = 0;
            int y = 0;

            while(columnIndex<= tlpToDo.ColumnCount)
            {
                if (location.X < x)
                    break;
                columnIndex++;
                x += tlpToDo.GetColumnWidths()[columnIndex];
            }
            while (rowIndex <= tlpToDo.RowCount)
            {
                if (location.Y < y)
                {
                    break;
                }
                rowIndex++;
                y += this.tlpToDo.GetRowHeights()[rowIndex];
            }

            tlpToDo.Controls.Add(tb, columnIndex, rowIndex);
        }

        public void tlpToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        public void ClickEvent(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition tlpcp = tlpToDo.GetPositionFromControl((Control)sender);

            Control c = tlpToDo.GetControlFromPosition(tlpcp.Column + 1, tlpcp.Row);
            if (c.Enabled)
                c.Enabled = false;
            else
                c.Enabled = true;
        }
    }
}
