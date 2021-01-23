/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncAwakeTrigger : MonoBehaviour
	{
		// Fields
		private bool called;
		private UniTaskCompletionSource promise;
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem
		{
			// Fields
			private readonly AsyncAwakeTrigger trigger;
	
			// Constructors
			public AwakeMonitor(AsyncAwakeTrigger trigger);
	
			// Methods
			public bool MoveNext();
		}
	
		// Constructors
		public AsyncAwakeTrigger();
	
		// Methods
		private void Awake();
		public UniTask AwakeAsync();
		private void OnDestroy();
	}
}
