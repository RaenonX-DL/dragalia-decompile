using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonPickupPage : MonoBehaviour
	{
		[SerializeField]
		public SummonPickupCutin cutin;

		public RectTransform movieParent;

		public GameObject movieFade;

		public GameObject movieCover;

		[SerializeField]
		[Header("EtoE")]
		public RectTransform bgFrame;

		[SerializeField]
		[Header("Animation")]
		public Transform wholePage;

		[SerializeField]
		[Header("Detail")]
		public Button detailButton;

		[SerializeField]
		[Header("CSSummon")]
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

		private Action onTouchDown;

		private Action onTouchUp;

		private Vector3 adjustedIllustrationPos;

		public bool isPressing
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

		public void SetupHeightOffset(float heightOffset)
		{
		}

		private void Start()
		{
		}

		public void RefreshByData(SummonTopItemData data, int index)
		{
		}

		private void UnloadVoiceGroup()
		{
		}

		private void LoadVoiceGroup()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		private void SetAutoPlayChagedSe(bool isSet)
		{
		}

		private void PlayMovie()
		{
		}

		private void LateUpdate()
		{
		}

		private bool IsFinalAlphaBelowOne()
		{
			return default(bool);
		}

		private void PlayVoice()
		{
		}

		private void StopVoice(float duration = 1f)
		{
		}

		public void SetShouldVoicePlayState()
		{
		}

		private string CreateVoiceName(bool groupName = false)
		{
			return null;
		}

		private string CreateMovieName()
		{
			return null;
		}

		public void OnMovieStart(MoviePlayerHandle player)
		{
		}

		private IEnumerator SchedulePlayVoice()
		{
			return null;
		}

		public void OnMovieEnd(MoviePlayerHandle player)
		{
		}

		public void StartStabilizationAnimation()
		{
		}

		public void TurnOff()
		{
		}

		public void SetTouchUpDownEvent(Action touchDown, Action touchUp)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnUnitStoryPressed()
		{
		}

		public void OnSwitchSummonPressed()
		{
		}
	}
}
