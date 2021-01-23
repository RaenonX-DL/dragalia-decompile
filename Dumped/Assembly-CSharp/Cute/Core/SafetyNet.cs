/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class SafetyNet
	{
		// Fields
		private const int TIMEOUT_SECONDS = 120;
	
		// Constructors
		public SafetyNet();
	
		// Methods
		public static void GetSafetyNetSatus(string apiKey, string nonce, Action<string> onSuccess, Action<string> onError);
	}
}
