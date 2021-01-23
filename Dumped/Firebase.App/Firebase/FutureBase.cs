/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 41: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class FutureBase : IDisposable
	{
		// Fields
		private HandleRef swigCPtr;
		protected bool swigCMemOwn;
	
		// Constructors
		internal FutureBase(IntPtr cPtr, bool cMemoryOwn);
	
		// Methods
		~FutureBase();
		public virtual void Dispose();
		public FutureStatus status();
		public int error();
		public string error_message();
	}
}
