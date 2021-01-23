/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal sealed class SingleAssignmentDisposable : IDisposable
	{
		// Fields
		private readonly object gate;
		private IDisposable current;
		private bool disposed;
	
		// Properties
		public bool IsDisposed { get; }
		public IDisposable Disposable { get; set; }
	
		// Constructors
		public SingleAssignmentDisposable();
	
		// Methods
		public void Dispose();
	}
}
