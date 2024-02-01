using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForm.Forms
{
    public partial class FrmDetailContact : Form
    {
        private readonly int ContactId;
        private readonly GetContactDetailService _getContactDetailService;
        public FrmDetailContact(int contactId)
        {
            InitializeComponent();
            ContactId = contactId;
            _getContactDetailService = new GetContactDetailService();
        }

        private void FrmDetailContact_Load(object sender, EventArgs e)
        {

            var DetailContact = _getContactDetailService.GetContactDetail(ContactId);

            if (DetailContact.IsSuccess == false)
            {
                MessageBox.Show(DetailContact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblFirstName.Text = DetailContact.Data.FirstName;
            lblLastName.Text = DetailContact.Data.LastName;
            lblCompany.Text = DetailContact.Data.Company;
            lblPhoneNumber.Text = DetailContact.Data.PhoneNumber;
            lblDescription.Text = DetailContact.Data.Description;
            lblCreateAt.Text = DetailContact.Data.CreateAt.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
