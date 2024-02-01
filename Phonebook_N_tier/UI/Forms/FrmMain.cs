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
    public partial class FrmMain : Form
    {
        private readonly GetContactListService _getContactListService;
        private readonly SearchContactService _searchContactService;
        private readonly DeleteContactService _deleteContactService;
        public FrmMain()
        {
            InitializeComponent();
            _getContactListService = new GetContactListService();
            _searchContactService = new SearchContactService();
            _deleteContactService = new DeleteContactService();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var listContact = _getContactListService.GetContactList();


            SettingGridView(listContact);
            this.Cursor = Cursors.Default;
        }

        private void SettingGridView(List<ContactDto> listContact)
        {
            dataGridView1.DataSource = listContact;
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "موبایل";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            var listContacts = _searchContactService.SearchContact(txtSearch.Text);
            if (listContacts != null)
            {
                SettingGridView(listContacts);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = _deleteContactService.DeleteContact(Id);
            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            FrmDetailContact frmDetailContact = new FrmDetailContact(Id);
            frmDetailContact.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddContact frmAddContact = new FrmAddContact();
            frmAddContact.ShowDialog();
            FrmMain_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmEdit frmEdit = new frmEdit(Id);
            frmEdit.ShowDialog();
            FrmMain_Load(null, null);
        }
    }
}
