/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu]
	public class SpeedHackDetector : ActDetectorBase
	{
		// Fields
		internal const string COMPONENT_NAME = "Speed Hack Detector";
		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";
		private const long TICKS_PER_SECOND = 10000000;
		private const int THRESHOLD = 5000000;
		private const float THRESHOLD_FLOAT = 0.5f;
		private static int instancesInScene;
		[Tooltip]
		public float interval;
		[Tooltip]
		public byte maxFalsePositives;
		[Tooltip]
		public int coolDown;
		private byte currentFalsePositives;
		private int currentCooldownShots;
		private long ticksOnStart;
		private long vulnerableTicksOnStart;
		private long prevTicks;
		private long prevIntervalTicks;
		private float vulnerableTimeOnStart;
		[CompilerGenerated]
		private static SpeedHackDetector _Instance_k__BackingField;
	
		// Properties
		public static SpeedHackDetector Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private static SpeedHackDetector GetOrCreateInstance { get; }
	
		// Constructors
		private SpeedHackDetector();
	
		// Methods
		public static void StartDetection();
		public static void StartDetection(UnityAction callback);
		public static void StartDetection(UnityAction callback, float interval);
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives);
		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown);
		public static void StopDetection();
		public static void Dispose();
		private void Awake();
		protected override void OnDestroy();
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode);
		private void OnLevelLoadedCallback();
		private void OnApplicationPause(bool pause);
		private void Update();
		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown);
		protected override void StartDetectionAutomatically();
		protected override void PauseDetector();
		protected override void ResumeDetector();
		protected override void StopDetectionInternal();
		protected override void DisposeInternal();
		private void ResetStartTicks();
	}
}
