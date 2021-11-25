using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonAnimPage : EventQuestPageBase
	{
		[SerializeField]
		private BoxSummonResult boxSummonResult;

		[SerializeField]
		private Image whiteOutImage;

		[SerializeField]
		private GameObject screenTapObj;

		[SerializeField]
		private Button skipButton;

		[SerializeField]
		private GameObject nowLoading;

		[SerializeField]
		private RectTransform itemsParentRectTransform;

		[SerializeField]
		private RectTransform edgeToEdgeRectTransform;

		[SerializeField]
		private RectTransform resultItemsRectTransform;

		public RawImage bg3dRenderTextureImage;

		private GameObject renderTextureCameraObj;

		private Sequence whiteOutSeq;

		private BoxSummonAnimScene animScene;

		private Canvas uiCanvas;

		private const string boxSummonAnimBGM = "BGM_SUMMON_0002_01";

		private bool is3DSceneLoaded;

		public Vector2 _canvasSize;

		private Vector2 basePos;

		public Canvas UiCanvas => null;

		public AudioPlayback bgmAudioPlayer
		{
			[CompilerGenerated]
			get
			{
				return default(AudioPlayback);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2 canvasSize => default(Vector2);

		private void Start()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void ResetSummonData()
		{
		}

		public void ResetFlashCameraSize()
		{
		}

		public void StartSummonAnimation()
		{
		}

		public void StartNextSummonAnimation()
		{
		}

		private void Load3DScene(Action callback)
		{
		}

		private void StartLoadingResources()
		{
		}

		public void StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		private void SkipAnimation(bool needFadeOut)
		{
		}

		public void OnSkipButtonPressed()
		{
		}

		public void Show(bool isResult)
		{
		}

		public void ShowResultUIs(bool toShow)
		{
		}

		public void ShowSkipButton(bool isShown)
		{
		}

		public IEnumerator ChangeToResultPage(bool isFadingOut, float waitingTime)
		{
			return null;
		}

		public void OnScreenTapped()
		{
		}

		public void CreateBgRenderTexture()
		{
		}

		public Vector2 GetIconPosition(Vector2 pos)
		{
			return default(Vector2);
		}

		public Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos)
		{
			return default(Vector3);
		}

		protected override int GetMaxExecCount()
		{
			return default(int);
		}

		public void Release3DObjects()
		{
		}
	}
}
