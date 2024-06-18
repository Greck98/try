namespace NactiData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputs = new int[3];
			for (int i = 0; i < 3; i++)
			{
				inputs[i] = GetNumber();
			}
            Console.WriteLine($"součet všech 3 čísel: {GetSum(inputs)}");
            Console.WriteLine($"součin všech 3 čísel: {GetProduct(inputs)}");
            Console.WriteLine($"součet prvních dvou čísel dělený třetím: {GetThis(inputs)}");

			Console.WriteLine("\nPro ukončení programu stiskněte enter");
			Console.ReadKey();
        }

		public static int GetNumber()
		{
			Console.Write("Zadejte číslo: ");
			string value = Console.ReadLine();
			int result = 0;
			try
			{
				result = Convert.ToInt32(value);
			}
			catch (Exception)
			{
				Console.WriteLine("Hodnota musí být číslo");
				result = GetNumber();
			}
			return result;
		}
		public static int GetSum(int[] inputs)
		{
			int result = 0;
			foreach (int i in inputs)
			{
				result += i;
			}
			return result;
		}
		public static int GetProduct(int[] inputs)
		{
			return inputs[0] * inputs[1] *  inputs[2];
		}
		public static decimal GetThis(int[] inputs)
		{			
			return (inputs[0] * inputs[1]) / (decimal)inputs[2];
		}
	}
}
