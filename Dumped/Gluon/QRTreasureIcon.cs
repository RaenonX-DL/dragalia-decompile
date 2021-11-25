using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRTreasureIcon : MonoBehaviour
	{
		public enum TreasureIconType
		{
			Normal = 0,
			Rare = 1,
			SuperRare = 2,
			Raid = 3,
			TreasureTime = 4,
			RaidNormal = 5,
			Bonus = 9
		}

		[SerializeField]
		public CommonIcon icon;

		public Image[] sackIcons;

		public Image[] weaponIcons;

		public Image[] pieceIcons;

		public Image[] amuletIcons;

		public Image updatedImage;

		public Image completedImage;

		public GameObject bonusImage;

		[SerializeField]
		private RectTransform _animRoot;

		public GameObject glowFlashParent;

		public GameObject convertFlashParent;

		private const string seItemSwitch = "SE_OUT_COMMON_0026";

		private QuestResultModel.TopPageModel.RewardItemInfo info;

		private QuestResultTopPage topPage;

		private QuestWallResultTopPage topPageWall;

		private float animationDelay;

		private TreasureIconType _treasureIconType;

		private FlashPlayer openFlashPlayer;

		private FlashPlayer rareGlowFlashPlayer;

		private FlashPlayer convertToDewFlashPlayer;

		private Sequence openAnimSequence;

		[SerializeField]
		private GameObject newIcon;

		public Action<QuestResultModel.TopPageModel.RewardItemInfo> onOpen;

		private Color bonusCountTextColor;

		private const string kRareBubbleFlashObjectName = "MOT_result_rare_get";

		private const string kOverLimitBubbleFlashObjectName = "MOT_result_item_max";

		private const string kSRareBubbleFlashObjectName = "MOT_result_ultra_rare_get";

		private const string kRareGlowFlashObjectName = "MOT_icon_rare_effect_front";

		private const string kSRareGlowFlashObjectName = "MOT_icon_ultra_rare_effect_front";

		private const string iconShaderPath = "FlashToUnity/uGUI/GraphicNormalEx";

		public RectTransform animRoot => null;

		public bool isAnimCompleted
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

		public TreasureIconType treasureIconType
		{
			get
			{
				return default(TreasureIconType);
			}
			private set
			{
			}
		}

		public int rowCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static QRTreasureIcon Create(QuestResultModel.TopPageModel.RewardItemInfo info, Transform parent, float animationDelay, QuestResultTopPage topPage)
		{
			return null;
		}

		public static QRTreasureIcon Create(QuestResultModel.TopPageModel.RewardItemInfo info, Transform parent, float animationDelay, QuestWallResultTopPage topPage)
		{
			return null;
		}

		private void Start()
		{
		}

		public void SetActiveForImages()
		{
		}

		private int GetIconImageIndex()
		{
			return default(int);
		}

		public void StartAnimation()
		{
		}

		private IEnumerator WaitForAnimationDelay()
		{
			return null;
		}

		private void OnOpenCallback()
		{
		}

		public void SetAnimCompleted()
		{
		}

		public void SwitchBagToTreasureIcon()
		{
		}

		private void SwitchToNormalView()
		{
		}

		public void SkipAnimation()
		{
		}

		public void SetFlashPlayer(FlashPlayer open, FlashPlayer rareGlow, FlashPlayer convertToDew)
		{
		}

		private void SetupConvertDewFlash(FlashPlayer flashPlayer, QuestResultModel.TopPageModel.RewardItemInfo info)
		{
		}

		private void ChangeItemCount(int count)
		{
		}

		private static void ReplacePlane(FlPlane plane, Material srcMat, string name, string str)
		{
		}

		public void PlayOpenFlash()
		{
		}

		public void SetPlayOpenFlashCallback(Action action, FlMotionActionTypes type)
		{
		}

		public void PlayRareGlowFlash()
		{
		}

		public void PlayConvertToDewFlash()
		{
		}

		public void PlayBubbleFlash()
		{
		}

		private string GetBubbleFlashObjectName()
		{
			return null;
		}

		private string GetRareGlowObjectName()
		{
			return null;
		}

		public void SetBubbleFlashCallBack(Action action, FlMotionActionTypes type)
		{
		}

		public void PlayRarePopupFlashSkip()
		{
		}

		public void PlayConvertToDewFlashSkip()
		{
		}

		private void SetRarityIndex(QuestResultModel.TopPageModel.RewardItemInfo info)
		{
		}

		public QuestResultModel.TopPageModel.RewardItemInfo GetRewardItemInfo()
		{
			return null;
		}

		public bool IsPlayBalloonFlash()
		{
			return default(bool);
		}

		private bool IsPlayRareGrow()
		{
			return default(bool);
		}

		private bool IsPlayOverLimitFlash()
		{
			return default(bool);
		}

		public bool IsPlayConvertDewFlash()
		{
			return default(bool);
		}
	}
}
