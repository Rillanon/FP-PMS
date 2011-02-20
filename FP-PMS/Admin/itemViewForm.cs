using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using FP_PMS.Db;

namespace FP_PMS.Admin
{
    public partial class itemViewForm : FP_PMS.Templates.level2TemplateForm
    {
        tblItem _myItem = new tblItem();
        tblItemType _myItemType;
        public tblItem myItem { get { return _myItem; } set { _myItem = value; } }

        bool IsNullOrDefault<T>(T value)
        {
            return object.Equals(value, default(T));
        }

        private bool validation()
        {
            if (IsNullOrDefault(itemNoTextEdit.Text) == false)
                return true;
            if (IsNullOrDefault(itemDescTextEdit.Text) == false)
                return true;
            if (IsNullOrDefault(_myItemType) == false)
                return true;

            return false;
        }

        private void saveToDb()
        {
            var newConnection = new dbContextDataContext();
            var currentItem = newConnection.tblItems.Where(od => od.UniqueID == _myItem.UniqueID).SingleOrDefault();

            if (currentItem == null)
            {
                if (validation() == false)
                {
                    myItem.ItemType = _myItemType.ItemType;
                    myItem.ItemNo = itemNoTextEdit.Text;
                    myItem.ItemDesc = itemDescTextEdit.Text;
                    newConnection.tblItems.InsertOnSubmit(myItem);
                }
                else
                {
                    MessageBox.Show("Please complete all fields.");
                }

            }
            else
            {
                currentItem = newConnection.tblItems.Where(od => od.UniqueID == _myItem.UniqueID).Single();
                currentItem.ItemDesc = itemDescTextEdit.Text;
                currentItem.ItemNo = itemNoTextEdit.Text;
                currentItem.ItemType = _myItemType.ItemType;
            }
            newConnection.SubmitChanges();
        }

        public void updateForm()
        {
            itemNoTextEdit.Text = myItem.ItemNo;
            itemDescTextEdit.Text = myItem.ItemDesc;
            itemTypeLookUp.EditValue = myItem.ItemType;
        }

        public itemViewForm()
        {
            InitializeComponent();
        }

        private void itemViewForm_Load(object sender, EventArgs e)
        {
            var newConnection = new dbContextDataContext();
            itemLookUp.Properties.DataSource = newConnection.tblItems;
            itemLookUp.Properties.DisplayMember = "ItemDesc";
            itemLookUp.Properties.ValueMember = "UniqueID";
            itemTypeLookUp.Properties.DataSource = newConnection.tblItemTypes;
            itemTypeLookUp.Properties.DisplayMember = "ItemTypeDesc";
            itemTypeLookUp.Properties.ValueMember = "ItemType";
        }

        private void itemLookUp_EditValueChanged(object sender, EventArgs e)
        {
            myItem = (tblItem)itemLookUpView.GetFocusedRow();
            updateForm();
        }

        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);
            saveToDb();
        }

        private void itemTypeLookUp_EditValueChanged(object sender, EventArgs e)
        {
            _myItemType = (tblItemType)itemTypeLookUp.GetSelectedDataRow();
        }
    }
}
