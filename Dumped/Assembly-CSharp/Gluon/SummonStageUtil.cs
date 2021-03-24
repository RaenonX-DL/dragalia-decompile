/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageUtil
	{
		// Fields
		private static SummonStageUtil instance;
		public const string cutinPath = "Images/OutGame/Summon/Stage/Cutin/";
		public const string cutinAlphaPathSuffix = "_alpha";
		private const string cutinCharacterReplacePathTemplate = "Images/OutGame/Summon/Stage/Cutin/Character/summon_cutin_c{0:D6}_{1:D2}_r{2:D2}";
		private const string cutinDragonReplacePathTemplate = "Images/OutGame/Summon/Stage/Cutin/Dragon/summon_cutin_d{0:D6}_{1:D2}";
		public List<UnitMasterElement> unitMasterElementList;
	
		// Properties
		public static SummonStageUtil Instance { get; }
	
		// Nested types
		public enum SummonWeaponCategory
		{
			NONE = 0,
			SWD = 1,
			KAT = 2,
			DAG = 3,
			AXE = 4,
			LAN = 5,
			BOW = 6,
			ROD = 7,
			CAN = 8,
			GUN = 9,
			DRG = 10,
			MON = 11,
			AMU_R03 = 12,
			AMU_R04 = 13,
			AMU_R05 = 14
		}
	
		public class UnitMasterElement
		{
			// Fields
			public CharaDataElement charaMasterData;
			public DragonDataElement dragonMasterData;
			public WeaponBodyElement weaponMasterData;
			public WeaponSkinElement weaponSkinMasterData;
			public AbilityCrestElement amuletMasterData;
	
			// Constructors
			public UnitMasterElement();
		}
	
		public class FunctionEntryLog : IDisposable
		{
			// Constructors
			public FunctionEntryLog(string path = "", int index = -1);
	
			// Methods
			public void Dispose();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public SummonStageUtil __4__this;
			public bool expandBounds;
			public Action<GameObject, int> onLoaded;
			public int index;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _LoadAndInstantiateModelAsync_b__0(GameObject go);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Action<RuntimeAnimatorController, int> onLoaded;
			public int index;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _LoadRuntimeAnimatorControllerAsync_b__0(RuntimeAnimatorController rc);
		}
	
		// Constructors
		private SummonStageUtil();
		static SummonStageUtil();
	
		// Methods
		public static void DeleteInstance();
		public GameObject SummonInstantiateForSkinnedMesh(GameObject original, bool expandBounds = false);
		public void LoadAndInstantiateModelAsync(string path, Action<GameObject, int> onLoaded, int index, bool expandBounds = false);
		public void LoadRuntimeAnimatorControllerAsync(string path, Action<RuntimeAnimatorController, int> onLoaded, int index);
		public EffectObject LoadEffectByName(string effectName, bool attachToWorld3dNode = true);
		public void SetEffectVisibility(EffectObject eff, bool isVisible);
		public string GetCharaModelName(int baseId, int variationId);
		public string GetDragonModelName(int baseId, int variationId);
		public string GetWeaponModelName(int baseId, int variationId);
		public void InitUnitMasterDataList();
		public WeaponType GetCharaWeaponType(int index);
		public ElementalType GetCharaElementalType(int index);
		public Rarity GetRarity(int index, bool isFromMaster = false);
		public bool IsMoon(int index);
		public void GetCutinReplaceTexture(int index, out Texture colorTex, out Texture alphaTex, out Material outMat);
		public string GetUnitName(int index, bool originalChara = false);
		public GiftType GetGiftType(int index);
		public bool IsNewCharaOrAwakening(int index);
		public void PlayEffect(EffectObject effectObject);
		public SummonWeaponCategory GetWeaponCategory(int index);
	}
}
