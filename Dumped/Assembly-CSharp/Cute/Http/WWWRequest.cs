/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Http
{
	public class WWWRequest : IWebRequest
	{
		// Fields
		private UnityWebRequest request;
	
		// Properties
		public byte[] bytes { get; }
		public bool isDone { get; }
		public string error { get; }
		public Dictionary<string, string> responseHeaders { get; }
	
		// Constructors
		public WWWRequest();
	
		// Methods
		public void Dispose();
		public void Post(string url, byte[] postData, Dictionary<string, string> headers);
	}
}
