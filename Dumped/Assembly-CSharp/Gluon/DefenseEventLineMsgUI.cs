/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DefenseEventLineMsgUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform bgRt;
		[SerializeField]
		private UnityEngine.UI.Text message;
		[SerializeField]
		private SpriteRenderer bgImage;
		[Header]
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float stayTime;
		[SerializeField]
		[Tooltip]
		private float slideMoveVal;
		private RectTransform rootRt;
		private CanvasGroup canvasGroup;
		private Tweener tweenerFade;
		private bool isDisplaying;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOSetter<float> __9__17_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnCompleteFade0_b__17_0(float v);
		}
	
		// Constructors
		public DefenseEventLineMsgUI();
	
		// Methods
		public static DefenseEventLineMsgUI Create(GameObject parent, InGameUIConst.DecorationType type, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
		public bool IsDisplaying();
		public void Display(string msg);
		private void OnUpdateFadeIn(float value);
		private void OnUpdateFadeOut(float value);
		private void OnCompleteFade0();
		private void OnCompleteFade1();
		private void OnCompleteFadeOut();
		public void AdjustPosY(float posY);
	}
}
