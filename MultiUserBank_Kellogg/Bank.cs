using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserBank_Kellogg
{
	internal class Bank
	{
		private decimal _balance = 10000M;
		private decimal _current;

		public decimal Deposit(decimal amount)
		{
			 _balance += amount;
			return _current += amount;
		}

		public decimal Withdraw(decimal amount)
		{
		   _balance -= amount;
			return _current -= amount;		
		}

		public decimal Current
		{
			get 
			{
				if (_current <= 0M)
				{
					_current = 0M;
				}
				return _current; 
			}	
			set
			{
				_current = value;	
			}
		}
		public decimal BankBalance
		{
			get 
			{ 
				if (_balance <= 0M)
				{
					_balance = 0M;
				}

				return _balance; 
			} 
		}
	}
}
