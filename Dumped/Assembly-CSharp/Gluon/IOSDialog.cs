/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class IOSDialog
	{
		// Fields
		public string title;
		public string message;
		public string yes;
		public string no;
	
		// Constructors
		public IOSDialog();
	
		// Methods
		public static IOSDialog Create(string title, string message, Action yesAction, Action noAction);
		public static IOSDialog Create(string title, string message, string yes, string no, Action yesAction, Action noAction);
		private void init(Action yesAction, Action noAction);
	}
}
