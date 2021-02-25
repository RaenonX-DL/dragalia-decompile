/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class IconLoader
	{
		// Fields
		public const string iconPathRoot = "Images/Icon/Item/";
		public const string iconPathMaterial = "Images/Icon/Item/MaterialData/";
		public const string iconPathDragonGift = "Images/Icon/Item/DragonGift/";
		public const string iconPathUseItem = "Images/Icon/Item/UseItem/";
		public const string iconPathOther = "Images/Icon/Item/Other/";
		public const string iconPathEventItem = "Images/Icon/Item/Event/";
		public const string iconPathFortAsset = "Images/Icon/Item/FortAsset/";
		public const string iconPathAstralItem = "Images/Icon/Item/Astral/";
		public const string iconPathDefault = "Images/Icon/Others/DummyIcon";
		public const string iconElementPath = "Images/Icon/Element/";
		public const string iconPathRarity = "Images/Icon/Rarity/";
		public const string iconPathWeaponType = "Images/Icon/WeaponType/";
		public const string iconPathProfile = "Images/Icon/Profile/";
		public const string iconPathAbility = "Images/Icon/Ability/";
		public const string iconPathEnemyAbility = "Images/Icon/EnemyAbility/";
		public const string iconPathSkill = "Images/Icon/Skill/";
		public const string iconPathStamp = "Images/Icon/Stamp/{0}/";
		public const string iconPathStampWithFrame = "Images/Icon/Stamp/{0}/Framed/";
		public const string iconPathMap = "Images/Icon/MapIcon/";
		public const string iconPathQuest = "Images/Icon/Quest_Preview/";
		public const string iconPathSackDecoration = "Images/Icon/SackDecoration/{0}/";
		public const string iconPathStatus = "Images/Icon/Status/";
		public const string iconPathRate = "Images/Icon/Rate/";
		public const string iconPathVoidEnemy = "Images/Icon/CraftSeries/";
		public const string iconPathGuildEmblem = "Images/Icon/GuildEmblem/{0}/{1}";
		public const string iconPathSeasonVoice = "Images/Icon/SeasonVoice/";
		public const string iconLotteryLetter = "Images/Icon/Item/LotteryTicket/";
		public const string iconGatherItem = "Images/Icon/Item/Gather/";
		public const string iconSimpleEventItem = "Images/Icon/Item/Event/";
		public const string iconManaCirclePiece = "Images/Icon/ManaCircle/";
		public const string iconPathWeaponSeries = "Images/Icon/WeaponSeries/";
		public const string iconPathUnion = "Images/Icon/Union/";
		public const string iconAmuletType = "Images/Icon/AmuletType/{0}/";
		public const string iconFormSlot = "Images/Icon/Form/{0}/";
		public const string iconUnion = "Images/Icon/Union/{0}/";
		private const int questIconMaterialConst = 10000;
		private static readonly string[] UnmatchItemIdIconsPath;
		private static readonly string[] UnmatchItemIdIconsLargePath;
		private static readonly string[] WeaponFormTypeIconPath;
		private static Shader iconShader;
	
		// Nested types
		public enum Size
		{
			SS = 0,
			S = 1,
			M = 2,
			L = 3,
			Wide = 4,
			NoFrame = 5,
			Select = 6,
			Header = 7,
			Frame = 8,
			Pager = 9
		}
	
		public enum UnmatchItemIdIcon
		{
			Money = 0,
			Stone = 1,
			ManaPoint = 2,
			PaidStone = 3,
			DewPoint = 4,
			Crystal = 5,
			SkipTicket = 6,
			BuildTimePoint = 7,
			SummonPoint = 8
		}
	
		public enum CrestSlotType
		{
			A_Type = 0,
			B_Type = 1,
			C_Type = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _GetAmuletIconMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _GetBlankAmuletIconMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _GetCrestIconMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _GetDragonIconMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _GetBlankCharacterIconMaterial_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _GetBlankDragonIconMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _LoadMaterialAsync_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _GetCharacterIconMaterialAsyncByCharaBase_b__0(Material mat);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action<Material> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _GetWeaponIconMaterialAsyncFromSkinId_b__0(Material mat);
		}
	
		// Constructors
		static IconLoader();
	
		// Methods
		public static Material GetIconMaterial(GiftType type, int id, Size size = Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int limitOver = 0);
		public static Material GetAbilityIconMaterial(int id, Size size = Size.M);
		public static Material GetAbilityIconMaterial(string filename, Size size = Size.M);
		public static Material GetEnemyAbilityIconMaterial(string filename);
		public static Material GetSkillIconMaterial(string iconName, Size size = Size.M);
		public static Material GetItemIconMaterial(int id, Size size = Size.M);
		public static Material GetDragonIconMaterial(int id, Size size = Size.M);
		public static Material GetDragonIconMaterialByDragonBase(int baseId, int variationId, Size size = Size.M);
		public static Material GetAmuletIconMaterial(int id, int limitBreakLevel, Size size = Size.M);
		public static Material GetAmuletIconMaterialRaw(int id, Size size = Size.M, int variationId = 1);
		private static Material GetAmuletIconMaterialByAmuletBase(int baseId, int variationId, Size size = Size.M);
		public static void GetAmuletIconMaterialAsync(int id, int limitBreakLevel, Size size = Size.M, Action<Material> onCompleteAction = null);
		public static Material GetBlankAmuletIconMaterial(int slotIndex);
		public static void GetBlankAmuletIconMaterialAsync(int slotIndex, Action<Material> onCompleteAction);
		public static Material GetCrestIconMaterial(int id, int limitBreakLevel, Size size = Size.M);
		public static void GetCrestIconMaterialAsync(int id, int limitBreakLevel, Size size = Size.M, Action<Material> onCompleteAction = null);
		public static void GetDragonIconMaterialAsync(int id, Size size = Size.M, Action<Material> onCompleteAction = null);
		public static Material GetBlankCharacterIconMaterial();
		public static void GetBlankCharacterIconMaterial(Action<Material> onCompleteAction);
		public static Material GetBlankDragonIconMaterial(bool isWide = false);
		public static void GetBlankDragonIconMaterialAsync(Action<Material> onCompleteAction, bool isWide = false);
		public static Material GetUnionIconMaterial(int id, Size size = Size.M);
		private static Material LoadMaterial(string path);
		private static void LoadMaterialAsync(string path, Action<Material> onCompleteAction);
		public static Material GetBlankStampIconMaterial();
		public static Material GetBlankCraftWeaponTypeIconMaterial(WeaponType type);
		public static Material GetStampIconMaterial(int id, bool withFrame = false, Size size = Size.M);
		public static Material GetMapIconMaterial(int id);
		public static void GetMapIconMaterialAsync(int id, Action<Material> onLoad = null);
		public static Material GetQuestIconMaterial(int id);
		public static void GetQuestIconMaterialAsync(int id, Action<Material> onLoad);
		public static Material GetUnmatchItemIdIconMaterial(UnmatchItemIdIcon category, Size size = Size.M);
		public static Material GetBRSkinIconMaterial(int id, Size size = Size.M);
		public static Material GetCharactorIconMaterial(int id, Size size = Size.M, int rarity = 3);
		public static Material GetCharactorIconMaterialByCharaBase(int baseId, int variationId, Size size = Size.M, int rarity = 4);
		public static void GetCharacterIconMaterialAsync(int id, Size size = Size.M, int rarity = 3, Action<Material> onCompleteAction = null);
		public static void GetCharacterIconMaterialAsyncByCharaBase(int baseId, int variationId, Size size = Size.M, int rarity = 4, Action<Material> onCompleteAction = null);
		public static Material GetWeaponIconMaterial(int weaponBodyId, Size size = Size.M, int limitOver = 0);
		public static Material GetWeaponIconMaterialFromSkinId(int weaponSkinId, Size size = Size.M);
		public static void GetWeaponIconMaterialAsync(int weaponBodyId, Size size = Size.M, int limitOverCount = 0, Action<Material> onCompleteAction = null);
		public static void GetWeaponIconMaterialAsyncFromSkinId(int weaponSkinId, Size size = Size.M, Action<Material> onCompleteAction = null);
		public static Material GetWeaponTypeIconMaterialAsCopy(WeaponType type, Size size = Size.M);
		public static Material GetWeaponTypeIconMaterial(WeaponType type, Size size = Size.M);
		public static Material GetMaterialIconMaterial(int id, Size size = Size.M);
		public static string GetMaterialPath(int id, Size size = Size.M);
		public static Material GetMaterialIcon(int id, Size size = Size.M);
		public static Material GetFortAssetIconMaterial(int id, Size size = Size.M, int level = 1);
		public static Material GetDragonGiftIconMaterial(int id, Size size = Size.M);
		public static Material GetEventIconMaterial(int id, Size size = Size.M);
		public static Material GetAstralItemIconMaterial(int id, Size size = Size.M);
		private static Material _GetIconMaterial(string path);
		public static Material GetOtherIconMaterial(int id, Size size = Size.M);
		public static Material GetTwoStepLotIconMaterial(string id, Size size = Size.M);
		public static Material GetLotteryLetterIconMaterial(int id, Size size = Size.M);
		public static Material GetGatherItemIconMaterial(int id, Size size = Size.M);
		public static Material GetSimpleEventItemIconMaterial(int id, Size size = Size.M);
		public static Material GetRarityIconMaterial(Rarity rarity, int index = 1, GiftType giftType = GiftType.CHARA);
		public static Material GetPartyRarityIconMaterial(CommonRarity rarity);
		public static Material GetDummyIconMaterial();
		public static Material GetElementMaterialAsCopy(ElementalType elementalType, Size size = Size.M);
		public static Material GetElementMaterial(ElementalType elementalType, Size size = Size.M);
		public static Material GetProfileMaterial(int id, Size size = Size.M);
		public static Material GetCampaignMaterial(CampaignDataWrapper data, Size size = Size.M);
		public static Material GetCampaignMaterial(CampaignType type, Size size = Size.M);
		public static Material GetSackDecoration(int decorationType, int index);
		public static Material GetStatus(AbnormalStatusType type);
		public static Material GetVoidEnemyIcon(int id);
		public static Material GetRate(int type);
		public static Material GetVoidEnemyIcon(string name);
		public static Material GetGuildEmblemIconMaterial(int id, Size size = Size.M);
		public static Material GetSeasonVoiceIconMaterial(string voiceIconImage);
		public static Material GetManaCircle2DIcon(string name);
		public static Material GetManaCircle2DIcon(ManaCircle2DCirclePieceObject.PieceIconType type);
		public static Material GetWeaponSeriesIcon(string name);
		public static Material GetIconAbilityCrestType(int type, Size size = Size.M);
		public static Material GetIconWeaponSlot(CrestSlotType type, Size size = Size.M);
		public static Material GetIconUnion(int id, Size size = Size.M);
	}
}
