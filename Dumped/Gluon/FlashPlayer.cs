using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class FlashPlayer : IPoolableObject
	{
		private const float SCREEN_BASE_HEIGHT = 1136f;

		public const float normalOrthoGraphicSize = 5.68f;

		public Transform parentTransform;

		public static Camera flashCamera;

		private GameObject goFlash;

		private FlRoot flashRoot;

		private FlMotion rootMotion;

		private List<FlMotion> listMotion;

		private List<FlPlane> listPlane;

		private bool dontCreateCamera;

		public GameObject flashObject => null;

		public bool isUsing
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action OnAnimationEnded
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FlRoot FlRoot => null;

		public List<FlPlane> PlaneList => null;

		public void OnInitWithScreenPos(string prefabPath, Vector3 screenPos, float scale = 1f, bool isAutoDestroy = true, bool isPreIn = false, bool dontCreateCamera = false)
		{
		}

		public void PreloadGoFlashAsync(string prefabPath, Action<int> onLoaded, int loadingIndex, [Optional] Transform parent, bool willConvertToUGui = false)
		{
		}

		public void OnInitPreloadGoFlashAsync(string prefabPath, Transform transParent, Action<int> onLoaded, int loadingIndex = 0, bool dontCreateCamera = false, bool willConvertToUGui = false)
		{
		}

		public void OnInit(string prefabPath, Vector3 position, float scale = 1f, bool isAutoDestroy = true, bool isKeepPosition = false, bool isPreIn = false, [Optional] Transform parent, bool doNotSetLayer = false, bool dontCreateCamera = false)
		{
		}

		public void CreateFlash(string prefabPath, bool isPreIn = false)
		{
		}

		public void CreateCloneFlash(GameObject prefab, Transform parent, bool dontCreateCamera = false)
		{
		}

		public static void SetEdgeToEdgeCameraSize(Canvas canvas, [Optional] Camera specificCamera)
		{
		}

		public static void SetEdgeToEdgeCameraSize(float width, float height, [Optional] Camera specificCamera, bool fitScreen = false)
		{
		}

		public static void SetCameraPositionOffsetForIPhoneX([Optional] Camera specificCamera)
		{
		}

		public static void SetCameraPositionOffset(Vector3 offsetInNormalizedCanvas, [Optional] Camera specificCamera)
		{
		}

		public void BindAutoSE()
		{
		}

		public void OnDestroy(bool isDestroyImmediate = false)
		{
		}

		public static Vector3 GetPosForFlash(Vector3 screenPos)
		{
			return default(Vector3);
		}

		public static Vector2 GetFlashPosFromUIWorldPos(Vector3 worldPos, Camera camera, Canvas canvas)
		{
			return default(Vector2);
		}

		public void Stop()
		{
		}

		public void Stop(string label)
		{
		}

		public void Stop(string label, string objectName)
		{
		}

		public void Play(bool isClearOuterTexture = false, bool isAllPlay = false)
		{
		}

		public void Play(string label, bool isClearOuterTexture = false)
		{
		}

		public void Play(string label, string objectName, bool isClearOuterTexture = false)
		{
		}

		public void Play(int frame)
		{
		}

		public void Play(int frame, string objectName)
		{
		}

		private void PlayMotion()
		{
		}

		private void PlayMotion(string label)
		{
		}

		private void PlayMotion(int frame)
		{
		}

		private void PauseMotion()
		{
		}

		private void PauseMotion(string label)
		{
		}

		public void Pause(string label)
		{
		}

		private void CreateFlashCamera()
		{
		}

		public void SetDefaultSortOffset(int sortOrder)
		{
		}

		public void ReplaceAllMaterialsToWriteAlpha()
		{
		}

		public static void ReplaceAllMaterialsToWriteAlpha(List<FlPlane> listPlane)
		{
		}

		public void SetLabelCallbak(Action action, string label, FlMotionActionTypes type)
		{
		}

		public void RemoveAllCallback(string labelName, FlMotionActionTypes actionType)
		{
		}

		public void RemoveAllCallback()
		{
		}

		public FlMotion GetRootMotion()
		{
			return null;
		}

		public void Init()
		{
		}

		public void Release()
		{
		}

		public bool IsUsing()
		{
			return default(bool);
		}
	}
}
