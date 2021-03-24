/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPickupPage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public SummonPickupCutin cutin;
		public RectTransform movieParent;
		public GameObject movieFade;
		public GameObject movieCover;
		[Header]
		[SerializeField]
		public RectTransform bgFrame;
		[Header]
		[SerializeField]
		public Transform wholePage;
		[Header]
		[SerializeField]
		public Button detailButton;
		[Header]
		[SerializeField]
		public Button switchSummonButton;
		public Sprite[] switchSummonButtonImages;
		private MoviePlayerHandle moviePlayer;
		public static bool shouldPlayVoice;
		private static bool blockVoiceOnDetailScene;
		private const string topMovieNameTemplate = "SummonTopMovie/{0:D6}/pickup_movie_{0:D6}_{1:D2}";
		private Coroutine playVoiceCoroutine;
		private float voiceDelay;
		[HideInInspector]
		public PageViewBase pageView;
		private SummonTopItemData data;
		private float heightOffset;
		private AudioPlayback voicePlayBack;
		private bool lastFrameAlphaBelowOne;
		private SummonTopItemData.PickupInfo pickupInfo;
		public Action onSwitchSummon;
		[CompilerGenerated]
		private bool _isPressing_k__BackingField;
		private Action onTouchDown;
		private Action onTouchUp;
		private Vector3 adjustedIllustrationPos;
	
		// Properties
		public bool isPressing { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _SchedulePlayVoice_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonPickupPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SchedulePlayVoice_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonPickupPage();
		static SummonPickupPage();
	
		// Methods
		public void SetupHeightOffset(float heightOffset);
		private void Start();
		public void RefreshByData(SummonTopItemData data, int index);
		private void UnloadVoiceGroup();
		private void LoadVoiceGroup();
		private void OnDestroy();
		public void OnDetailButtonPressed();
		private void SetAutoPlayChagedSe(bool isSet);
		private void PlayMovie();
		private void LateUpdate();
		private bool IsFinalAlphaBelowOne();
		private void PlayVoice();
		private void StopVoice(float duration = 1f);
		public void SetShouldVoicePlayState();
		private string CreateVoiceName(bool groupName = false);
		private string CreateMovieName();
		public void OnMovieStart(MoviePlayerHandle player);
		[IteratorStateMachine]
		private IEnumerator SchedulePlayVoice();
		public void OnMovieEnd(MoviePlayerHandle player);
		public void StartStabilizationAnimation();
		public void TurnOff();
		public void SetTouchUpDownEvent(Action touchDown, Action touchUp);
		public void OnPointerDown(PointerEventData eventData);
		public void OnPointerUp(PointerEventData eventData);
		public void OnUnitStoryPressed();
		public void OnSwitchSummonPressed();
		[CompilerGenerated]
		private void _OnDetailButtonPressed_b__35_0();
		[CompilerGenerated]
		private void _PlayMovie_b__37_0();
		[CompilerGenerated]
		private void _PlayMovie_b__37_1();
	}
}
