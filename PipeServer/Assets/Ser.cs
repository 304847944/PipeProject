using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.IO.Pipes;


public class test2
{


//	public static void Main(string[] args){
//
//
//		Debug.Log ("主函数？？？？");
//
//
//	}



	public void createOne(){

		//NamedPipeServerStream serverStream = new NamedPipeServerStream("test");

		//serverStream.WaitForConnection ();


//		using (NamedPipeServerStream serverStream = new NamedPipeServerStream("test"))
//		{
//
//			serverStream.WaitForConnection ();
//
//			using (StreamWriter writer = new StreamWriter (serverStream)) {
//
//				writer.AutoFlush = true;
//
//				string temp;
//
//				while((temp = Console.ReadLine()) != "stop"){
//
//					writer.WriteLine (temp);
//
//				}
//
//
//
//
//			}
//
//
//
//
//		}


		Console.ReadLine ();



		Debug.Log ("sfaadfasdf");


	}






}


public class ServerTest : MonoBehaviour{

	void Start(){

		Debug.Log ("a new class debug.log");

		test2 te = new test2 ();


		te.createOne ();

	}








}


 



//***********************************************************************************

//NamedPipeServerStream pipeServer = new  NamedPipeServerStream("testpipe", PipeDirection.InOut,  PipeTransmissionMode.Message, PipeOptions.Asynchronous); 
//void Form1_Load(object sender, EventArgs e)
//{ 
//	ThreadPool.QueueUserWorkItem(delegate
//
//		{ 
//			pipeServer.BeginWaitForConnection((o) =>; 
//				{ 
//					NamedPipeServerStream server = (NamedPipeServerStream)o.AsyncState;
//					server.EndWaitForConnection(o);
//					StreamReader sr = new StreamReader(server);
//					StreamWriter sw = new StreamWriter(server);
//					string result = null;
//					string clientName = server.GetImpersonationUserName();
//					while (true)
//					{
//						result = sr.ReadLine();
//						if (result == null || result == "bye")
//							break;
//						this.Invoke((MethodInvoker)delegate { lsbMsg.Items.Add(clientName+" : "+result); });
//					}
//				}, pipeServer);
//		});
//}

//*********************************************************************************************