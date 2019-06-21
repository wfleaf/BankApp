using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
	/*
	 * Here is the multiline comment
	 * */
	/// <summary>
	/// This is an XML comment. 
	/// A bank account for tracking deposit and withdrawal of $$$
	/// </summary>
	class Account
	{
		#region Properties
		public int AccountNumber { get; set; }
		public string AccountType { get; set; }
		public decimal Balance { get; set; }
		public string EmailAddress { get; set; }
		public DateTime CreatedDate { get; set; }
		#endregion

		#region Methods
		/// <summary>
		/// Deposit money into the account
		/// </summary>
		/// <param name="amt">Amount to be deposited</param>
		/// <returns>New balance</returns>
		public decimal Deposit(decimal amt)
		{
			//Read from right to left Balance = Balance + amt
			Balance += amt;
			return Balance;
		}

		public void Withdraw(decimal amt)
		{
			Balance -= amt;
		}
		#endregion
	}
}
