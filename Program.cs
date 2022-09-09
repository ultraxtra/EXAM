using System;
using static System.Console;
using System.Linq;
using static System.Math;
using System.IO;
using System.Xml;


namespace Configurator
{
	public class Program
	{
		static void Configurate()
		{
			try
			{
				Running running = new Running();
				running.Run();
			}
			catch(Exception ex)
			{
				WriteLine(ex.Message.ToString());
			}
		}

		static void Main(string[] args)
		{
			Configurate();
		}
	}
}

