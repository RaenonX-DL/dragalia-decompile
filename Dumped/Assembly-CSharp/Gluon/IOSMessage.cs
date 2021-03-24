/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class IOSMessage
	{
		// Fields
		public string title;
		public string message;
		public string ok;
	
		// Constructors
		public IOSMessage();
	
		// Methods
		public static IOSMessage Create(string title, string message, Action okAction);
		public static IOSMessage Create(string title, string message, string ok, Action okAction);
		public void init(Action okAction);
	}
}
