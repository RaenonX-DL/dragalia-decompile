/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleStateProcessor
	{
		// Fields
		private SimpleState state;
		private SimpleState statePrev;
		private bool bterm;
	
		// Properties
		public SimpleState State { get; }
	
		// Constructors
		public SimpleStateProcessor();
	
		// Methods
		private void Init();
		public void Clear();
		public void Execute();
		public bool SetState(SimpleState st, bool bforce = false);
	}
}
