using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyUICanvas : PartyUICanvasBase
	{
		public PartyScene scene;

		public RawImage render3dImage;

		public Button showListButton;

		public Button exAbilityButton;

		public Button organizeButton;

		public Button autoButton;

		public PageViewBase pageView;

		public PartyUIStatus[] partyStatus;

		public Image leadImage;

		public GameObject statusBase;

		public GameObject partyInfoAnimeBase;

		public RectTransform scrollLockRect;

		public CanvasGroup canvasGroup;

		public Text partyNameText;

		[SerializeField]
		[Header("DummyRect")]
		public RectTransform partyBaseMoveTo;

		public RectTransform learderImageMoveTo;

		public RectTransform statusMoveTo;

		public RectTransform switchButtonMoveTo;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher enterExitPublisherPublisher;

		public UIAnimationPublisher goCharacterPublisher1;

		public UIAnimationPublisher goCharacterPublisher2;

		public UIAnimationPublisher goEquipPublisher1;

		public UIAnimationPublisher goEquipPublisher2;

		private SceneUICanvas sceneUiCanvas;

		private float fromMyPageDelay;

		public PartyPageCtrl pageCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isEditSkillTutorialRunning => default(bool);

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator ActivateStatusDelay()
		{
			return null;
		}

		private void SetPageContent(GameObject page, int index)
		{
		}

		public void CharaModelPressed(int tag)
		{
		}

		public void CharaModelLongPressed(int tag)
		{
		}

		public void Reload()
		{
		}

		public void OnExAbilityButtonPressed()
		{
		}

		public void OnListButtonPressed()
		{
		}

		public void OnOrganizeButtonPressed()
		{
		}

		public void OnAutoButtonPressed()
		{
		}

		public IEnumerator Tutorial_1_1()
		{
			return null;
		}

		public void LoadPowerParam()
		{
		}

		public void AbleAllButton()
		{
		}

		public void DisableAllButton()
		{
		}

		public void DisableAllButtonExceptAuto()
		{
		}

		public void DisableAllButtonExceptFirstEquip()
		{
		}

		private IEnumerator PlayEnterAnimation(float delay)
		{
			return null;
		}

		public void StartGoCharacterSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void StartGoEquipSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished)
		{
			return null;
		}

		public void AdjustInnerAnimationOffset()
		{
		}

		private void SetVisibleCanvas(bool enable)
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		private void ReloadPartyView()
		{
		}

		public void OnPartyNameEditButtonPressed()
		{
		}

		protected override void SetStatusMode(PartyModel.PartySceneUnitStatusMode statusMode)
		{
		}

		public override void OnEventBonusIconPressed()
		{
		}

		protected override bool IsRaidBoostOn(int questId)
		{
			return default(bool);
		}
	}
}
