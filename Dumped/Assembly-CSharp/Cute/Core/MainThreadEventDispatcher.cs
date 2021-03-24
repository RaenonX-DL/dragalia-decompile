/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class MainThreadEventDispatcher : IUpdatable
	{
		// Fields
		private object lockObject;
		private List<Action> mainQueue;
		private List<Action> threadQueue;
		private static MainThreadEventDispatcher instance;
	
		// Properties
		public static MainThreadEventDispatcher Instance { get; }
	
		// Constructors
		public MainThreadEventDispatcher();
		static MainThreadEventDispatcher();
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize();
		public void EnqueEvent(Action callback);
		void IUpdatable.FastUpdate();
	}
}
