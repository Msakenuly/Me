using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        List<BankAccount> accounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = accountNameTextBox.Text;
            decimal balance = decimal.Parse(initialBalanceTextBox.Text);
            decimal interestRate = decimal.Parse(interestRateTextBox.Text); 
            TimeSpan paymentPeriod = TimeSpan.FromSeconds(double.Parse(paymentPeriodTextBox.Text)); 
            BankAccount account = new BankAccount(name, balance, interestRate, paymentPeriod);
            accounts.Add(account);
            UpdateAccountsListBox();
        }

        private void UpdateAccountsListBox()
        {
            accountsListBox.Items.Clear();
            comboBox1.Items.Clear();
            foreach (BankAccount account in accounts)
            {
                accountsListBox.Items.Add(account.Name + " - " + account.Balance.ToString("0.##") + " KZT");
                comboBox1.Items.Add(account.Name + " - " + account.Balance.ToString("0.##") + " KZT");
                List<Transaction> transactions = account.GetTransactions();
                foreach (Transaction transaction in transactions)
                {
                    historyListBox.Items.Add(account.Name + " " + transaction.ToString());
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (accountsListBox.SelectedIndex != -1)
            {
                BankAccount account = accounts[accountsListBox.SelectedIndex];
                accounts.Remove(account);
                UpdateAccountsListBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accountsListBox.SelectedIndex != -1)
            {
                BankAccount account = accounts[accountsListBox.SelectedIndex];
                decimal amount = decimal.Parse(amountTextBox.Text);
                account.Deposit(amount);
                UpdateAccountsListBox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (accountsListBox.SelectedIndex != -1)
            {
                BankAccount account = accounts[accountsListBox.SelectedIndex];
                decimal amount = decimal.Parse(amountTextBox.Text);
                try
                {
                    account.Withdraw(amount);
                    UpdateAccountsListBox();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sourceAccountIndex = accountsListBox.SelectedIndex;
            int destinationAccountIndex = comboBox1.SelectedIndex;
            decimal transferAmount = decimal.Parse(amountTextBox.Text);

            if (sourceAccountIndex == -1 || destinationAccountIndex == -1)
            {
                MessageBox.Show("Please select both source and destination accounts.");
                return;
            }

            if (sourceAccountIndex == destinationAccountIndex)
            {
                MessageBox.Show("Source and destination accounts cannot be the same.");
                return;
            }

            BankAccount sourceAccount = accounts[sourceAccountIndex];
            BankAccount destinationAccount = accounts[destinationAccountIndex];

            try
            {
                sourceAccount.TransferTo(destinationAccount, transferAmount);
                UpdateAccountsListBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.SelectedIndex=0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
            
    }

        private void button7_Click(object sender, EventArgs e)
        {
            
                if (accountsListBox.SelectedIndex != -1)
                {
                    BankAccount account = accounts[accountsListBox.SelectedIndex];
                    decimal newInterestRate;
                    if (decimal.TryParse(interestRateTextBox.Text, out newInterestRate))
                    {
                        account.InterestRate = newInterestRate;
                        UpdateAccountsListBox();
                    }
                    else
                    {
                        MessageBox.Show("Invalid interest rate.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account.");
                }
            

        }
        public List<Transaction> Transactions { get; private set; }
        private void button8_Click(object sender, EventArgs e)
        { 
            string name=accountNameTextBox.Text;
            if (accountsListBox.SelectedIndex != -1)
            {
                BankAccount account = accounts[accountsListBox.SelectedIndex];
                Form inputBox = new Form();
                inputBox.Text = "Change Account Name";
                Label label = new Label();
                label.Text = "Enter the new account name:";
                TextBox textBox = new TextBox();
                textBox.Text = account.Name;
                Button okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                Button cancelButton = new Button();
                cancelButton.Text = "Cancel";
                cancelButton.DialogResult = DialogResult.Cancel;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Dock = DockStyle.Fill;
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                panel.Controls.Add(okButton);
                panel.Controls.Add(cancelButton);
                inputBox.Controls.Add(panel);
               
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    string newAccountName = textBox.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(newAccountName))
                    {
                        account.Name = newAccountName;
                        UpdateAccountsListBox();
                   
                    }
                 
                }
               
   
            }
            else
            {
                MessageBox.Show("Please select an account.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainWin main =new mainWin();
            this.Hide();
            main.Show();
        }

       
    }

    public class BankAccount
    {
        public string Name { get;  set; }
        public decimal Balance { get; private set; }
        public decimal InterestRate { get;  set; } 
        public TimeSpan PaymentPeriod { get; private set; } 
        public List<Transaction> Transactions { get; private set; }

        public BankAccount(string name, decimal balance = 0, decimal interestRate = 0, TimeSpan paymentPeriod = default)
        {
            Name = name;
            Balance = balance;
            InterestRate = interestRate;
            PaymentPeriod = paymentPeriod;
            Transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction(DateTime.Now, "Deposit", amount));

            if (InterestRate > 0 && PaymentPeriod != default)
            {
                decimal interestPayment = Balance * (InterestRate / 100) * ((decimal)PaymentPeriod.TotalSeconds);
                Balance += interestPayment;
                Transactions.Add(new Transaction(DateTime.Now, "Interest Payment", interestPayment));
            }
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new ArgumentException("Insufficient funds.");
            }
            Balance -= amount;
            Transactions.Add(new Transaction(DateTime.Now, "Withdrawal", amount));
        }

        public void TransferTo(BankAccount destinationAccount, decimal amount)
        {
            if (destinationAccount == null)
            {
                throw new ArgumentNullException(nameof(destinationAccount));
            }
            if (this == destinationAccount)
            {
                throw new ArgumentException("Source and destination accounts cannot be the same.");
            }
            if (Balance < amount)
            {
                throw new ArgumentException("Insufficient funds.");
            }
            Withdraw(amount);
            destinationAccount.Deposit(amount);
            Transactions.Add(new Transaction(DateTime.Now, "Transfer", amount, destinationAccount.Name));
        }
    
        public List<Transaction> GetTransactions()
        {
            return Transactions;
        }
    }

    public class Transaction
    {
        public DateTime Date { get; private set; }
        public string Type { get; private set; }
        public decimal Amount { get; private set; }
        public string Destination { get; private set; }

        public Transaction(DateTime date, string type, decimal amount, string destination = null)
        {
            Date = date;
            Type = type;
            Amount = amount;
            Destination = destination;
        }

        public override string ToString()
        {
            string result = Date.ToString("yyyy-MM-dd HH:mm:ss") + " " + Type + " " + Amount.ToString("0.##") + " KZT";
            if (Destination != null)
            {
                result += " to " + Destination;
            }
            return result;
        }
    }

}
