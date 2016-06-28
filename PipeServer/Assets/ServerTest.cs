using System;
using System.IO;
using System.IO.Pipes;

namespace SerSoul
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			using (NamedPipeServerStream serverStream = new NamedPipeServerStream("test"))
			{

				serverStream.WaitForConnection ();

				using (StreamWriter writer = new StreamWriter (serverStream)) {

					writer.AutoFlush = true;

					string temp;

					while((temp = Console.ReadLine()) != "stop"){

						writer.WriteLine (temp);

				}




				}




			}
		}
	}
}
