/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Http
{
	public interface IHttpTask
	{
		// Properties
		bool IsEncrypt { get; }
		int CacheTime { get; }
	
		// Methods
		IWebRequest Send(string url);
		bool Deserialize(byte[] body);
		void OnError(ErrorType errorType, int resultCode);
		void SetHeader(string key, string value);
	}
}
