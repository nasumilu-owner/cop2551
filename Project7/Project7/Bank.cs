using System;

namespace Project7
{
    /// <summary>
    /// Very simple class to hold the players banking information.
    /// </summary>
    public class Bank
    {

        /// <summary>
        /// Bank balance
        /// </summary>
        private decimal balance;

        /// <summary>
        /// The number of numWithdrawals commited to the bank
        /// </summary>
        private int numWithdrawals;

        /// <summary>
        /// The number of numDeposits commited to the bank
        /// </summary>
        private int numDeposits;

        /// <summary>
        /// Event for when the Bank's balance changes.
        /// </summary>
        public event EventHandler<BalanceChangedEventArgs> BankBalanceChanged;

        /// <summary>
        /// Constructs a bank with zero credits
        /// </summary>
        public Bank() : this(0) { }

        /// <summary>
        /// Constructs a bank with an opening balance.
        /// </summary>
        /// <param name="balance"></param>
        public Bank(decimal balance)
        {
            this.balance = balance;
            this.numWithdrawals = 0;
            this.numDeposits = 0;
        }

        public int WithdrawlCount
        {
            get => this.numWithdrawals;
        }

        public int DepositCount
        {
            get => this.numDeposits;
        }

        /// <summary>
        /// The Bank's balance
        /// </summary>
        public decimal Balance
        {
            get => this.balance;
            set => this.balance = value;
        }

        /// <summary>
        /// Withdraw credits from the bank.
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
            this.numWithdrawals++;
            this.BankBalanceChanged?.Invoke(this, BalanceChangedEventArgs.CreateWithdrawEventArgs(amount));
        }

        /// <summary>
        /// Deposit credits to the bank
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            this.balance += amount;
            this.numDeposits++;
            this.BankBalanceChanged?.Invoke(this, BalanceChangedEventArgs.CreateDepositEventArgs(amount));
        }
    }
}
