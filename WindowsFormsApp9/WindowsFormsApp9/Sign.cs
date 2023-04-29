using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите имя пользователя и пароль");
                return;
            }

            var database = new UserDatabase();
            if (database.GetUser(username) != null)
            {
                MessageBox.Show("Пользователь с таким именем уже зарегистрирован");
                return;
            }

            var user = new User { Username = username, Password = password };
            database.AddUser(user);
            MessageBox.Show("Пользователь зарегистрирован");
            reg r=new reg();
            this.Hide();
            r.ShowDialog();
            
        }
    }
}
