/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		// Fields
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";
		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";
		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
		protected static GameObject detectorsContainer;
		[Tooltip]
		public bool autoStart;
		[Tooltip]
		public bool keepAlive;
		[Tooltip]
		public bool autoDispose;
		[SerializeField]
		protected UnityEvent detectionEvent;
		protected UnityAction detectionAction;
		[SerializeField]
		protected bool detectionEventHasListener;
		protected bool isRunning;
		protected bool started;
	
		// Constructors
		protected ActDetectorBase();
	
		// Methods
		private void Start();
		private void OnEnable();
		private void OnDisable();
		private void OnApplicationQuit();
		protected virtual void OnDestroy();
		protected virtual bool Init(ActDetectorBase instance, string detectorName);
		protected virtual void DisposeInternal();
		protected virtual bool DetectorHasAdditionalCallbacks();
		internal virtual void OnCheatingDetected();
		protected abstract void StartDetectionAutomatically();
		protected abstract void StopDetectionInternal();
		protected abstract void PauseDetector();
		protected abstract void ResumeDetector();
	}
}
