using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace katalogos
{
    public partial class katalogosMainForm : Form
    {
        public katalogosMainForm()
        {
            InitializeComponent();
        }

        private void searchFilter_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = katalogosDataGridView.DataSource;
            bs.Filter = "antapokritis LIKE '*" + this.searchFilter.Text.Trim() + "*' OR stratopedo LIKE '*" + this.searchFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = bs;
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            this.searchFilter.Text = "";
        }

        private void katalogosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.katalogosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.katalogosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'katalogosDataSet.katalogos' table. You can move, or remove it, as needed.
            this.katalogosTableAdapter.Fill(this.katalogosDataSet.katalogos);

        }
    }
}
