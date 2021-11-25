using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TutorialSummonResultPage : TutorialSummonPageBase
	{
		[SerializeField]
		private Image whiteOutImage;

		[SerializeField]
		private Button endButton;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Button unitListButton;

		[SerializeField]
		private Button nextButton;

		[SerializeField]
		private GameObject nowLoading;

		[SerializeField]
		private RectTransform itemsParentRectTransform;

		[SerializeField]
		private RectTransform edgeToEdgeRectTransform;

		[SerializeField]
		private RectTransform resultItemsRectTransform;

		[SerializeField]
		public RawImage bg3dRenderTextureImage;

		[SerializeField]
		public GameObject resultItemTemplate;

		[SerializeField]
		private Text nextButtonText;

		[SerializeField]
		private Transform[] resultItemParents;

		[SerializeField]
		private UIAnimationPublisher enterPublisher;

		private List<GameObject> resultItems;

		private Vector2 _canvasSize;

		private Vector2 basePos;

		private bool is3DSceneLoaded;

		private TutorialSummonResultScene animScene;

		private Sequence whiteOutSeq;

		private GameObject renderTextureCameraObj;

		private TouchGuardObject resetTouchGuard;

		public Vector2 canvasSize => default(Vector2);

		private void Start()
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		private void Load3DScene(Action callback)
		{
		}

		public void ResetFlashCameraSize()
		{
		}

		public void Show(bool isResult)
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

		public IEnumerator ChangeToResultPage(bool isFadingOut, float waitingTime)
		{
			return null;
		}

		public void CreateBgRenderTexture()
		{
		}

		public void StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		public void SetContent(bool isFadingOut)
		{
		}

		private void SetupContents()
		{
		}

		private void SetupItemList()
		{
		}

		private void SetupItemListSub(SummonResultItemData drawInfo, int index, int total)
		{
		}

		private void UpdateNextItems()
		{
		}

		private void TeardownContents()
		{
		}

		public void Release3DObjects()
		{
		}

		public void OnNextButton()
		{
		}

		public void ShowNextItems()
		{
		}

		public void OnTutorialSummonEndButton()
		{
		}

		public void OnSummonUnitList()
		{
		}

		public void OnSummonResetButtonPressed()
		{
		}

		public void StartNextSummonAnimation()
		{
		}
	}
}
