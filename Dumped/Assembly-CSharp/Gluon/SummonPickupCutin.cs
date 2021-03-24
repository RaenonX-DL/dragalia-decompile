/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPickupCutin : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image illustrationImage;
		public Image commentImage;
		public Image skillImage;
		public Image bottomInfoImage;
		public Image bgForAmuletImage;
		[Header]
		[SerializeField]
		public Transform illustrationMovePart;
		public Transform bottomMovePart;
		public Transform postMovieInfoMovePart;
		public Transform movieFadeMovePart;
		public Transform coverUnitMovePart;
		[Header]
		[SerializeField]
		public Image coverBGImage;
		public Image coverUnitImage;
		public Image coverCardImage;
		public Image topBannerImage;
		public Image topLogoImage;
		[Header]
		[SerializeField]
		public GameObject cutinPage;
		public GameObject coverPage;
		[Header]
		[SerializeField]
		public Animator cutinAnimator;
		private string pathOfPickupId;
		private int currentSummonId;
		private const float imageMoveDist = 120f;
		private const float imageMoveTime = 0.35f;
		private const float amuletImageMoveTime = 0.45f;
		private const float cutinFillInTime = 3f;
		private const float movieFadeOutTimeOffset = 0.55f;
		private const float postCutinMoveDistX = 380f;
		private const float postCutinMoveDistY = 30f;
		private const float postCutinSkillMoveDistY = 0f;
		private const float postCutinMoveTime = 0.75f;
		private const float postCutinSkillDelay = 0.15f;
		private const float movieFadeInOutTime = 0.4f;
		private const float movieFadeOutEndAlpha = 0.3f;
		private const float amuletIllustRotateZ = 5f;
		private List<Sequence> runningEnterSequenceList;
		private bool coverPageMode;
		private SummonTopItemData.PickupInfo pickupInfo;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0
		{
			// Fields
			public CanvasGroup canvasGroup;
			public float fadeStartAlpha;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _DoMoveAndFade_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _HideMovieFadeOutCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonPickupCutin __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _HideMovieFadeOutCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonPickupCutin();
	
		// Methods
		private void Awake();
		public void SwitchImagesBySummonIdAndIndex(int summonId, SummonTopItemData.PickupInfo pickupInfo);
		private void DoRotateZAndFlip(Transform t, float moveTime, float z);
		private void DoMoveAndFade(Transform t, float distX, float distY, float moveTime, float delay = 0f, float fadeStartAlpha = 0f, float fadeEndAlpha = 1f);
		public void DoStabilizationAnimation();
		public void StartPostMovieAnimation();
		[IteratorStateMachine]
		private IEnumerator HideMovieFadeOutCoroutine();
		public void SkipRunningEnterSequences();
		public void TurnOff();
		private void SetImage(string assetsPath, Image image, string pathTemplate);
		private void ExchangeSprites();
	}
}
