using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cute.Core
{
	public class MainThreadEventDispatcher : IUpdatable
	{
		private object lockObject;

		private List<Action> mainQueue;

		private List<Action> threadQueue;

		private static MainThreadEventDispatcher instance;

		public static MainThreadEventDispatcher Instance => null;

		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}

		public void EnqueEvent(Action callback)
		{
		}

		void IUpdatable.FastUpdate()
		{
		}
	}
}
