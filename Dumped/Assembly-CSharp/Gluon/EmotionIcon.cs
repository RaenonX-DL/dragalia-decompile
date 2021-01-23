/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EmotionIcon : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image balloonImage;
		[SerializeField]
		private Image iconImage;
		[SerializeField]
		private GameObject scaleObject;
		[Header]
		[SerializeField]
		private Sprite[] balloonSprite;
		[SerializeField]
		private Sprite[] iconSprite;
		[Header]
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float stayTime;
		[SerializeField]
		private Vector2[] ofsIcon;
		[SerializeField]
		private float iconScaleH;
		[SerializeField]
		private float iconScaleW;
		[SerializeField]
		private float scaleInTime;
		[SerializeField]
		private float scaleOutTime;
		private const int numBalloon = 2;
		private const int numIcon = 3;
		private Vector2[] sizeBalloon;
		private Vector2[] sizeIcon;
		private Tweener tweener;
		private Tweener tweenerScale;
		private CanvasGroup canvasGroup;
		private CharacterBase chara;
		private float correctPosY;
		private Stat stat;
		private RectTransform rootRt;
		private RectTransform balloonRt;
		private RectTransform iconRt;
		private bool isActive;
		private InGameUICtrl inGameUI;
	
		// Nested types
		public enum Balloon
		{
			Standard = 0,
			Intense = 1
		}
	
		public enum Icon
		{
			Exclamation = 0,
			Anger = 1,
			Exclamation2 = 2
		}
	
		private enum Stat
		{
			None = 0,
			In = 1,
			Stay = 2,
			Out = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOSetter<float> __9__38_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnCompleteFadeIn_b__38_0(float v);
		}
	
		// Constructors
		public EmotionIcon();
	
		// Methods
		public static EmotionIcon Create(InGameUICtrl inGameUI, GameObject prefab, GameObject parent, int siblingIndex = -1);
		private void Initialize(InGameUICtrl inGameUI);
		private void LateUpdate();
		public void Display(CharacterBase chara, Icon icon, Balloon balloon, float scale, float posY = 0f);
		public bool IsActive();
		private void UpdatePosision();
		private Vector2 GetScreenPos(CharacterBase chara);
		private void OnUpdateFade(float value);
		private void OnCompleteFadeIn();
		private void OnCompleteFadeStay();
		private void OnCompleteFadeOut();
		private void OnUpdateScaleIn(float value);
		private void OnUpdateScaleOut(float value);
		private void OnCompleteScaleIn();
		private void OnCompleteScaleOut();
	}
}
