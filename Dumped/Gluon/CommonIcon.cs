using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIcon : MonoBehaviour
	{
		public enum CountTextDisplayType
		{
			None,
			Possession,
			Shop,
			Custom,
			Item,
			Level,
			Reward
		}

		[SerializeField]
		public Button iconButton;

		public Text countText;

		[SerializeField]
		private Text countTextPrefix;

		[SerializeField]
		private Image countPlate;

		[SerializeField]
		private Image dragonCountPlate;

		[SerializeField]
		private Image weaponAmuletCountPlate;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u0093ã\u0083ªã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083¬ã\u0082¹ã\u0083\u0088")]
		private Graphic unionIcon;

		[SerializeField]
		[Header("äº¤æ\u008f\u009bæ\u0089\u0080ã\u0081§å\u0085¥æ\u0089\u008bå\u008f\u00afè\u0083½ï¼\u009f")]
		public bool canTrade;

		[HideInInspector]
		public GiftType giftType;

		[HideInInspector]
		public int id;

		[HideInInspector]
		public long displayCountNum;

		private int level;

		private int limitBreakCount;

		private int limitOverCount;

		private Rarity rarity;

		private int additionalMaxLevel;

		private ulong selfKeyId;

		private ulong selfEquipWeaponKeyId;

		private ulong selfEquipDragonKeyId;

		private ulong selfEquipAmuletKeyId1;

		private ulong selfEquipAmuletKeyId2;

		private ulong selfEquipAmuletKeyId3;

		private ulong selfEquipAmuletKeyId4;

		private ulong selfEquipAmuletKeyId5;

		private ulong selfEquipAmuletKeyId6;

		private ulong selfEquipAmuletKeyId7;

		private bool shouldDisplayEquip;

		private bool isSetKeyId;

		private PartySettingList partySettingList;

		private SupportData supportData;

		private MatchingRoomPlayerData matchingData;

		private int matchingMemberIndex;

		private int matchingAmuletNumber;

		private Action onCustomClicked;

		private Action onCustomLongPressed;

		private UnityAction onUnitDetailModelCreated;

		private UnityAction onUnitDetailModelBackButtonClicked;

		private bool isInInventory;

		private string userName;

		private Graphic _mainImage;

		private int popupItemQuantity;

		private bool isMaterialChanged;

		private Image gotImage;

		[SerializeField]
		private Color gotColor;

		private static readonly Color defaultCountPlateColor;

		private static readonly Vector2 defaultCountPlateSizeBottom;

		private static readonly Vector2 defaultCountPlatePosBottom;

		private static readonly Vector2 defaultCountPlateSizeLeft;

		private static readonly Vector2 defaultCountPlatePosLeft;

		private static readonly Vector2 defaultPivot;

		private const int CountTextFontSize = 18;

		private const int CountTextFontSizeL = 22;

		private readonly Vector2 defaultCountPlateSizeL;

		private readonly Vector2 defaultCountPlatePosL;

		private SkillDataElement _skillData;

		private int _skillLevel;

		public Image currentCountPlate => null;

		public Graphic mainImage => null;

		public SkillDataElement skillData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int skillLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int SkillMaxLevel
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

		public bool IsShowMaxPossessionCount
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

		public bool IsShowNumberOwnedOnDetail
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

		public bool IsUseSkinMaterial
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

		private void Start()
		{
		}

		public void SetIsInInventory(bool value)
		{
		}

		public virtual void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int additionalMaxLevel = 0, int limitOver = 0)
		{
		}

		private void SetCrestUnionIcon(int crestId)
		{
		}

		public void SetupUserName(string name)
		{
		}

		public void SetSelfKeyId(GiftType giftType, ulong keyId)
		{
		}

		public void SetupForEnemyPiece(int id, int count, int maxCount)
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public void SetupByInBoxCharacterDragonWeapon(GiftType giftType, ulong keyId)
		{
		}

		public void SetEquips(ulong weaponKeyId, ulong dragonKeyId, ulong amuletKeyId1, ulong amuletKeyId2, ulong amuletKeyId3, ulong amuletKeyId4, ulong amuletKeyId5, ulong amuletKeyId6, ulong amuletKeyId7)
		{
		}

		public void SetEquips(PartySettingList settingList)
		{
		}

		public void SetEditSkill(PartySettingList partySettingList)
		{
		}

		public void ShowCountPlate(bool bShow)
		{
		}

		public void SetCountText(long countNum, CountTextDisplayType countDisplayType = CountTextDisplayType.Custom)
		{
		}

		public void SetCountTextAsPossession()
		{
		}

		public void SetCountTextAsShop(int countNum)
		{
		}

		public void SetCountTextAsReward(long countNum)
		{
		}

		public void SetCountTextColor(Color color)
		{
		}

		public void SetCountPlateColor(Color color)
		{
		}

		public void SetupBySupportData(SupportData data, IconLoader.Size size = IconLoader.Size.M)
		{
		}

		public void SetupByMatchingDetailData(MatchingRoomPlayerData data, int memberIndex, GiftType giftType, IconLoader.Size size = IconLoader.Size.M, int amuletNumber = 1, [Optional] UnitDetailModel.AmuletDetailData amuletData)
		{
		}

		public void SetCustomOnClick(Action onClick)
		{
		}

		public void SetCustomOnLongPress(Action onPress)
		{
		}

		public void EnableDefaultClick(bool addSoundCallback)
		{
		}

		public void SetUnitDetailModelOnCreated(UnityAction onCreated)
		{
		}

		public void SetUnitDetailModelBackButtonOnClick(UnityAction onClick)
		{
		}

		public long GetItemPossession(out bool bShouldDisplay)
		{
			return default(long);
		}

		public long GetItemPossession(int limitBreakCount = 0)
		{
			return default(long);
		}

		public virtual void OnIconLongPressed()
		{
		}

		public void ShowDetailDialog()
		{
		}

		public void OnIconClicked()
		{
		}

		private void SetCountDisplaySetting(bool isLeft = false, bool useIcon = false)
		{
		}

		public void OnSkillIconPressed()
		{
		}

		public void OnSupportSkillIconPressed()
		{
		}

		private void ShowSkillDetailDialog(SkillDataElement skillData, int skillLevel, int skillMaxLevel)
		{
		}

		public virtual void SetGrayOutStyle(bool isGrayOut)
		{
		}

		public void SetGotState(bool hadGot)
		{
		}

		public void SetQuestResultTextSetting(IconLoader.Size size = IconLoader.Size.M)
		{
		}

		public void SetPopupItemQuantity(int rewardEntityQuantity)
		{
		}
	}
}
