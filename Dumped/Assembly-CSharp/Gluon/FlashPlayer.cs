/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FlashPlayer : IPoolableObject
	{
		// Fields
		private const float SCREEN_BASE_HEIGHT = 1136f;
		public const float normalOrthoGraphicSize = 5.68f;
		public Transform parentTransform;
		public static Camera flashCamera;
		private GameObject goFlash;
		private FlRoot flashRoot;
		private FlMotion rootMotion;
		private List<FlMotion> listMotion;
		private List<FlPlane> listPlane;
		[CompilerGenerated]
		private bool _isUsing_k__BackingField;
		[CompilerGenerated]
		private Action _OnAnimationEnded_k__BackingField;
		private bool dontCreateCamera;
	
		// Properties
		public GameObject flashObject { get; }
		public bool isUsing { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action OnAnimationEnded { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlRoot FlRoot { get; }
		public List<FlPlane> PlaneList { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public bool willConvertToUGui;
			public FlashPlayer __4__this;
			public Transform parent;
			public Action<int> onLoaded;
			public int loadingIndex;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _PreloadGoFlashAsync_b__0(GameObject go);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public bool willConvertToUGui;
			public FlashPlayer __4__this;
			public Transform transParent;
			public bool dontCreateCamera;
			public Action<int> onLoaded;
			public int loadingIndex;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _OnInitPreloadGoFlashAsync_b__0(GameObject go);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public FlashPlayer __4__this;
			public bool isAutoDestroy;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _OnInit_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public FlLabelParameter label;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _BindAutoSE_b__0();
		}
	
		// Constructors
		public FlashPlayer();
	
		// Methods
		public void OnInitWithScreenPos(string prefabPath, Vector3 screenPos, float scale = 1f, bool isAutoDestroy = true, bool isPreIn = false, bool dontCreateCamera = false);
		public void PreloadGoFlashAsync(string prefabPath, Action<int> onLoaded, int loadingIndex, Transform parent = null, bool willConvertToUGui = false);
		public void OnInitPreloadGoFlashAsync(string prefabPath, Transform transParent, Action<int> onLoaded, int loadingIndex = 0, bool dontCreateCamera = false, bool willConvertToUGui = false);
		public void OnInit(string prefabPath, Vector3 position, float scale = 1f, bool isAutoDestroy = true, bool isKeepPosition = false, bool isPreIn = false, Transform parent = null, bool doNotSetLayer = false, bool dontCreateCamera = false);
		public void CreateFlash(string prefabPath, bool isPreIn = false);
		public void CreateCloneFlash(GameObject prefab, Transform parent, bool dontCreateCamera = false);
		public static void SetEdgeToEdgeCameraSize(Canvas canvas, Camera specificCamera = null);
		public static void SetEdgeToEdgeCameraSize(float width, float height, Camera specificCamera = null, bool fitScreen = false);
		public static void SetCameraPositionOffsetForIPhoneX(Camera specificCamera = null);
		public static void SetCameraPositionOffset(Vector3 offsetInNormalizedCanvas, Camera specificCamera = null);
		public void BindAutoSE();
		public void OnDestroy(bool isDestroyImmediate = false);
		public static Vector3 GetPosForFlash(Vector3 screenPos);
		public static Vector2 GetFlashPosFromUIWorldPos(Vector3 worldPos, Camera camera, Canvas canvas);
		public void Stop();
		public void Stop(string label);
		public void Stop(string label, string objectName);
		public void Play(bool isClearOuterTexture = false, bool isAllPlay = false);
		public void Play(string label, bool isClearOuterTexture = false);
		public void Play(string label, string objectName, bool isClearOuterTexture = false);
		public void Play(int frame);
		public void Play(int frame, string objectName);
		private void PlayMotion();
		private void PlayMotion(string label);
		private void PlayMotion(int frame);
		private void PauseMotion();
		private void PauseMotion(string label);
		public void Pause(string label);
		private void CreateFlashCamera();
		public void SetDefaultSortOffset(int sortOrder);
		public void ReplaceAllMaterialsToWriteAlpha();
		public static void ReplaceAllMaterialsToWriteAlpha(List<FlPlane> listPlane);
		public void SetLabelCallbak(Action action, string label, FlMotionActionTypes type);
		public void RemoveAllCallback(string labelName, FlMotionActionTypes actionType);
		public void RemoveAllCallback();
		public FlMotion GetRootMotion();
		public void Init();
		public void Release();
		public bool IsUsing();
	}
}
