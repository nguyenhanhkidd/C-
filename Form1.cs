using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm
{
    public partial class frmMain : Form
    {
        List<User> listUsers;
        public frmMain()
        {
            InitializeComponent();
            listUsers = new List<User>();
        }

        
        public bool Check()
        {
            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                MessageBox.Show("You have not entered a user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("You have not entered a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbType.Text))
            {
                MessageBox.Show("You have not entered type of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbLast.Text))
            {
                MessageBox.Show("You have not entered Last month’s water meter readings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbLast.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbThis.Text))
            {
                MessageBox.Show("You have not entered This month’s water meter readings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbThis.Focus();
                return false;
            }
                     
            return true;
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int id;
                string name;
                string userType;
                double lastMonthWaterMeter;
                double thisMonthWaterMater;
                double consumption;
                double total = 0;
                id = Int32.Parse(txbID.Text);
                name = txbName.Text;
                userType = txbType.Text;
                lastMonthWaterMeter = double.Parse(txbLast.Text);
                thisMonthWaterMater = double.Parse(txbThis.Text);
                consumption = thisMonthWaterMater - lastMonthWaterMeter;
                if(userType == "Household customer")
                {
                    if (consumption <= 10)
                    {
                        total = consumption*5.973;
                    }
                    else if(consumption > 10 && consumption <= 20)
                    {
                        total = consumption * 7.052;
                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        total = consumption * 8.699;
                    }
                    else
                    {
                        total = consumption * 15.929;
                    }

                }
                else if(userType == "Administrative agency" || userType == "Public services")
                {
                    total = consumption * 9.955;
                }
                else if (userType == "Production units")
                {
                    total = consumption * 11.615;
                }
                else if (userType == "Business services")
                {
                    total = consumption * 22.068;
                }
                else
                {
                    MessageBox.Show("You have not entered type of user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                User user = new User(id, name, userType, lastMonthWaterMeter, thisMonthWaterMater, total);

                listUsers.Add(user);
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = listUsers;
                dtgWaterBill.Refresh();
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txbSearch.Text;
            if (!string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = listUsers;
                List<User> tmp = new List<User>();
                for(int i = 0; i <dtgWaterBill.Rows.Count; i++)
                {
                    if (dtgWaterBill.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                        tmp.Add(listUsers[i]);
                    
                }
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = tmp;
            }
            else
            {
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = listUsers;
            }
        }

        

        int index;
        private void dtgWaterBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txbID.Text = listUsers[index].ID.ToString();
                txbName.Text = listUsers[index].Name;
                txbType.Text = listUsers[index].UserType;
                txbLast.Text = listUsers[index].LastMonthWaterMeter.ToString();
                txbThis.Text = listUsers[index].ThisMonthWaterMeter.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                listUsers[index].ID = Int32.Parse(txbID.Text);
                listUsers[index].Name = txbName.Text;
                listUsers[index].UserType = txbType.Text;
                listUsers[index].LastMonthWaterMeter = double.Parse(txbLast.Text);
                listUsers[index].ThisMonthWaterMeter = double.Parse(txbThis.Text);
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = listUsers;
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listUsers.RemoveAt(index);
                dtgWaterBill.DataSource = null;
                dtgWaterBill.DataSource = listUsers;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listUsers.Sort((a, b) => a.Name.CompareTo(b.Name));
            dtgWaterBill.DataSource = null;
            dtgWaterBill.DataSource = listUsers;
        }

        private void lbLastMonth_Click(object sender, EventArgs e)
        {

        }

        private void dtgWaterBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
