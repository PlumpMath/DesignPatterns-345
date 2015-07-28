using System;
using System.Configuration;
using System.Reflection;

namespace DesignPatterns.Builder.KFC
{
	/// <summary>
	/// Client ¿‡
	/// </summary>
	public class Client
	{
		public static void Main(string[] args)
		{
			FoodManager foodmanager = new FoodManager();

			Builder instance;

			Console.WriteLine("Please Enter Food No:");

			string No = Console.ReadLine();

            string foodType = System.Configuration.ConfigurationManager.AppSettings["No" + No]; //ConfigurationSettings.AppSettings["No" + No];

            instance = (Builder)Assembly.Load("Builder.KFC").CreateInstance("DesignPatterns.Builder.KFC." + foodType);

			foodmanager.Construct(instance);

			Food food = instance.GetFood();
			food.Show();

			Console.ReadLine();
		}
	}
}
