/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.OurUtils
{
	public class PlayGamesHelperObject : MonoBehaviour
	{
		// Fields
		private static PlayGamesHelperObject instance;
		private static bool sIsDummy;
		private static List<Action> sQueue;
		private List<Action> localQueue;
		private static bool sQueueEmpty;
		private static List<Action<bool>> sPauseCallbackList;
		private static List<Action<bool>> sFocusCallbackList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public IEnumerator action;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _RunCoroutine_b__0();
		}
	
		// Constructors
		public PlayGamesHelperObject();
		static PlayGamesHelperObject();
	
		// Methods
		public static void CreateObject();
		public void Awake();
		public void OnDisable();
		public static void RunCoroutine(IEnumerator action);
		public static void RunOnGameThread(Action action);
		public void Update();
		public void OnApplicationFocus(bool focused);
		public void OnApplicationPause(bool paused);
		public static void AddFocusCallback(Action<bool> callback);
		public static bool RemoveFocusCallback(Action<bool> callback);
		public static void AddPauseCallback(Action<bool> callback);
		public static bool RemovePauseCallback(Action<bool> callback);
	}
}
