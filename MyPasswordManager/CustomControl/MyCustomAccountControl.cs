
using MyPasswordManager.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyPasswordManager.CustomControl
{
    public partial class MyCustomAccountControl : UserControl
    {
        public delegate void delegateOfAccountSelected(Account account);
        public event delegateOfAccountSelected accountSelected;

        private List<Account> _currentAccountList;
        //public Control CurrentControl;
        public MyCustomAccountControl()
        {
            InitializeComponent();
        }

        public void SetAccountContent(List<Account> listAccount)
        {
            if (object.Equals(listAccount, null) || listAccount.Count < 1)
            {
                return;
            }
            _currentAccountList = listAccount;
            this.Controls.Clear();
            //先进行分组
            int height = this.SetAccountType(_currentAccountList);
            var groupedCustomerList = _currentAccountList
  .GroupBy(u => u.AccountType)
  .Select(grp => grp.ToList())
  .ToList();
            this.SetContent(height, groupedCustomerList);
        }

        private void SetContent(int cmntypeheight, List<List<Account>> groupedCustomerList)
        {
            Point pnlPreviosPoint = new Point(10, cmntypeheight + 40);
            foreach (List<Account> accountList in groupedCustomerList)
            {
                //添加标题
                Label lbl = new Label();
                lbl.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
                lbl.ForeColor = Color.LightSlateGray;
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.Text = accountList[0].AccountType;
                lbl.AutoSize = true;
                lbl.Location = pnlPreviosPoint;
                this.Controls.Add(lbl);
                pnlPreviosPoint.Y += lbl.Height + 20;
                //
                Point previosPoint = new Point(10, 10);
                Panel pnl = new Panel();
                pnl.BorderStyle = BorderStyle.Fixed3D;
                pnl.AutoSize = true;
                pnl.Location = pnlPreviosPoint;


                foreach (Account account in accountList)
                {
                    Button btn = new Button();
                    btn.Text = account.AccountName + "\n\n" + account.AccountPassword;
                    btn.AutoSize = true;
                    btn.BackColor = Color.DarkRed;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
                    btn.Location = previosPoint;
                    //btn.MouseDoubleClick += Btn_Click;
                    btn.Click += Btn_Click;
                    btn.Tag = account;
                    pnl.Controls.Add(btn);
                    if (previosPoint.X + btn.Width * 2 + 20 > this.Width)
                    {
                        previosPoint.X = 10;
                        previosPoint.Y += btn.Height + 20;
                    }
                    else
                    {
                        previosPoint.X += btn.Width + 20;
                    }
                }
                pnlPreviosPoint.Y += pnl.Height + 50;
                this.Controls.Add(pnl);
            }
        }

        private void CmbType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            this.SetAccountType(_currentAccountList);
            if ((sender as ComboBox).Text.Equals("ALL"))
            {
                var groupedCustomerList = _currentAccountList
                .GroupBy(u => u.AccountType)
                .Select(grp => grp.ToList())
                .ToList();
                this.SetContent((sender as ComboBox).Height, groupedCustomerList);
            }
            else
            {
                string type = (sender as ComboBox).Text;
                List<Account> filterList = _currentAccountList.Where(p => p.AccountType.Equals(type)).ToList();
                var groupedCustomerList = filterList
                .GroupBy(u => u.AccountType)
                .Select(grp => grp.ToList())
                .ToList();
                this.SetContent((sender as ComboBox).Height, groupedCustomerList) ;
            }
        }

        private int SetAccountType(List<Account> list)
        {
            var groupedCustomerList = list
   .GroupBy(u => u.AccountType)
   .Select(grp => grp.ToList())
   .ToList();
            ComboBox cmbType = new ComboBox();
            cmbType.DataSource = this.GetAccountType(groupedCustomerList);
            cmbType.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            cmbType.ForeColor = Color.White;
            cmbType.BackColor = Color.DarkRed;
            cmbType.Location = new Point(10, 10);
            cmbType.SelectedIndexChanged += CmbType_SelectedIndexChanged;
            cmbType.Text = string.Empty;
            this.Controls.Add(cmbType);
            return cmbType.Height;
        }

        private List<string> GetAccountType(List<List<Account>> group)
        {
            List<string> listType = new List<string>();
            foreach(List<Account> list in group)
            {
                listType.Add(list[0].AccountType);
            }
            listType.Add("ALL");
            return listType;
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            accountSelected.Invoke((sender as Button).Tag as Account);
        }
    }
}
