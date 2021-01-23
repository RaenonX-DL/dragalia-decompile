/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Button iconButton;
		public UnityEngine.UI.Text countText;
		[SerializeField]
		private Image countPlate;
		[SerializeField]
		private Image dragonCountPlate;
		[SerializeField]
		private Image weaponAmuletCountPlate;
		[Header]
		[SerializeField]
		private Graphic unionIcon;
		[Header]
		[SerializeField]
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
		[CompilerGenerated]
		private int _SkillMaxLevel_k__BackingField;
		[CompilerGenerated]
		private bool _IsShowMaxPossessionCount_k__BackingField;
		[CompilerGenerated]
		private bool _IsShowNumberOwnedOnDetail_k__BackingField;
	
		// Properties
		public Image currentCountPlate { get; }
		public Graphic mainImage { get; }
		public SkillDataElement skillData { get; set; }
		public int skillLevel { get; set; }
		public int SkillMaxLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsShowMaxPossessionCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsShowNumberOwnedOnDetail { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum CountTextDisplayType
		{
			None = 0,
			Possession = 1,
			Shop = 2,
			Custom = 3,
			Item = 4,
			Level = 5,
			Reward = 6
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__99_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _EnableDefaultClick_b__99_0();
		}
	
		// Constructors
		public CommonIcon();
		static CommonIcon();
	
		// Methods
		private void Start();
		public void SetIsInInventory(bool value);
		public virtual void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int additionalMaxLevel = 0, int limitOver = 0);
		private void SetCrestUnionIcon(int crestId);
		public void SetupUserName(string name);
		public void SetSelfKeyId(GiftType giftType, ulong keyId);
		public void SetupForEnemyPiece(int id, int count, int maxCount);
		public void SetEnable(bool enable);
		public void SetupByInBoxCharacterDragonWeapon(GiftType giftType, ulong keyId);
		public void SetEquips(ulong weaponKeyId, ulong dragonKeyId, ulong amuletKeyId1, ulong amuletKeyId2, ulong amuletKeyId3, ulong amuletKeyId4, ulong amuletKeyId5);
		public void SetEquips(PartySettingList settingList);
		public void SetEditSkill(PartySettingList partySettingList);
		public void ShowCountPlate(bool bShow);
		public void SetCountText(long countNum, CountTextDisplayType countDisplayType = CountTextDisplayType.Custom);
		public void SetCountTextAsPossession();
		public void SetCountTextAsShop(int countNum);
		public void SetCountTextAsReward(long countNum);
		public void SetCountTextColor(Color color);
		public void SetCountPlateColor(Color color);
		public void SetupBySupportData(SupportData data, IconLoader.Size size = IconLoader.Size.M);
		public void SetupByMatchingDetailData(MatchingRoomPlayerData data, int memberIndex, GiftType giftType, IconLoader.Size size = IconLoader.Size.M, int amuletNumber = 1, UnitDetailModel.AmuletDetailData amuletData = null);
		public void SetCustomOnClick(Action onClick);
		public void SetCustomOnLongPress(Action onPress);
		public void EnableDefaultClick(bool addSoundCallback);
		public void SetUnitDetailModelOnCreated(UnityAction onCreated);
		public void SetUnitDetailModelBackButtonOnClick(UnityAction onClick);
		public long GetItemPossession(out bool bShouldDisplay);
		public long GetItemPossession(int limitBreakCount = 0);
		public virtual void OnIconLongPressed();
		public void ShowDetailDialog();
		public void OnIconClicked();
		private void SetCountDisplaySetting(bool isLeft = false, bool useIcon = false);
		public void OnSkillIconPressed();
		public void OnSupportSkillIconPressed();
		private void ShowSkillDetailDialog(SkillDataElement skillData, int skillLevel, int skillMaxLevel);
		public virtual void SetGrayOutStyle(bool isGrayOut);
		public void SetGotState(bool hadGot);
		public void SetQuestResultTextSetting(IconLoader.Size size = IconLoader.Size.M);
		public void SetPopupItemQuantity(int rewardEntityQuantity);
	}
}
