using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public static class PartyUIUtility
	{
		public static int GetAbility1KeyId(CharaList character, CharaDataElement masterCharaData)
		{
			return default(int);
		}

		public static int GetAbility2KeyId(CharaList character, CharaDataElement masterCharaData)
		{
			return default(int);
		}

		public static int GetAbility3KeyId(CharaList character, CharaDataElement masterCharaData)
		{
			return default(int);
		}

		public static int GetAbility1KeyId(WeaponDataElement masterWeaponData)
		{
			return default(int);
		}

		public static int GetAbility2KeyId(WeaponDataElement masterDragonData)
		{
			return default(int);
		}

		public static void SetRarityStar(Rarity rarity, GameObject[] rarityIcons)
		{
		}

		public static void SetCrestIconAsync(int masterId, int limitBreakCount, int slotIndex, IconLoader.Size iconSize, Image iconImage, Image plusIcon)
		{
		}

		public static void ShowDragonDetail(int characterIndex)
		{
		}

		public static void ShowWeaponDetail(int characterIndex)
		{
		}

		public static void ShowCrestDetail(int characterIndex, int crestIndex)
		{
		}

		public static void ShowTalismanDetail(int characterIndex)
		{
		}

		public static void ShowSkill3Detail(int charactorIndex)
		{
		}

		public static void ShowSkill3DetailOrderParty(int characterIndex)
		{
		}

		public static void ShowSkill4Detail(int charactorIndex)
		{
		}

		public static void AdjustExitAnimationOffset(UIAnimationInnerMove animationBase, UIAnimationSetting animationSetting, float offsetY)
		{
		}

		public static bool HasEquipSkill(int charaId, bool isCheckAvailable = false)
		{
			return default(bool);
		}

		public static int GetDefaultSkill3CharaId(int targetIndexInParty)
		{
			return default(int);
		}

		public static int GetDefaultSkill4CharaId(int targetIndexInParty)
		{
			return default(int);
		}

		public static int GetDefaultSkill3CharaId(PartySettingList partySettingList)
		{
			return default(int);
		}

		public static int GetDefaultSkill4CharaId(PartySettingList partySettingList)
		{
			return default(int);
		}
	}
}
