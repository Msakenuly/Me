using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp9
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
            txtPassword.PasswordChar= '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Sign sign= new Sign();
            this.Hide();
            sign.ShowDialog();
           
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
            var user = database.GetUser(username);

            if (user == null || user.Password != password)
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
                return;
            }

            MessageBox.Show("Вход выполнен успешно");
            mainWin main=new mainWin();
            this.Hide();
            main.Show();

        }
    }

public class UserDatabase
    {
        private const string FileName = "users.xml";
        private List<User> users;

        public UserDatabase()
        {
            users = new List<User>();
            if (File.Exists(FileName))
            {
                using (var stream = File.OpenRead(FileName))
                {
                    var serializer = new XmlSerializer(typeof(List<User>));
                    users = serializer.Deserialize(stream) as List<User>;
                }
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
            using (var stream = File.Create(FileName))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(stream, users);
            }
        }

        public User GetUser(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
