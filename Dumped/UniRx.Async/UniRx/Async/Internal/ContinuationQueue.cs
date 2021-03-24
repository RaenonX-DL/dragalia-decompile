/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal class ContinuationQueue
	{
		// Fields
		private const int MaxArrayLength = 2146435071;
		private const int InitialSize = 16;
		private SpinLock gate;
		private bool dequing;
		private int actionListCount;
		private Action[] actionList;
		private int waitingListCount;
		private Action[] waitingList;
	
		// Constructors
		public ContinuationQueue();
	
		// Methods
		public void Enqueue(Action continuation);
		public void Run();
	}
}
