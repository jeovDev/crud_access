using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSACCESSDB_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Clearfields()
        {
            lbID.Text = "";
            txfname.Text = "";
            txlname.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cmbStatus.SelectedIndex = -1;
            
        }
        void DisableFields()
        {
            txfname.Enabled = false;
            txlname.Enabled = false;
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
            cmbStatus.Enabled = false;
            dtdob.Enabled = false;
        }
        void EnableFields()
        {
            txfname.Enabled = true;
            txlname.Enabled = true;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
            cmbStatus.Enabled = true;
            dtdob.Enabled = true;
        }
        void DisableButtons()
        {
            btnsave.Enabled = false;
            btnedit.Enabled = false;
            btndel.Enabled = false;
            btncancel.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisableFields();
            DisableButtons();
            LoadListView();
            loadCombobox();
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearfields();
            EnableFields();
            btnsave.Enabled = true;
            btncancel.Enabled = true;
            btnedit.Enabled = false;
            btndel.Enabled = false;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Clearfields();
            DisableFields();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (lbID.Text == "")
            {
                SQL save = new SQL();
                save.firstname = txfname.Text;
                save.lastname = txlname.Text;
                save.status = cmbStatus.SelectedValue.ToString();
                if (rbMale.Checked) save.gender = rbMale.Text;
                if (rbFemale.Checked) save.gender = rbFemale.Text;
                save.dob = dtdob.Value.ToShortDateString();
                save.Save();
            }
            else 
            {
                SQL update = new SQL();
                update.firstname = txfname.Text;
                update.lastname = txlname.Text;
                update.status = cmbStatus.SelectedValue.ToString();
                if (rbMale.Checked) update.gender = rbMale.Text;
                if (rbFemale.Checked) update.gender = rbFemale.Text;
                update.dob = dtdob.Value.ToShortDateString();
                update.ID = lbID.Text;
                update.Update();
            }
         
            LoadListView();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            EnableFields();
            btnsave.Enabled = true;
        }
        private void btndel_Click(object sender, EventArgs e)
        {
          
            DialogResult response = MessageBox.Show("Are you sure you want to delete this record ?","Delete" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                SQL delete = new SQL();
                delete.ID = lbID.Text;
                delete.Delete();
                LoadListView();
            }
        }
        void LoadListView()
        {

                SQL retrieve = new SQL();
                retrieve.datas = listView1;
                retrieve.Retrieve();                 
        }
        void loadCombobox()
        {

                SQL combostatus = new SQL();
                combostatus.combo = cmbStatus;
                combostatus.Combobox();
                
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                SQL selected = new SQL();
                selected.ID = listView1.SelectedItems[0].Text;
                selected.Male = rbMale;
                selected.Female = rbFemale;
                selected.lvSelection();
                lbID.Text = selected.ID;
                txfname.Text = selected.firstname;
                txlname.Text = selected.lastname;
                cmbStatus.SelectedValue = Convert.ToInt32(selected.status);
                dtdob.Text = selected.dob;

                DisableFields();
                btnedit.Enabled = true;
                btndel.Enabled = true;
                btncancel.Enabled = true;
            }
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            SQL search = new SQL();
            search.datas = listView1;
            search.Search(txSearch.Text);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

      
    }
}
