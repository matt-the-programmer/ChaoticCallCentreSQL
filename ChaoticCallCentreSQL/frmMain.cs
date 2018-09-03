using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallDataLayer;

namespace ChaoticCallCentreSQL
{
    public partial class frmMain : Form
    {
        
        List<Calls> callsList;
        List<Telco> telcoList;
        int index = 0;

        public frmMain()
        {

            InitializeComponent();
            TelcoManager telcos = new TelcoManager();
            telcoList = telcos.GetAllTelcos();

            cboTelco.DataSource = telcoList;
           cboTelco.DisplayMember = "TelcoName";
            cboTelco.ValueMember = "ID";
            
        }
        
        private void DisplayRecord()
        {
            lblID.Text = callsList[index].ID.ToString();
            txtName.Text = callsList[index].Name;
            txtNumber.Text = callsList[index].Number;
            cboTelco.SelectedValue = callsList[index].Telco;
            nudRating.Value = callsList[index].Rating;
            txtComment.Text = callsList[index].Comment;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            CallManager manager = new CallManager();
            callsList = manager.GetAllCalls();

            index = Math.Min(index + 1, callsList.Count - 1);
            //NavSetup navsetup = new NavSetup();
            DisplayRecord();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            CallManager manager = new CallManager();
            callsList = manager.GetAllCalls();

            index = Math.Max(index - 1, 0);
            DisplayRecord();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "0";
            txtName.Clear();
            txtNumber.Clear();
            cboTelco.Text = "";
            nudRating.Value = 0;
            txtComment.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Calls calls = new Calls();
            calls.ID = Convert.ToInt32(lblID.Text);
            calls.Name = txtName.Text;
            calls.Number = txtNumber.Text;
            calls.Telco = Convert.ToInt32(cboTelco.SelectedValue);
            calls.Rating = Convert.ToInt32(nudRating.Value);
            calls.Comment = txtComment.Text;
            CallManager manager = new CallManager();
            manager.SaveOrUpdate(calls);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NameAndTelcoNameManager manager = new NameAndTelcoNameManager();
            List<NameAndTelcoName> list = manager.Search(txtSearch.Text);
            dgvSearch.DataSource = list;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
