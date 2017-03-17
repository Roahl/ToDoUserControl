using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoUserControl
{
    public partial class ToDoTable : UserControl
    {
        private Color ORANGE = Color.FromArgb(255, 152, 1);
        private Color BLUE = Color.FromArgb(28, 175, 249);
        private Color GREEN = Color.FromArgb(101, 219, 58);
        private Color PURPLE = Color.FromArgb(209, 105, 233);
        public ToDoTable()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method called when plus button is pressed, adds a new row to the TableLayoutPanel and adds
        /// a user controls to it dynamically
        /// </summary>
        /// <param name="sender">Plus button</param>
        /// <param name="e">Arguments of the event</param>
        public void AddRow(object sender, EventArgs e)
        {
            if (tlpToDo.RowCount <= 24)
            {
                tlpToDo.RowCount = tlpToDo.RowCount + 1;
                tlpToDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpToDo.Controls.Add(new CheckBox() { Text = "", Margin = new Padding(8, 0, 0, 0) }, 0, tlpToDo.RowCount - 1);
                Control c = tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1);
                c.Click += new EventHandler(evento);
                tlpToDo.Controls.Add(new TextBox() { Name ="tbRow-"+tlpToDo.RowCount, Text = "", BackColor = SystemColors.Control, BorderStyle = BorderStyle.None, Dock = DockStyle.Fill }, 1, tlpToDo.RowCount - 1);
            }
        }
        
        private void evento(object sender, EventArgs e)
         {
             TableLayoutPanelCellPosition tlpcp = tlpToDo.GetPositionFromControl((Control)sender);
             
             Control c = tlpToDo.GetControlFromPosition(tlpcp.Column + 1, tlpcp.Row);
 
             if (c.Enabled)
                 c.Enabled = false;
             else
                 c.Enabled = true;
         }

        public void changeColor(string color)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    foreach (Control cc in c.Controls)
                    {
                        switch (color)
                        {
                            case "orange":
                                cc.ForeColor = ORANGE;
                                break;
                            case "blue":
                                cc.ForeColor = BLUE;
                                break;
                            case "green":
                                cc.ForeColor = GREEN;
                                break;
                            case "purple":
                                cc.ForeColor = PURPLE;
                                break;
                        }
                    }
                }
            }
        }
    }
}
