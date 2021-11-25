using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class SummonStageUtil
	{
		public enum SummonWeaponCategory
		{
			NONE,
			SWD,
			KAT,
			DAG,
			AXE,
			LAN,
			BOW,
			ROD,
			CAN,
			GUN,
			DRG,
			MON,
			AMU_R03,
			AMU_R04,
			AMU_R05
		}

		public class UnitMasterElement
		{
			public CharaDataElement charaMasterData;

			public DragonDataElement dragonMasterData;

			public WeaponBodyElement weaponMasterData;

			public WeaponSkinElement weaponSkinMasterData;

			public AbilityCrestElement amuletMasterData;
		}

		public class FunctionEntryLog : IDisposable
		{
			public FunctionEntryLog(string path = "", int index = -1)
			{
			}

			public void Dispose()
			{
			}
		}

		private static SummonStageUtil instance;

		public const string cutinPath = "Images/OutGame/Summon/Stage/Cutin/";

		public const string cutinAlphaPathSuffix = "_alpha";

		private const string cutinCharacterReplacePathTemplate = "Images/OutGame/Summon/Stage/Cutin/Character/summon_cutin_c{0:D6}_{1:D2}_r{2:D2}";

		private const string cutinDragonReplacePathTemplate = "Images/OutGame/Summon/Stage/Cutin/Dragon/summon_cutin_d{0:D6}_{1:D2}";

		public List<UnitMasterElement> unitMasterElementList;

		public static SummonStageUtil Instance => null;

		public static void DeleteInstance()
		{
		}

		private SummonStageUtil()
		{
		}

		static SummonStageUtil()
		{
		}

		public GameObject SummonInstantiateForSkinnedMesh(GameObject original, bool expandBounds = false)
		{
			return null;
		}

		public void LoadAndInstantiateModelAsync(string path, Action<GameObject, int> onLoaded, int index, bool expandBounds = false)
		{
		}

		public void LoadRuntimeAnimatorControllerAsync(string path, Action<RuntimeAnimatorController, int> onLoaded, int index)
		{
		}

		public EffectObject LoadEffectByName(string effectName, bool attachToWorld3dNode = true)
		{
			return null;
		}

		public void SetEffectVisibility(EffectObject eff, bool isVisible)
		{
		}

		public string GetCharaModelName(int baseId, int variationId)
		{
			return null;
		}

		public string GetDragonModelName(int baseId, int variationId)
		{
			return null;
		}

		public string GetWeaponModelName(int baseId, int variationId)
		{
			return null;
		}

		public void InitUnitMasterDataList()
		{
		}

		public WeaponType GetCharaWeaponType(int index)
		{
			return default(WeaponType);
		}

		public ElementalType GetCharaElementalType(int index)
		{
			return default(ElementalType);
		}

		public Rarity GetRarity(int index, bool isFromMaster = false)
		{
			return default(Rarity);
		}

		public bool IsMoon(int index)
		{
			return default(bool);
		}

		public void GetCutinReplaceTexture(int index, out Texture colorTex, out Texture alphaTex, out Material outMat)
		{
		}

		public string GetUnitName(int index, bool originalChara = false)
		{
			return null;
		}

		public GiftType GetGiftType(int index)
		{
			return default(GiftType);
		}

		public bool IsNewCharaOrAwakening(int index)
		{
			return default(bool);
		}

		public void PlayEffect(EffectObject effectObject)
		{
		}

		public SummonWeaponCategory GetWeaponCategory(int index)
		{
			return default(SummonWeaponCategory);
		}
	}
}
