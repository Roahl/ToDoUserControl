namespace ToDoUserControl
{
    partial class RowControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbRow = new System.Windows.Forms.CheckBox();
            this.tbRow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbRow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbRow);
            this.splitContainer1.Size = new System.Drawing.Size(484, 22);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbRow
            // 
            this.cbRow.AutoSize = true;
            this.cbRow.Location = new System.Drawing.Point(7, 4);
            this.cbRow.Name = "cbRow";
            this.cbRow.Size = new System.Drawing.Size(15, 14);
            this.cbRow.TabIndex = 0;
            this.cbRow.UseVisualStyleBackColor = true;
            this.cbRow.CheckedChanged += new System.EventHandler(this.checked_unchecked);
            // 
            // tbRow
            // 
            this.tbRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRow.BackColor = System.Drawing.SystemColors.Control;
            this.tbRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRow.Location = new System.Drawing.Point(0, 4);
            this.tbRow.Margin = new System.Windows.Forms.Padding(0);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(455, 13);
            this.tbRow.TabIndex = 0;
            // 
            // RowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RowControl";
            this.Size = new System.Drawing.Size(484, 22);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbRow;
        private System.Windows.Forms.TextBox tbRow;
    }
}
