/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Http
{
	public class SecureHttpsRequest : IWebRequest
	{
		// Fields
		[CompilerGenerated]
		private bool _isDone_k__BackingField;
		[CompilerGenerated]
		private string _error_k__BackingField;
		private byte[] result;
	
		// Properties
		public byte[] bytes { get; }
		public bool isDone { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string error { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<string, string> responseHeaders { get; }
	
		// Constructors
		public SecureHttpsRequest();
	
		// Methods
		public void Dispose();
		public void Post(string url, byte[] postData, Dictionary<string, string> headers);
		[CompilerGenerated]
		private void _Post_b__14_0(byte[] response);
		[CompilerGenerated]
		private void _Post_b__14_1(string error);
	}
}
