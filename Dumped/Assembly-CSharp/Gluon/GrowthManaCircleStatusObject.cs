/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleStatusObject : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleStatusController controller;
		public UnityEngine.UI.Text hpText;
		public UnityEngine.UI.Text attackText;
		public UnityEngine.UI.Text powerText;
		public UnityEngine.UI.Text exAbilityText;
		public UnityEngine.UI.Text burstAttackText;
		public UnityEngine.UI.Text skillText;
		public UnityEngine.UI.Text abilityText;
		public Image exAbilityImage;
		public Image exAbility2Image;
		public Image burstAttackImage;
		public Image skill1Image;
		public Image skill2Image;
		public Image ability1Image;
		public Image ability2Image;
		public Image ability3Image;
		public Image exAbilityNotAvailableImage;
		public Image exAbility2NotAvailableImage;
		public Image burstAttackNotAvailableImage;
		public Image skill1NotAvailableImage;
		public Image skill2NotAvailableImage;
		public Image ability1NotAvailableImage;
		public Image ability2NotAvailableImage;
		public Image ability3NotAvailableImage;
		private RectTransform rectTransform;
		private CanvasGroup canvasGroup;
		private const float duration = 0.5f;
		private const float imageWidth = 774f;
		private const float imageY = -99f;
		private Color32 darkColor;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__33_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _StartShowingAnimation_b__33_1();
		}
	
		// Constructors
		public GrowthManaCircleStatusObject();
	
		// Methods
		private void Awake();
		public void Reload();
		public void SetAlpha(float value);
		public void StartShowingAnimation(int direction);
		public void StartHidingAnimation(int direction);
		private void OnAlphaAnimationUpdate(float value);
		private void OnPositionAnimationUpdate(float value);
		private void OnPositionAnimationComplete();
		[CompilerGenerated]
		private void _StartShowingAnimation_b__33_0(float value);
		[CompilerGenerated]
		private void _StartShowingAnimation_b__33_2(float value);
		[CompilerGenerated]
		private void _StartShowingAnimation_b__33_3();
		[CompilerGenerated]
		private void _StartHidingAnimation_b__34_0(float value);
		[CompilerGenerated]
		private void _StartHidingAnimation_b__34_1(float value);
		[CompilerGenerated]
		private void _StartHidingAnimation_b__34_2();
	}
}
