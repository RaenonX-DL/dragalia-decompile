/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class GrowthManaCircleUICanvas : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public GrowthManaCircleScene scene;
		public GameObject star;
		public GameObject manaPoint;
		public Button menuButton;
		public Button autoButton;
		public Button abilityListButton;
		public Button screenSaverTouchGuard;
		public UnityEngine.UI.Text abilityDetailButtonText;
		public UnityEngine.UI.Text growthButtonText;
		public UnityEngine.UI.Text autoButtonText;
		public UnityEngine.UI.Text manaPointText;
		public UnityEngine.UI.Text releasedNumText;
		public GameObject screenSaverButton;
		public GameObject onlineButton;
		public GameObject firstEnterEffectButton;
		private Vector2 normalStarPosition;
		private Vector2 normalManaPointPosition;
		private Vector2 normalAbilityListPosition;
		private Vector2 normalMenuPosition;
		private Vector2 normalAutoPosition;
		private Vector2 normalBackButtonPosition;
		private Vector2 autoButtonDelta;
		private Vector2 menuButtonDelta;
		private Vector2 backButtonDelta;
		private Vector2 manaPointDelta;
		private Vector2 abilityListButtonDelta;
		private Vector2 starDelta;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 normalPosition;
			public Vector2 delta;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _StartEnterAnimationParts_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 normalPosition;
			public Vector2 vec;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _StartExitAnimationParts_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 normalPosition;
			public Vector2 vec;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _StartScreenSaverEnterAnimationParts_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 normalPosition;
			public Vector3 targetPos;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _StartScreenSaverExitAnimationParts_b__0(float value);
		}
	
		// Constructors
		public GrowthManaCircleUICanvas();
	
		// Methods
		private void Awake();
		private void Start();
		public void Reload();
		public void ActivateScreenSaverTouchGuard(bool active);
		public void StartEnterAnimation(float duration = 18f);
		private void StartEnterAnimationParts(GameObject obj, float delay, Vector2 delta, float duration);
		public void StartExitAnimation(float duration = 12f);
		private Vector3 StartExitAnimationParts(GameObject obj, float delay, Vector2 vec, float duration);
		public void StartScreenSaverEnterAnimation(float duration = 24f);
		private Vector3 StartScreenSaverEnterAnimationParts(GameObject obj, float delay, Vector2 vec, float duration);
		public void StartScreenSaverExitAnimation(float duration = 24f);
		private void StartScreenSaverExitAnimationParts(GameObject obj, float delay, Vector3 targetPos, float duration);
		public void OnAutotButtonPressed();
		public void OnManaCircleMenuButtonPressed();
		public void OnAbilityListButtonPressed();
		public void OnScreenSaverTouchGuardPressed();
		public void OnAllReleaseuttonPressed();
		public void OnFirstEnterEffctPressed();
		public void OnOfflineButtonPressed();
	}
}
