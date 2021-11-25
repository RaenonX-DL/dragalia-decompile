using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitEnhanceListCell : MonoBehaviour
	{
		public UnitEnhanceListCellType cellType;

		public Image iconImage;

		public CommonSlider slider;

		public Text releaseCountText;

		public Button releaseButton;

		public Button checkMaterialButton;

		public GameObject lockObject;

		public GameObject lockIconObject;

		public Text lockText;

		public Image[] skinIcons;

		public GameObject skinIconRoot;

		public Transform[] blackMaskTransforms;

		public GameObject completeObject;

		public LayoutElement cellLayoutElement;

		public float cellHeightNoSkin;

		public Image bgImage;

		public Image bgImageNoSkin;

		public Action<UnitEnhanceListCellType> cellButtonPressedCallBack;

		private GrowthUnitEnhanceModel model;

		private GrowthWeaponSkinConfirmData[] skinConfirmDatas;

		private GrowthUnitEnhanceMainCanvas mainCanvas;

		private bool isLoadingEnhancementFlash;

		private float cellHeightDefault;

		public bool isDesabledCell
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isComplete
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public void InitCell(GrowthUnitEnhanceModel model, GrowthUnitEnhanceMainCanvas mainCanvas)
		{
		}

		public void UpdateCell()
		{
		}

		public void OnCellButtonPressed()
		{
		}

		public void OnSkinIconPressed(int index)
		{
		}

		private void UpdateStatusCell()
		{
		}

		private void UpdateLimitBreakCell()
		{
		}

		private void UpdateLimitOverCell()
		{
		}

		private void UpdateWeaponPassiveAbilityCell()
		{
		}

		private void ResetCellHeight(bool isGetSkin)
		{
		}

		private void UpdateSlotCell()
		{
		}

		private void UpdateWeaponBonusCell()
		{
		}

		private void UpdateAddEquipCoountCell()
		{
		}

		private void SetupReleaseSlider(int nowCount, int maxCount)
		{
		}

		private void SetupCellButton(bool canRelease)
		{
		}

		private void SetConditionLevelText(int conditionLevel)
		{
		}

		private void SetConditionLimitBreakText(int conditionLimitBreak)
		{
		}

		private void SetConditionLimitOverText(int conditionLimitOver)
		{
		}

		private void SetCompleteLockCell()
		{
		}

		private void SetCellIcon()
		{
		}

		private void SetTutorial()
		{
		}

		private string GetEnhancementFlashPath()
		{
			return null;
		}

		public Task PreLoadEnhancementFlash(FlashPlayer flashPlayer)
		{
			return null;
		}

		public Task PlayEnhancementFlash(FlashPlayer flashPlayer)
		{
			return null;
		}

		public void SetCellButtonHandlerEnable(bool enable)
		{
		}
	}
}
