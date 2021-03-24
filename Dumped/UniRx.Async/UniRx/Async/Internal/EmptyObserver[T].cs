/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal class EmptyObserver<T> : IObserver<T>
	{
		// Fields
		public static readonly EmptyObserver<T> Instance;
	
		// Constructors
		private EmptyObserver();
		static EmptyObserver();
	
		// Methods
		public void OnCompleted();
		public void OnError(Exception error);
		public void OnNext(T value);
	}
}
