using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App
{
    public partial class MainForm : Form
    {
        private string name;
        public MainForm()
        {
            InitializeComponent();
            passBookToolStripMenuItem.Enabled = false;
            transactionToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
            LoginForm loginForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is LoginForm)
                {
                    // found it
                    loginForm = (LoginForm)f;
                    break;
                }
            }

            if (loginForm != null)
            {
                loginForm.Show();
                loginForm.Location = new Point(0, 0);
                loginForm.Focus();
                
            }
            else
            {
                loginForm = new LoginForm(this);
                loginForm.MdiParent = this;
                
                loginForm.Show();
                loginForm.Location = new Point(0, 0);
                
                loginForm.Focus();
            }



            

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register registerForm = null;
            CloseForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f is Register)
                {
                    // found it
                    registerForm = (Register)f;
                    break;
                }
            }

            if (registerForm != null)
            {
                registerForm.Show();
                registerForm.Location = new Point(0, 0);
                registerForm.Focus();
            }
            else
            {
                registerForm = new Register(this);
                registerForm.MdiParent = this;
                registerForm.Show();
                registerForm.Location = new Point(0, 0);
                registerForm.Focus();
            }
        }

        private void passBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passbook passbookForm = null;
            CloseForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f is Passbook)
                {
                    // found it
                    passbookForm = (Passbook)f;
                    break;
                }
            }

            if (passbookForm != null)
            {
                passbookForm.Show();
                passbookForm.Location = new Point(0, 0);
                passbookForm.Focus();
            }
            else
            {
                passbookForm = new Passbook(this);
                passbookForm.MdiParent = this;
                passbookForm.Show();
                passbookForm.Location = new Point(0, 0);
                passbookForm.Focus();
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction transactionForm = null;
            CloseForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f is Transaction)
                {
                    // found it
                    transactionForm = (Transaction)f;
                    break;
                }
            }

            if (transactionForm != null)
            {
                transactionForm.Show();
                transactionForm.Location = new Point(0, 0);
                transactionForm.Focus();
            }
            else
            {
                transactionForm = new Transaction(this);
                transactionForm.MdiParent = this;
                transactionForm.Show();
                transactionForm.Location = new Point(0, 0);
                transactionForm.Focus();
            }
        }
        public void EnableButton(bool type)
        {
            transactionToolStripMenuItem.Enabled = type;
            passBookToolStripMenuItem.Enabled = type;
            logoutToolStripMenuItem.Enabled = type;
        }

        public void LoginRegisterButton(bool type)
        {
            loginToolStripMenuItem.Enabled = type;
            registerToolStripMenuItem.Enabled = type;
        }

        public string UserName
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginRegisterButton(true);
            UserName = null;
            EnableButton(false);
            CloseForm();
        }

        public void CloseForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
    }
}
