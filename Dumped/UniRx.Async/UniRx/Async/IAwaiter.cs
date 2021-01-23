/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public interface IAwaiter : ICriticalNotifyCompletion
	{
		// Properties
		AwaiterStatus Status { get; }
		bool IsCompleted { get; }
	
		// Methods
		void GetResult();
	}
}
