/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal class ListObserver<T> : IObserver<T>
	{
		// Fields
		private readonly ImmutableList<IObserver<T>> _observers;
	
		// Constructors
		public ListObserver(ImmutableList<IObserver<T>> observers);
	
		// Methods
		public void OnCompleted();
		public void OnError(Exception error);
		public void OnNext(T value);
		internal IObserver<T> Add(IObserver<T> observer);
		internal IObserver<T> Remove(IObserver<T> observer);
	}
}
