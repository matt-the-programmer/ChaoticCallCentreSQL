using CallData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCallCentreGloriousEdition
{
    public partial class frmMain : Form
    {
        List<Calls> theList;
        int index = 0; // which record we're looking at
        List<Calls> listOfCalls; // no value set yet

        public frmMain()
        {
            InitializeComponent();
            listOfCalls = CallManager.LoadAllCalls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            CallData.Calls saveCall = new CallData.Calls();

            saveCall.Name = txtName.Text;
            saveCall.Number = txtNumber.Text;
            saveCall.Telco = cboTelco.Text;
            saveCall.Rating = (int)nudRating.Value;
            saveCall.Comments = txtComments.Text;


            CallData.CallManager.SaveCall(saveCall);
        }
        private void DisplayCall()
        {
            txtName.Text = listOfCalls[index].Name;
            txtNumber.Text = listOfCalls[index].Number;
            cboTelco.Text = listOfCalls[index].Telco;
            nudRating.Value = listOfCalls[index].Rating;
            txtComments.Text = listOfCalls[index].Comments;
        }
            private void btnFirst_Click(object sender, EventArgs e)
            {
                
                listOfCalls = CallManager.LoadAllCalls();
                if (listOfCalls.Count > 0)
                {
                    // only attempt to display a record...
                    // if there is more than 0 records loaded
                    // can't display a record that doesn't exist
                    index = 0;
                    DisplayCall();
                }
            }
        private void btnLast_Click(object sender, EventArgs e)
        {
            listOfCalls = CallManager.LoadAllCalls();
            if (listOfCalls.Count > 0)
            {
                index = listOfCalls.Count - 1;
                DisplayCall();
                // if a collection has 5 elements: 0, 1, 2, 3, 4
                // count returns 5, but last element is 4
                // therefore: last element is count/length - 1
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            listOfCalls = CallManager.LoadAllCalls();

            if (index > 0) index--;

            DisplayCall();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            listOfCalls = CallManager.LoadAllCalls();

            index++;
            if (index == listOfCalls.Count) index--;

            DisplayCall();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            // search through list of birthdays:
            //  find birthdays that have a first name that contains
            //  whatever was typed into txtSearch
            //  display those birthdays in the gridview

            var birthdays = from call in listOfCalls
                            where call.Name.Contains(searchTerm)
                            || call.Number.Contains(searchTerm)
                            || call.Telco.Contains(searchTerm)
                            || call.Rating.ToString().Contains(searchTerm)
                            select call;

            dgvResults.DataSource = null; // clear the dgv
           dgvResults.DataSource = birthdays.ToList(); // then show the results
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            theList = CallData.CallManager.LoadAllCalls();

            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Saved Call files|*.bin";
           

            //DialogResult result = dialog.ShowDialog();
           

            //if (result == DialogResult.OK)
            //{

            //    CallData.Calls loadedCall = CallData.CallManager.LoadCall(dialog.FileName);

            //    txtName.Text = loadedCall.Name;
            //    txtNumber.Text = loadedCall.Number;
            //    cboTelco.Text = loadedCall.Telco;
            //    nudRating.Value = loadedCall.Rating;
            //    txtComments.Text = loadedCall.Comments;


            //    // file has now been loaded and copied to the screen
            //}

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}