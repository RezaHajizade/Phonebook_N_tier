using BLL.Dto;
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
    public partial class frmEdit : Form
    {
        private readonly EditContactService _editContactService;
        private readonly GetContactDetailService _getContactDetailService;
        private readonly int ContactId;
        public frmEdit(int contactId)
        {
            InitializeComponent();
            _editContactService=new EditContactService();
            _getContactDetailService=new GetContactDetailService();
            ContactId = contactId;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var result = _editContactService.EditContact(new EditContactDto
            {
                Id=ContactId,
                Company = txtCompany.Text,
                Description = txtDescription.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            var contact = _getContactDetailService.GetContactDetail(ContactId);
            if (contact == null)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtFirstName.Text = contact.Data.FirstName;
                txtLastName.Text = contact.Data.LastName;
                txtCompany.Text = contact.Data.Company;
                txtDescription.Text = contact.Data.Description;
                txtPhoneNumber.Text = contact.Data.PhoneNumber;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
