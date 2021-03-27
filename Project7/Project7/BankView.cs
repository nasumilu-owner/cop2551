using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Project7
{

 
    public partial class BankView : UserControl
    {
        private Bank bank;
        public BankView()
        {
            InitializeComponent();
        }

        public Bank Bank
        {
            get {
                if(null == this.bank)
                {
                    this.bank = new Bank();
                    this.bank.BankBalanceChanged += this.BankBalance_Changes;
                }
                return this.bank;
            }
            set
            {
                if(null != this.bank)
                {
                    this.bank.BankBalanceChanged -= this.BankBalance_Changes;
                }
                this.bank = value;
                this.UpdateStats(true, 0); // This will trigger an update to show inital stats from the bank
                this.bank.BankBalanceChanged += this.BankBalance_Changes;
            }
        }

        private void UpdateStats(bool deposit, decimal amount)
        {
            this.balanceField.Text = this.bank.Balance.ToString("C2");
            if (deposit)
            {
                this.winningsField.Text = $"{(Decimal.Parse(this.winningsField.Text, NumberStyles.Currency) + amount):C2}";
                this.numWinsField.Text = this.bank.DepositCount.ToString();
            }
            else
            {
                this.losesField.Text = $"{(Decimal.Parse(this.losesField.Text, NumberStyles.Currency) + amount):C2}";
                this.numLosesField.Text = this.bank.WithdrawlCount.ToString();
            }
        }

        private void BankBalance_Changes(Object sender, BalanceChangedEventArgs e)
        {
            this.UpdateStats(e.IsDeposit, e.Amount);
        }
    }
}
