namespace ToDoUserControl
{
    partial class ToDoTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpToDo = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpToDo
            // 
            this.tlpToDo.AutoScroll = true;
            this.tlpToDo.ColumnCount = 2;
            this.tlpToDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpToDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.83334F));
            this.tlpToDo.Controls.Add(this.btnAdd, 0, 0);
            this.tlpToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToDo.Location = new System.Drawing.Point(0, 0);
            this.tlpToDo.Name = "tlpToDo";
            this.tlpToDo.RowCount = 1;
            this.tlpToDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpToDo.Size = new System.Drawing.Size(600, 500);
            this.tlpToDo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::ToDoUserControl.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddRow);
            this.btnAdd.DragDrop += new System.Windows.Forms.DragEventHandler(this.ccc);
            // 
            // ToDoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpToDo);
            this.Name = "ToDoTable";
            this.Size = new System.Drawing.Size(600, 500);
            this.tlpToDo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpToDo;
        private System.Windows.Forms.Button btnAdd;
    }
}
