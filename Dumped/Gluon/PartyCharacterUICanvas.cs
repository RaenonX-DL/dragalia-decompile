using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyCharacterUICanvas : PartyUICanvasBase
	{
		[SerializeField]
		public PartyCharacterScene scene;

		public CommonIconListBase iconListFrame;

		public GameObject statusBase;

		public PartyCharacterUIStatus[] partyStatus;

		public Image leadImage;

		public GameObject partyInfoAnimeBase;

		public Image[] selectedImages;

		public PartyPageViewBase pageView;

		public float runAnimationDistance;

		public Text clearPartyText;

		public Text autoEquipButtonText;

		public Sprite addPartySprite;

		public Sprite selectPartySprite;

		public RectTransform edgeToEdgeFrame;

		public Text partyNameText;

		[SerializeField]
		private GameObject powerBack;

		[SerializeField]
		private GameObject raidPowerBack;

		public CanvasGroup canvasGroup;

		public UnityAction<int> characterPressCallBack;

		public UnityAction<int> characterLongPressCallBack;

		[SerializeField]
		private GameObject clearPartyButtonObj;

		[SerializeField]
		private GameObject normalPartyButtonObj;

		[SerializeField]
		private GameObject[] oneUnitNonActiveObjects;

		[SerializeField]
		[Header("TopDummyRect")]
		public RectTransform topPartyBaseMoveTo;

		public RectTransform topLearderImageMoveTo;

		public RectTransform topStatusMoveTo;

		public RectTransform topSwitchButtonMoveTo;

		[SerializeField]
		[Header("QuestDummyRect")]
		public RectTransform questPartyBaseMoveTo;

		public RectTransform questLearderImageMoveTo;

		public RectTransform questStatusMoveTo;

		public RectTransform questSwitchButtonMoveTo;

		[SerializeField]
		[Header("Publishers")]
		public UIAnimationPublisher fromTopPublisher1;

		public UIAnimationPublisher fromEquipPublisher;

		public UIAnimationPublisher toEquipPublisher;

		[SerializeField]
		[Header("CharacterTransparentButton")]
		public PointerEventHandler[] characterTransparentButtonsEventHandler;

		public GameObject partyNameBaseObject;

		public GameObject partyChangeButtonObject;

		private PartyCharacterListController partyListController;

		private SceneUICanvas sceneUiCanvas;

		private int questId;

		private bool isEnableRaidBoost;

		[SerializeField]
		private GameObject dragonOnlyIcon;

		private bool isCompleteStartProcess;

		private bool isShowEquipOverPopup;

		private bool isBreakApplyEquipSetLoop;

		public PartyCharacterPageCtrl pageCtrl
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

		public bool IsCompleteStartProcess => default(bool);

		private IEnumerator Start()
		{
			return null;
		}

		private void UpdateClearPartyButton()
		{
		}

		private IEnumerator ActivateStatusDelay()
		{
			return null;
		}

		public void ConfirmChangePageCallBack()
		{
		}

		public void ConfirmMovePagerPage(int index)
		{
		}

		private void SetPageContent(GameObject page, int index)
		{
		}

		public void CharacterPressed(int tag)
		{
		}

		public void CharacterLongPressed(int tag)
		{
		}

		public void ShowClearParty()
		{
		}

		public void ShowNormalParty()
		{
		}

		public void Reload()
		{
		}

		public void OnEquipChangeButtonPressed()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		private void SetUseClearParty()
		{
		}

		public void OnClearPartyButtonTouched()
		{
		}

		public void OnNormalPartyButtonTouched()
		{
		}

		public void OnExAbilityButtonPressed()
		{
		}

		public void LoadPowerParam()
		{
		}

		public void OnAutoButtonPressed()
		{
		}

		public void HideCharacterStateUI()
		{
		}

		public void AdjustInnerAnimationOffset()
		{
		}

		public void StartGoTopSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void StartGoEquipSceneAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void StartExitAnimation()
		{
		}

		private IEnumerator WaitLastAnimationInnerMoveEnd(Action onFinished)
		{
			return null;
		}

		private void SetVisibleCanvas(bool enable)
		{
		}

		private void OneUnitQuestSetting(bool isOneUnit)
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

		public void OnPartyEquipSetButtonPressed()
		{
		}

		private void ApplyEquipSetData(int charaIndex, int setIndex)
		{
		}

		private void ApplyEquipSetWeaponData(int charaIndex, int weaponId)
		{
		}

		private void ApplyEquipSetDragonData(int charaIndex, ulong dragonKeyId)
		{
		}

		private void ApplyEquipSetCrestData(int charaIndex, int[] crestIds)
		{
		}

		private void ApplyEquipSetTalismanData(int charaIndex, ulong talismanKeyId)
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
