// Nicci Kellogg
// IT112
// NOTES: 
// BEHAVIORS NOT IMPLIMENTED AND WHY:

using System.Runtime.CompilerServices;

namespace MultiUserBank_Kellogg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string transaction = "";
			decimal money;
			string[] user = { "jlennon", "pmccartney", "gharrison", "rstarr" };
			string[] pass = { "johnny", "pauly", "georgy", "ringoy" };
			decimal[] balance = { 1250, 2500, 3000, 1000 };
			string User = string.Empty;
			string Pass = string.Empty;	
			string Input = string.Empty;


			Bank account = new Bank();

			do
			{
				Console.WriteLine("The current balance of the bank is: " + account.BankBalance.ToString("c"));
				Console.WriteLine("Please enter your username: ");
				User = Console.ReadLine();
				Console.WriteLine("Please enter your password: ");
				Pass = Console.ReadLine();

				for (int i = 0; i < user.Length - 1; i++)
				{
					account.Current = balance[i];
					if (user[i] == User && pass[i] == Pass)
					{
						Console.WriteLine("Welcome " + user[i] + "!");
						if (balance[i] > 0M)
						{ 
							bool loggedIn = true;
							do
							{
								Console.WriteLine("Press 1 to check your balance \nPress 2 to Deposit \nPress 3 to Withdrawal \nPress 4 to Log out");
								Input = Console.ReadLine();
								if (Input == "1")
								{
									Console.WriteLine("Your balance is " + balance[i] + ".");
								}
								if (Input == "2")
								{
									Console.WriteLine("How much money would you like to deposit?");
									money = decimal.Parse(Console.ReadLine());
									balance[i] = account.Deposit(money);
									Console.WriteLine("Your new balance is " + account.Current.ToString("c") + ".");
								}
								if (Input == "3")
								{
									Console.WriteLine("How much money would you like to withdraw?");
									money = decimal.Parse(Console.ReadLine());
									balance[i] = account.Withdraw(money);
									Console.WriteLine("Your new balance is " + account.Current.ToString("c") + ".");
								}
								if (Input == "4")
								{
									loggedIn = false;
								}


							} while (loggedIn);


						}
					}
					else
						transaction = "Done";
				}

				


			} while (transaction == "Done");

		}
	}
}