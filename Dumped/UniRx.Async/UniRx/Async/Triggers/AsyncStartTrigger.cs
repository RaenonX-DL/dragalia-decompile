﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncStartTrigger : MonoBehaviour
	{
		// Fields
		private bool awakeCalled;
		private bool called;
		private UniTaskCompletionSource promise;
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem
		{
			// Fields
			private readonly AsyncStartTrigger trigger;
	
			// Constructors
			public AwakeMonitor(AsyncStartTrigger trigger);
	
			// Methods
			public bool MoveNext();
		}
	
		// Constructors
		public AsyncStartTrigger();
	
		// Methods
		private void Awake();
		private void Start();
		public UniTask StartAsync();
		private void OnDestroy();
	}
}
