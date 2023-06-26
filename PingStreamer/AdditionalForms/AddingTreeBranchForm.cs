using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingStreamer.AdditionalForms
{
    public partial class AddingTreeBranchForm : Form
    {
        private static AddingTreeBranchForm instance;
        public static AddingTreeBranchForm getInstance()
        {
            if (instance == null)
                instance = new AddingTreeBranchForm();
            return instance;
        }
        private AddingTreeBranchForm()
        {
            InitializeComponent();
        }
    }
}
