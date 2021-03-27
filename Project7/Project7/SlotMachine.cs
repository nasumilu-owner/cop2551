using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class slotForm : Form
    {
        private readonly Bank bank = new Bank(1000);
        public slotForm()
        {
            InitializeComponent();
            this.bankView.Bank = bank;
            this.bank.BankBalanceChanged += BalanceChanged;
        }

        private void BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            //max bet is 1000 or bank balance if < 1000
            if (this.bank.Balance < this.betField.Maximum)
            {
                this.betField.Maximum = this.bank.Balance;
            } else
            {
                this.betField.Maximum = 1000;
            }

            if (bank.Balance == 0)
            {
                this.spinButton.Enabled = false;
                this.statusLabel.Text = "Busted";
                MessageBox.Show("You have lost it all, please play again!");
            } else
            {
                this.spinButton.Enabled = true;
            }
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            this.spinButton.Enabled = false;
            this.statusLabel.Text = "Spinning";
            SpinResult result = this.reelSet1.Spin();
            decimal amount = result.CalculateWinnings(this.betField.Value);
            if(result == SpinResult.Lost)
            {
                bank.Withdraw(-amount); // the amount is negative, need to make it positive again.
            } else
            {
                bank.Deposit(amount);
            }
            this.statusLabel.Text = result.DisplayName();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
