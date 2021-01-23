/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu]
	public class InjectionDetector : ActDetectorBase
	{
		// Fields
		internal const string COMPONENT_NAME = "Injection Detector";
		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";
		protected UnityAction<string> detectionActionWithArgument;
		private static int instancesInScene;
		private bool signaturesAreNotGenuine;
		private AllowedAssembly[] allowedAssemblies;
		private string[] hexTable;
		[CompilerGenerated]
		private static InjectionDetector _Instance_k__BackingField;
	
		// Properties
		public static InjectionDetector Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private static InjectionDetector GetOrCreateInstance { get; }
	
		// Nested types
		private class AllowedAssembly
		{
			// Fields
			public readonly string name;
			public readonly int[] hashes;
	
			// Constructors
			public AllowedAssembly(string name, int[] hashes);
		}
	
		// Constructors
		private InjectionDetector();
	
		// Methods
		public static void StartDetection();
		public static void StartDetection(UnityAction callback);
		public static void StartDetection(UnityAction<string> callback);
		public static void StopDetection();
		public static void Dispose();
		private void Awake();
		protected override void OnDestroy();
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode);
		private void OnLevelLoadedCallback();
		private void StartDetectionInternal(UnityAction callback, UnityAction<string> callbackWithArgument);
		protected override void StartDetectionAutomatically();
		protected override void PauseDetector();
		protected override void ResumeDetector();
		protected override void StopDetectionInternal();
		protected override void DisposeInternal();
		private void OnCheatingDetected(string cause);
		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args);
		private bool FindInjectionInCurrentAssemblies(out string cause);
		private bool AssemblyAllowed(Assembly ass);
		private void LoadAndParseAllowedAssemblies();
		private int GetAssemblyHash(Assembly ass);
		private string PublicKeyTokenToString(byte[] bytes);
	}
}
