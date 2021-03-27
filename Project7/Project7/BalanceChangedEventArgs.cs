using System;

namespace Project7
{

    /// <summary>
    /// EventArg for when the Bank balance changes.
    /// </summary>
    public class BalanceChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The type of bank balance changes
        /// </summary>
        private enum BalanceChangeType
        {
            Deposit,
            Withdrawal
        }

        /// <summary>
        /// The BalanceChangedEvent type
        /// </summary>
        private readonly BalanceChangeType type;
        /// <summary>
        /// The BalacneChangedEvent amount
        /// </summary>
        private readonly decimal amount;

        /// <summary>
        /// Private constructor
        /// Please use the static factory methods: CreateDepositEventArgs and CreateWithdrawEventArgs
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        private BalanceChangedEventArgs(BalanceChangeType type, decimal amount)
        {
            this.type = type;
            this.amount = amount;
        }

        /// <summary>
        /// Static factory method to create a Deposit type BalanceChangedEvent. 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static BalanceChangedEventArgs CreateDepositEventArgs(decimal amount)
        {
            return new BalanceChangedEventArgs(BalanceChangeType.Deposit, amount);
        }

        /// <summary>
        /// Static factory method to create a Withdraw type BlanceChangedEvent.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static BalanceChangedEventArgs CreateWithdrawEventArgs(decimal amount)
        {
            return new BalanceChangedEventArgs(BalanceChangeType.Withdrawal, amount);
        }

        /// <summary>
        /// Indicates the amount the balances has changes.
        /// </summary>
        public decimal Amount
        {
            get => amount;
        }

        /// <summary>
        /// Indicates whether the type of balance change was a deposit.
        /// </summary>
        public bool IsDeposit
        {
            get => this.type == BalanceChangeType.Deposit;
        }
       
        /// <summary>
        /// Indicates whether the type of blanace change was withdraw
        /// </summary>
        public bool IsWithdrawal
        {
            get => this.type == BalanceChangeType.Withdrawal;
        }
    }
}
