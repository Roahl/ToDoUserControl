using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoUserControl
{
    /// <summary>
    /// UserControl that creates a To Do table capable of adding rows through an included button, as well as changing color and enabling or disabling text
    /// </summary>
    public partial class ToDoTable : UserControl
    {
        private String color { get; set; }
        private Color ORANGE = Color.FromArgb(255, 152, 1);
        private Color BLUE = Color.FromArgb(28, 175, 249);
        private Color GREEN = Color.FromArgb(101, 219, 58);
        private Color PURPLE = Color.FromArgb(209, 105, 233);
        private Color BLACK = Color.FromArgb(0, 0, 0);
        /// <summary>
        /// Basic constructor
        /// </summary>
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
            
                tlpToDo.RowCount = tlpToDo.RowCount + 1;
                tlpToDo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpToDo.Controls.Add(new CheckBox() {  Text = "", Margin = new Padding(8, 0, 0, 0),Anchor = (AnchorStyles.Top|AnchorStyles.Left)}, 0, tlpToDo.RowCount - 1);
                Control c = tlpToDo.GetControlFromPosition(0, tlpToDo.RowCount - 1);
                c.Click += new EventHandler(evento);
                tlpToDo.Controls.Add(new TextBox() { AllowDrop=true,Name ="tbRow-"+tlpToDo.RowCount, Text = "",Dock = DockStyle.Fill, BackColor = SystemColors.Control, ForeColor=changeColor(this.color), BorderStyle = BorderStyle.None}, 1, tlpToDo.RowCount - 1);
                Control cc = tlpToDo.GetControlFromPosition(1, tlpToDo.RowCount - 1);
                cc.DragEnter += new DragEventHandler(dragEnter);
                cc.DragDrop += new DragEventHandler(dragDrop);

        }
        /// <summary>
        /// Method called when a checkbox in any row is changed from unchecked to checked or viceversa
        /// to change the textbox next to it form enabled to disabled or viceversa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento(object sender, EventArgs e)
         {
             TableLayoutPanelCellPosition tlpcp = tlpToDo.GetPositionFromControl((Control)sender);
             
             Control c = tlpToDo.GetControlFromPosition(tlpcp.Column + 1, tlpcp.Row);
 
             if (c.Enabled)
                 c.Enabled = false;
             else
                 c.Enabled = true;
         }

        /// <summary>
        /// Method that changes the forecolor of every textbox present on the usercontrol
        /// </summary>
        /// <param name="color">Color the text should change into</param>
        /// <returns>Returns the Color that the TextBoxes are in, for future use</returns>
        public Color changeColor(string color)
        {
            Color actualColor = BLACK;
            this.color = color;
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
                                actualColor = ORANGE;
                                break;
                            case "blue":
                                cc.ForeColor = BLUE;
                                actualColor = BLUE;
                                break;
                            case "green":
                                cc.ForeColor = GREEN;
                                actualColor = GREEN;
                                break;
                            case "purple":
                                cc.ForeColor = PURPLE;
                                actualColor = PURPLE;
                                break;
                        }
                    }
                }
            }
            return actualColor;
        }

        /// <summary>
        /// Simple method to return the color of the textboxes
        /// </summary>
        /// <returns>String that corresponds to the Color of the textboxes</returns>
        public string returnColor()
        {
            String color = this.color;
            return color;
        }

        private void dragEnter(object sender,System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dragDrop(object sender,System.Windows.Forms.DragEventArgs e)
        {
            ((TextBox)sender).Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
