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
    public partial class RowControl : UserControl
    {
        
        public RowControl()
        {
            InitializeComponent();
            
        }

        private void checked_unchecked(object sender, EventArgs e)
        {

            tbRow.Enabled = cbRow.Checked ? false : true;

        }
    }
}
