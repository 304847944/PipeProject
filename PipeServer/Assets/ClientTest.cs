using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.IO.Pipes;


public class test{




	public NamedPipeClientStream clientStream;

	public string temp;

	//构造函数（初始化）

	public  test(){


		 clientStream = new NamedPipeClientStream ("test");

		clientStream.Connect ();




//		StreamReader reader = new StreamReader (clientStream);
//
//		 temp = reader.ReadLine();
//
//		Debug.Log (temp);




	}

	//pubcli NamedPipeClientStream clientStream;

//
//	public void createClient(){
//
//
//		clientStream = new NamedPipeClientStream ("test");
//
//			clientStream.Connect ();
//
////			//在client端读取server端写的数据。
////			using (StreamReader reader = new StreamReader (clientStream)) {
////
////				string temp;
////
////				while((temp = reader.ReadLine()) != "stop"){
////
////					//Console.WriteLine ("{0}:{1}",DateTime.Now,temp);
////
////					Debug.Log (temp);
////
////
////				}
////
////
////			}
//
//
//
//
//
//		}
//
//	
//
//	}



	public	string rea(){


			StreamReader reader = new StreamReader (clientStream);

	temp = reader.ReadLine();

	//Debug.Log (temp);

		return temp;


		}


}


public class ClientTest : MonoBehaviour {


	Text text;

	test Test;


	// Use this for initialization
	void Start () {
	

		text = GameObject.Find ("Canvas/Text").GetComponent<Text> ();

		 Test = new test ();

		//test.createClient ();

	}
	
	// Update is called once per frame
	void Update () {
	

			

		text.text = Test.rea ();



		//test.tt ();

	}





}
