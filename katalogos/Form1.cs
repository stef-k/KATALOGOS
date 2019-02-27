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
        private BindingSource bs;

        public katalogosMainForm()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.bs.DataSource = katalogosDataGridView.DataSource;
        }

        private void searchFilter_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();

            //bs.DataSource = katalogosDataGridView.DataSource;
            bs.Filter = "antapokritis LIKE '*" + this.antapokritisFilter.Text.Trim() + "*' OR stratopedo LIKE '*" + this.antapokritisFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = bs;
        }

        private void clearFilters_Click(object sender, EventArgs e)
        {
            this.antapokritisFilter.Text = "";
            this.arithmosFilter.Text = "";
            this.stratopedoPerioxiFIlter.Text = "";
            this.paratirisisFilter.Text = "";
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

        private void antapokritisFilter_TextChanged(object sender, EventArgs e)
        {
            this.bs.Filter = "antapokritis LIKE '*" + this.antapokritisFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void arithmosFilter_TextChanged(object sender, EventArgs e)
        {
            this.bs.Filter = "arithmos LIKE '*" + this.arithmosFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void titlosFilter_TextChanged(object sender, EventArgs e)
        {
            this.bs.Filter = "pliris_titlos LIKE '*" + this.titlosFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void stratopedoPerioxiFIlter_TextChanged(object sender, EventArgs e)
        {
            
            this.bs.Filter = "stratopedo LIKE '*" + this.stratopedoPerioxiFIlter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void paratirisisFilter_TextChanged(object sender, EventArgs e)
        {
            this.bs.Filter = "paratirisis LIKE '*" + this.paratirisisFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }
    }
}
