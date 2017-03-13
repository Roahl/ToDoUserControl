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
        /// <summary>
        /// Method called when plus button is pressed, adds a new row to the TableLayoutPanel and adds
        /// a user controls to it dynamically
        /// </summary>
        /// <param name="sender">Plus button</param>
        /// <param name="e">Arguments of the event</param>
        public void AddRow(object sender, EventArgs e)
        {
            tlpToDo.RowCount = tlpToDo.RowCount + 1;
            tlpToDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tlpToDo.Controls.Add(new RowControl(),0,tlpToDo.RowCount-1);
            tlpToDo.SetColumnSpan(tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1), 2);
            Control c = tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1);
            c.MouseDown += tbMouseDown;
        }

        /// <summary>
        /// Method called when an event MouseDown is fired
        /// </summary>
        /// <param name="sender">Control that fires the event</param>
        /// <param name="e">Arguments of the event</param>
        public void tbMouseDown(object sender, EventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.Move);
        }

        /// <summary>
        /// Set the effects of Drag and Drop 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tlpToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Defines the behaviour during a Drag and Drop process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tlpToDo_DragDrop(object sender, DragEventArgs e)
        {
            RowControl tb = e.Data.GetData(typeof(RowControl)) as RowControl;
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
    }
}
