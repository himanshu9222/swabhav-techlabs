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
        //private LoginForm login;
        public MainForm()
        {
            InitializeComponent();
            passBookToolStripMenuItem.Enabled = false;
            transactionToolStripMenuItem.Enabled = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                loginForm.Focus();
            }
            else
            {
                loginForm = new LoginForm();
                loginForm.MdiParent = this;
                loginForm.Show();
                loginForm.Focus();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register registerForm = null;
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
                registerForm.Focus();
            }
            else
            {
                registerForm = new Register();
                registerForm.MdiParent = this;
                registerForm.Show();
                registerForm.Focus();
            }
        }

        private void passBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passbook passbookForm = null;
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
                passbookForm.Focus();
            }
            else
            {
                passbookForm = new Passbook();
                passbookForm.MdiParent = this;
                passbookForm.Show();
                passbookForm.Focus();
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction transactionForm = null;
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
                transactionForm.Focus();
            }
            else
            {
                transactionForm = new Transaction();
                transactionForm.MdiParent = this;
                transactionForm.Show();
                transactionForm.Focus();
            }
        }
    }
}
