/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu]
	public class TimeCheatingDetector : ActDetectorBase
	{
		// Fields
		internal const string COMPONENT_NAME = "Time Cheating Detector";
		private const string FINAL_LOG_PREFIX = "[ACTk] Time Cheating Detector: ";
		private const string TIME_SERVER = "pool.ntp.org";
		private static int instancesInScene;
		private readonly DateTime date1900;
		[Range]
		[Tooltip]
		public int interval;
		[Tooltip]
		public int threshold;
		[CompilerGenerated]
		private static TimeCheatingDetector _Instance_k__BackingField;
	
		// Properties
		public static TimeCheatingDetector Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private static TimeCheatingDetector GetOrCreateInstance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CheckForCheatCoroutine_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TimeCheatingDetector __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckForCheatCoroutine_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		private TimeCheatingDetector();
	
		// Methods
		public static void StartDetection();
		public static void StartDetection(UnityAction callback);
		public static void StartDetection(UnityAction callback, int interval);
		public static void StopDetection();
		public static void Dispose();
		private void Awake();
		protected override void OnDestroy();
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode);
		private void OnLevelLoadedCallback();
		private void StartDetectionInternal(UnityAction callback, int checkInterval);
		protected override void StartDetectionAutomatically();
		protected override void PauseDetector();
		protected override void ResumeDetector();
		protected override void StopDetectionInternal();
		protected override void DisposeInternal();
		private void CheckForCheat();
		[IteratorStateMachine]
		private IEnumerator CheckForCheatCoroutine();
		public static double GetOnlineTime(string server);
		private double GetLocalTime();
	}
}
