/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleState
	{
		// Fields
		public SimpleStateDelegateBegin eventBegin;
		public SimpleStateDelegateEnd eventEnd;
		public SimpleStateDelegateTick eventTick;
		private string name;
	
		// Nested types
		public delegate void SimpleStateDelegateBegin(SimpleState prev);
	
		public delegate void SimpleStateDelegateEnd(SimpleState next);
	
		public delegate void SimpleStateDelegateTick();
	
		// Constructors
		public SimpleState(string _name);
	
		// Methods
		public string Name();
	}
}
