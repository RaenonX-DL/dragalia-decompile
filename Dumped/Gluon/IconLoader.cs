using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public static class IconLoader
	{
		public enum Size
		{
			SS,
			S,
			M,
			L,
			Wide,
			NoFrame,
			Select,
			Header,
			Frame,
			Pager
		}

		public enum UnmatchItemIdIcon
		{
			Money,
			Stone,
			ManaPoint,
			PaidStone,
			DewPoint,
			Crystal,
			SkipTicket,
			BuildTimePoint,
			SummonPoint
		}

		public enum CrestSlotType
		{
			A_Type,
			B_Type,
			C_Type
		}

		public const string iconPathRoot = "Images/Icon/Item/";

		public const string iconPathMaterial = "Images/Icon/Item/MaterialData/";

		public const string iconPathDragonGift = "Images/Icon/Item/DragonGift/";

		public const string iconPathUseItem = "Images/Icon/Item/UseItem/";

		public const string iconPathOther = "Images/Icon/Item/Other/";

		public const string iconPathExchangeTicket = "Images/Icon/Item/ExchangeTicket/";

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

		public const string iconPathUnitType = "Images/Icon/OthersType/{0}/";

		public const string iconAmuletType = "Images/Icon/AmuletType/{0}/";

		public const string iconFormSlot = "Images/Icon/Form/{0}/";

		public const string iconUnion = "Images/Icon/Union/{0}/";

		public const string iconMedal = "Images/Icon/Medal/{0}/{1}/";

		public const string iconEnemy = "Images/Icon/Enemy/";

		private const int questIconMaterialConst = 10000;

		private static readonly string[] UnmatchItemIdIconsPath;

		private static readonly string[] UnmatchItemIdIconsLargePath;

		private static readonly string[] WeaponFormTypeIconPath;

		private static Shader iconShader;

		public static Material GetIconMaterial(GiftType type, int id, Size size = Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int limitOver = 0)
		{
			return null;
		}

		public static Material GetAbilityIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetAbilityIconMaterial(string filename, Size size = Size.M)
		{
			return null;
		}

		public static Material GetEnemyAbilityIconMaterial(string filename)
		{
			return null;
		}

		public static Material GetSkillIconMaterial(string iconName, Size size = Size.M)
		{
			return null;
		}

		public static Material GetItemIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetDragonIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetDragonIconMaterialByDragonBase(int baseId, int variationId, Size size = Size.M)
		{
			return null;
		}

		public static Material GetAmuletIconMaterial(int id, int limitBreakLevel, Size size = Size.M)
		{
			return null;
		}

		public static Material GetAmuletIconMaterialRaw(int id, Size size = Size.M, int variationId = 1)
		{
			return null;
		}

		private static Material GetAmuletIconMaterialByAmuletBase(int baseId, int variationId, Size size = Size.M)
		{
			return null;
		}

		public static void GetAmuletIconMaterialAsync(int id, int limitBreakLevel, Size size = Size.M, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static Material GetBlankAmuletIconMaterial(int slotIndex)
		{
			return null;
		}

		public static void GetBlankAmuletIconMaterialAsync(int slotIndex, Action<Material> onCompleteAction)
		{
		}

		public static Material GetCrestIconMaterial(int id, int limitBreakLevel, Size size = Size.M)
		{
			return null;
		}

		public static void GetCrestIconMaterialAsync(int id, int limitBreakLevel, Size size = Size.M, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static void GetDragonIconMaterialAsync(int id, Size size = Size.M, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static Material GetBlankCharacterIconMaterial()
		{
			return null;
		}

		public static void GetBlankCharacterIconMaterial(Action<Material> onCompleteAction)
		{
		}

		public static Material GetBlankDragonIconMaterial(bool isWide = false)
		{
			return null;
		}

		public static void GetBlankDragonIconMaterialAsync(Action<Material> onCompleteAction, bool isWide = false)
		{
		}

		public static Material GetUnionIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		private static Material LoadMaterial(string path)
		{
			return null;
		}

		private static void LoadMaterialAsync(string path, Action<Material> onCompleteAction)
		{
		}

		public static Material GetBlankStampIconMaterial()
		{
			return null;
		}

		public static Material GetBlankCraftWeaponTypeIconMaterial(WeaponType type)
		{
			return null;
		}

		public static Material GetStampIconMaterial(int id, bool withFrame = false, Size size = Size.M)
		{
			return null;
		}

		public static Material GetStampIconMaterial(string name, bool withFrame = false, Size size = Size.M)
		{
			return null;
		}

		public static Material GetMapIconMaterial(int id)
		{
			return null;
		}

		public static void GetMapIconMaterialAsync(int id, [Optional] Action<Material> onLoad)
		{
		}

		public static Material GetQuestIconMaterial(int id)
		{
			return null;
		}

		public static void GetQuestIconMaterialAsync(int id, Action<Material> onLoad)
		{
		}

		public static Material GetUnmatchItemIdIconMaterial(UnmatchItemIdIcon category, Size size = Size.M)
		{
			return null;
		}

		public static Material GetBRSkinIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetCharactorIconMaterial(int id, Size size = Size.M, int rarity = 3)
		{
			return null;
		}

		public static Material GetCharactorIconMaterialByCharaBase(int baseId, int variationId, Size size = Size.M, int rarity = 4)
		{
			return null;
		}

		public static void GetCharacterIconMaterialAsync(int id, Size size = Size.M, int rarity = 3, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static void GetCharacterIconMaterialAsyncByCharaBase(int baseId, int variationId, Size size = Size.M, int rarity = 4, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static Material GetWeaponIconMaterial(int weaponBodyId, Size size = Size.M, int limitOver = 0)
		{
			return null;
		}

		public static Material GetWeaponIconMaterialFromSkinId(int weaponSkinId, Size size = Size.M)
		{
			return null;
		}

		public static void GetWeaponIconMaterialAsync(int weaponBodyId, Size size = Size.M, int limitOverCount = 0, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static void GetWeaponIconMaterialAsyncFromSkinId(int weaponSkinId, Size size = Size.M, [Optional] Action<Material> onCompleteAction)
		{
		}

		public static Material GetWeaponTypeIconMaterialAsCopy(WeaponType type, Size size = Size.M)
		{
			return null;
		}

		public static Material GetWeaponTypeIconMaterial(WeaponType type, Size size = Size.M)
		{
			return null;
		}

		public static Material GetMaterialIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static string GetMaterialPath(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetMaterialIcon(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetFortAssetIconMaterial(int id, Size size = Size.M, int level = 1)
		{
			return null;
		}

		public static Material GetDragonGiftIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetEventIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetAstralItemIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		private static Material _GetIconMaterial(string path)
		{
			return null;
		}

		public static Material GetExchangeTicketIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetOtherIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetTwoStepLotIconMaterial(string id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetLotteryLetterIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetGatherItemIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetSimpleEventItemIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetRarityIconMaterial(Rarity rarity, int index = 1, GiftType giftType = GiftType.CHARA)
		{
			return null;
		}

		public static Material GetPartyRarityIconMaterial(CommonRarity rarity)
		{
			return null;
		}

		public static Material GetDummyIconMaterial()
		{
			return null;
		}

		public static Material GetElementMaterialAsCopy(ElementalType elementalType, Size size = Size.M)
		{
			return null;
		}

		public static Material GetElementMaterial(ElementalType elementalType, Size size = Size.M)
		{
			return null;
		}

		public static Material GetFramePlusElementMaterial(ElementalType elementalType, Size size = Size.M)
		{
			return null;
		}

		public static Material GetProfileMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetCampaignMaterial(CampaignDataWrapper data, Size size = Size.M)
		{
			return null;
		}

		public static Material GetCampaignMaterial(CampaignType type, Size size = Size.M)
		{
			return null;
		}

		public static Material GetSackDecoration(int decorationType, int index)
		{
			return null;
		}

		public static Material GetStatus(AbnormalStatusType type)
		{
			return null;
		}

		public static Material GetVoidEnemyIcon(int id)
		{
			return null;
		}

		public static Material GetRate(int type)
		{
			return null;
		}

		public static Material GetVoidEnemyIcon(string name)
		{
			return null;
		}

		public static Material GetGuildEmblemIconMaterial(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetSeasonVoiceIconMaterial(string voiceIconImage)
		{
			return null;
		}

		public static Material GetManaCircle2DIcon(string name)
		{
			return null;
		}

		public static Material GetManaCircle2DIcon(ManaCircle2DCirclePieceObject.PieceIconType type)
		{
			return null;
		}

		public static Material GetWeaponSeriesIcon(string name)
		{
			return null;
		}

		public static Material GetIconAbilityCrestType(int type, Size size = Size.M)
		{
			return null;
		}

		public static Material GetIconWeaponSlot(CrestSlotType type, Size size = Size.M)
		{
			return null;
		}

		public static Material GetIconUnion(int id, Size size = Size.M)
		{
			return null;
		}

		public static Material GetUnionTypeIcon(UnitType unitType, Size size = Size.M)
		{
			return null;
		}

		public static Material GetMedalIcon(int id, bool disable, Size size = Size.M)
		{
			return null;
		}

		public static Material GetEnemyIcon(int questScoringEnemyId)
		{
			return null;
		}
	}
}
