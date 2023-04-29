using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class TicketForm : Form
    {
        private const string ticketsFilePath = "Tickets.txt";
        public TicketForm()
        {
            InitializeComponent();
            comboBoxTicketPrice.Items.Add("Алматы");
            comboBoxTicketPrice.Items.Add("Астана");
            comboBoxTicketPrice.Items.Add("Шымкент");
            comboBoxTicketPrice.Items.Add("Атырау");
            comboBoxTicketPrice.Items.Add("Семей");
            comboBoxTicketPrice.Items.Add("Тараз");
            comboBoxTicketPrice.Items.Add("Караганды");
            comboBoxTicketPrice.Items.Add("Актобе");
            comboBoxTicketPrice.Items.Add("Туркестан");
            comboBoxTicketPrice.Items.Add("Уральск");
            comboBoxTicketPrice.Items.Add("Усть-Каменогорск");
            comboBoxTicketPrice.Items.Add("Актау");

            comboBox1.Items.Add("Алматы");
            comboBox1.Items.Add("Астана");
            comboBox1.Items.Add("Шымкент");
            comboBox1.Items.Add("Атырау");
            comboBox1.Items.Add("Семей");
            comboBox1.Items.Add("Тараз");
            comboBox1.Items.Add("Караганды");
            comboBox1.Items.Add("Актобе");
            comboBox1.Items.Add("Туркестан");
            comboBox1.Items.Add("Уральск");
            comboBox1.Items.Add("Усть-Каменогорск");
            comboBox1.Items.Add("Актау");

            comboBox2.Items.Add("Авиабилет");
            comboBox2.Items.Add("ЖД билет");
            comboBox2.Items.Add("Автобусный билет");
        }

        private string GenerateTicketCode()
        {
            string ticketCode = "";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                ticketCode += chars[random.Next(chars.Length)];
            }

            return ticketCode;
        }
        private void GenerateTicketPrices()
        {
            for (int price = 500; price <= 5000; price += 500)
            {
                comboBoxTicketPrice.Items.Add(price.ToString("N0") + " KZT");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateTicketPrices();
            dateTimePickerEventDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEventDate.CustomFormat = "dd.MM.yyyy";
        }
        private void butticket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Заполните поля имя и фамилия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxTicketPrice.SelectedIndex == -1  || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите начальный и конечный город.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxTicketPrice.SelectedIndex == comboBox1.SelectedIndex)
            {
                MessageBox.Show("Вы не можете выбрать один город.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип билета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ticketCode = GenerateTicketCode();
            using (StreamWriter writer = new StreamWriter(ticketsFilePath, true))
            {
                writer.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", textBoxFirstName.Text, textBoxLastName.Text, dateTimePickerEventDate.Value.ToString("yyyy-MM-dd"), comboBoxTicketPrice.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), ticketCode));
            }

            MessageBox.Show(string.Format("Билет успешно куплен.\nКод билета: {0}", ticketCode), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerEventDate.Value = DateTime.Today;
            comboBoxTicketPrice.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void findticket_Click(object sender, EventArgs e)
        {
            string ticketCode = textBoxTicketCode.Text;
            if (string.IsNullOrEmpty(ticketCode))
            {
                MessageBox.Show("Введите номер билета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ticketExists = false;
            string ticketInfo = "";

            using (StreamReader reader = new StreamReader(ticketsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length == 7 && fields[6] == ticketCode)
                    {
                        ticketExists = true;
                        ticketInfo = string.Format("Имя: {0}\nФамилия: {1}\nДата: {2}\nОт: {3}\nДо: {4}\nТип билета: {5}\nКод билета: {6}", fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6]);
                        break;
                    }
                }
            }

            if (ticketExists)
            {
                MessageBox.Show(string.Format("Билет найден:\n{0}", ticketInfo), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Билет с указанным номером не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxTicketCode.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainWin main = new mainWin();
            this.Hide();
            main.Show();
        }
    }
}
