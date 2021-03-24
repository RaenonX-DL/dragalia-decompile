/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class DoubleBuffered<T>
		where T : new()
	{
		// Fields
		private readonly T a;
		private readonly T b;
		private bool usingA;
	
		// Constructors
		public DoubleBuffered();
	
		// Methods
		public T GetCurrent();
		public T GetNext();
	}
}
