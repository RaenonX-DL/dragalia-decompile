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
	public interface IWebRequest : IDisposable
	{
		// Properties
		byte[] bytes { get; }
		bool isDone { get; }
		string error { get; }
		Dictionary<string, string> responseHeaders { get; }
	
		// Methods
		void Post(string url, byte[] postData, Dictionary<string, string> headers);
	}
}
