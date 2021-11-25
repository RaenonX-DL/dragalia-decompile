using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class BaseCanvas : SingletonInBaseMonoBehaviour<BaseCanvas>
	{
		public static bool skipCreateOnStart;

		public static bool showBlackCanvasOnStart;

		public BaseCanvasContents mainCanvas;

		public EventSystem eventSystem;

		public GameObject touchGuardCanvas;

		public GameObject blackCanvas;

		public List<float> touchGuardTimeList;

		[HideInInspector]
		public OutGameSettings outGameSettings;

		protected bool isPopupOpened;

		[SerializeField]
		private List<WeakReference> touchGuardObjectWrefList;

		private bool isAllLoadCompleted;

		private int popupCount;

		private void Start()
		{
		}

		private void SetDragThreshold()
		{
		}

		private void Update()
		{
		}

		public bool IsBlackCanvasActive()
		{
			return default(bool);
		}

		public void ShowBlackCanvas(bool show)
		{
		}

		public bool IsAllLoadCompleted()
		{
			return default(bool);
		}

		public void SetActiveBg(ThemeColor themeColor, bool isMyPage = false, bool doExitAnimation = true)
		{
		}

		public void SetCanvasEnable(bool enable)
		{
		}

		public void SetCanvasAlpha(float alpha)
		{
		}

		public void FadeOutCanvas(float duration = 1f, float startAlpha = 1f, float endAlpha = 0f)
		{
		}

		public void FadeInCanvas(float duration = 1f, float startAlpha = 0f, float endAlpha = 1f)
		{
		}

		public void SetTouchGuardEnable(bool enable)
		{
		}

		public void SetParticleEnable(bool enable)
		{
		}

		public bool IsTouchGurdEnable()
		{
			return default(bool);
		}

		public void CreateTouchGuard(float duration = -1f)
		{
		}

		private IEnumerator TouchGuardCoroutine(float duration)
		{
			return null;
		}

		public void RemoveAllTouchGuard()
		{
		}

		public void RemoveTouchGuard()
		{
		}

		private void UpdateTouchGuardStatus()
		{
		}

		public TouchGuardObject CreateTouchGuardObject(string label, float duration = -1f)
		{
			return null;
		}

		public void RemoveTouchGuardObject(TouchGuardObject touchGuardObject)
		{
		}

		private IEnumerator TouchGuardObjectDelayRemove(float duration, TouchGuardObject touchGuardObject)
		{
			return null;
		}

		public void OnPopupOpened()
		{
		}

		public void OnPopupClosed()
		{
		}

		public bool IsPopupOpened()
		{
			return default(bool);
		}
	}
}
