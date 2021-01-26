/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CuttDriver : MonoBehaviour
	{
		// Fields
		protected CuttTimelineControl _CuttTimelineControl;
		private CuttCharacterInitializer characterInitializer;
		private CuttFlashInitializer flashInitializer;
		public Canvas canvas;
		[SerializeField]
		private GameObject _gameCameraObject;
		[SerializeField]
		private CharaController _chara;
		[SerializeField]
		private MeshRenderer _floorMeshRenderer;
		[SerializeField]
		private MainCameraCtrl.CameraLabel _activeCameraLabel;
		[CompilerGenerated]
		private MainCameraCtrl _mainCameraCtrl_k__BackingField;
		public static bool isPlayingInGame;
		private List<BackupCameraData> backupCameraList;
	
		// Properties
		public MainCameraCtrl mainCameraCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isTimelineControlled { get; }
	
		// Nested types
		private class BackupCameraData
		{
			// Fields
			public CameraGroup cam;
			public float orthographicSize;
			public float near;
			public float far;
			public Vector3 position;
			public Quaternion rotation;
			public float fov;
	
			// Constructors
			public BackupCameraData();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<int> __9__17_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitializeTimeline_b__17_0(int cameraIndex_);
		}
	
		[CompilerGenerated]
		private sealed class _StartInitialize_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CuttDriver __4__this;
			public GameObject canvasObject;
			public bool loadAnimFlag;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartInitialize_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CuttDriver __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CuttDriver();
		static CuttDriver();
	
		// Methods
		public bool InitializeTimeline(CuttTimelineControl timelineControl, bool loadAnimFlag);
		public void SetIngameCuttCameraAnim();
		protected void CreateCameraRoot();
		protected virtual void Awake();
		protected virtual void OnDestroy();
		[IteratorStateMachine]
		protected IEnumerator StartInitialize(GameObject canvasObject, bool loadAnimFlag = true);
		[IteratorStateMachine]
		public virtual IEnumerator Start();
		public virtual void Update();
		private void LateUpdate();
		private void BackupCamera(CameraGroup[] camArray);
		public void Restore2DCameraSetting();
		[CompilerGenerated]
		private void _InitializeTimeline_b__17_1(Color color_);
	}
}
