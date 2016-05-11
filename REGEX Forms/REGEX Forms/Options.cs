using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.DataTable;

namespace REGEX_Forms
{
    public partial class Options : Form
    {

        public Options()
        {
            InitializeComponent();
        }

        public struct OptionVal
        {
            public int listId { get; set; } // maybe?
            public string opName { get; set; }
            public string strValue { get; set; }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            List<OptionVal> regOptions = new List<OptionVal>();

            regOptions.Add(new OptionVal { opName = "Any Digit", strValue = "'\'d" });
            regOptions.Add(new OptionVal { opName = "Any non-digit", strValue = "'\'D" });
            regOptions.Add(new OptionVal { opName = "Any character", strValue = "." });
            
            this.OptionsList.DataSource = regOptions;
            this.OptionsList.DisplayMember = "opName";
            this.OptionsList.ValueMember = "strValue";
        }

    }
}
