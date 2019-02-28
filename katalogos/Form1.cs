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
        private GreekEncoder enc;
        private string secret;

        public katalogosMainForm()
        {
            InitializeComponent();
            this.bs = new BindingSource();
            this.bs.DataSource = katalogosDataGridView.DataSource;
            this.enc = new GreekEncoder();
            this.secret = "";
        }

        private void clearTextInputs()
        {
            this.antapokritisFilter.Text = "";
            this.arithmosFilter.Text = "";
            this.stratopedoPerioxiFIlter.Text = "";
            this.paratirisisFilter.Text = "";
        }

        private void resetBindingSource()
        {
            this.bs.RemoveFilter();
        }

        private void clearFilters_Click(object sender, EventArgs e)
        {
            this.clearTextInputs();
            this.resetBindingSource();
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
            this.Text = this.Text + " | ΣΥΝΟΛΟ ΕΓΓΡΑΦΩΝ: " + this.bs.Count.ToString();
        }

        private void antapokritisFilter_TextChanged(object sender, EventArgs e)
        {
            //this.bs.Filter = "antapokritis LIKE '*" + this.antapokritisFilter.Text.Trim() + "*'";
            this.bs.Filter = "antapokritis LIKE '*" + this.enc.resolveInput(this.antapokritisFilter.Text.Trim()) + "*' OR antapokritis LIKE '*" + this.antapokritisFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void arithmosFilter_TextChanged(object sender, EventArgs e)
        {
            this.bs.Filter = "arithmos LIKE '*" + this.arithmosFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void titlosFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.titlosFilter.Text.Trim().Length == 0)
            {
                return;
            }
            //this.bs.Filter = "pliris_titlos LIKE '*" + this.titlosFilter.Text.Trim() + "*'";
            this.bs.Filter = "pliris_titlos LIKE '*" + this.enc.resolveInput(this.titlosFilter.Text.Trim()) + "*' OR pliris_titlos LIKE '*" + this.titlosFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void stratopedoPerioxiFIlter_TextChanged(object sender, EventArgs e)
        {
            if (this.stratopedoPerioxiFIlter.Text.Trim().Length == 0)
            {
                this.resetBindingSource();
            }
            //this.bs.Filter = "stratopedo LIKE '*" + this.stratopedoPerioxiFIlter.Text.Trim() + "*'";
            this.bs.Filter = "stratopedo LIKE '*" + this.enc.resolveInput(this.stratopedoPerioxiFIlter.Text.Trim()) + "*' OR stratopedo LIKE '*" + this.stratopedoPerioxiFIlter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void paratirisisFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.paratirisisFilter.Text.Trim().Length == 0)
            {
                return;
            }
            //this.bs.Filter = "paratirisis LIKE '*" + this.paratirisisFilter.Text.Trim() + "*'";
            this.bs.Filter = "paratirisis LIKE '*" + this.enc.resolveInput(this.paratirisisFilter.Text.Trim()) + "*' OR paratirisis LIKE '*" + this.paratirisisFilter.Text.Trim() + "*'";
            katalogosDataGridView.DataSource = this.bs;
        }

        private void antapokritisFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.antapokritisFilter.Text.Trim().Length == 0 && e.KeyCode == Keys.Back)
            {
                this.resetBindingSource();
            }
        }

        private void stratopedoPerioxiFIlter_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.stratopedoPerioxiFIlter.Text.Trim().Length == 0 && e.KeyCode == Keys.Back)
            {
                this.resetBindingSource();
            }
        }

        private void titlosFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.titlosFilter.Text.Trim().Length == 0 && e.KeyCode == Keys.Back)
            {
                this.resetBindingSource();
            }
        }

        private void paratirisisFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.paratirisisFilter.Text.Trim().Length == 0 && e.KeyCode == Keys.Back)
            {
                this.resetBindingSource();
            }
        }

        private void katalogosMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.clearTextInputs();
                this.resetBindingSource();
            } else if (e.Control && e.KeyCode == Keys.S)
            {
                this.secret += e.KeyCode.ToString();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                this.secret += e.KeyCode.ToString();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                this.secret += e.KeyCode.ToString();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                this.secret += e.KeyCode.ToString();
            }
            
            if (this.secret.ToLower() == "stef" && this.secret.Length == 4)
            {
                MessageBox.Show("https://stefk.me", "STEF K | Feb 2019");
                this.secret = "";
            } else if (this.secret.Length > 4)
            {
                this.secret = "";
            }
        }
    }
}
