/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class MethodWrap
	{
		// Fields
		private string methodName;
		private List<OverloadMethodWrap> overloads;
		private bool forceCheck;
	
		// Constructors
		public MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck);
	
		// Methods
		public int Call(IntPtr L);
	}
}
