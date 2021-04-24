using System;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
			float fov;
			float flegnth;
			float filmBackWidth = float.Parse(Console.ReadLine());
			while (!(filmBackWidth > 0))
			{
				Console.WriteLine("Invalid filmBackWidth Please input again.\n");
				filmBackWidth = float.Parse(Console.ReadLine());
			}

;
			Console.WriteLine("Select mode\n0 : flegnth\n1 : fov");
			int mode = Convert.ToInt32(Console.ReadLine());
			if (Convert.ToBoolean(mode))
			{
				fov = float.Parse(Console.ReadLine());
				while (!(fov > 0.1) && !(fov < 6.28))
				{
					Console.WriteLine("Invalid fov Please input again.\n");
					fov = float.Parse(Console.ReadLine());
				}

				flegnth = filmBackWidth / (2 * Convert.ToSingle(Math.Tan(fov / 2)));
				Console.WriteLine("flegnth = " + flegnth.ToString() + " fov = " + fov.ToString());
			}
			else
			{
				flegnth = float.Parse(Console.ReadLine());
				while (!(flegnth > 0))
				{
					Console.WriteLine("Invalid flegnth Please input again.\n");
					flegnth = float.Parse(Console.ReadLine());
				}

				fov = Convert.ToSingle(2 * Math.Atan(filmBackWidth / (2 * flegnth)));
				Console.WriteLine("flegnth = " + flegnth.ToString() + " fov = " + fov.ToString());
			}
		}
    }
}
