/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManagedFacilityModel
	{
		// Fields
		[CompilerGenerated]
		private List<ManagedFacility> _managedFacilityList_k__BackingField;
	
		// Properties
		public List<ManagedFacility> managedFacilityList { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class ManagedFacility
		{
			// Fields
			[CompilerGenerated]
			private List<Facility> _facilityList_k__BackingField;
			[CompilerGenerated]
			private bool _isStored_k__BackingField;
			private const int defaultFacilityLevel = 1;
			[CompilerGenerated]
			private ElementalType _firstElementalBonus_k__BackingField;
			[CompilerGenerated]
			private ElementalType _secondElementalBonus_k__BackingField;
			[CompilerGenerated]
			private int _firstWeaponTypeBonus_k__BackingField;
			[CompilerGenerated]
			private int _secondWeaponTypeBonus_k__BackingField;
	
			// Properties
			public List<Facility> facilityList { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool isStored { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public ElementalType firstElementalBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public ElementalType secondElementalBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int firstWeaponTypeBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int secondWeaponTypeBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Predicate<Facility> __9__35_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _IsNew_b__35_0(Facility facility);
			}
	
			// Constructors
			public ManagedFacility(bool isStored);
	
			// Methods
			public FortPlantDetailElement GetDetailData();
			public FortPlantDataElement GetPlantData();
			public int GetLevel();
			public void AddFacility(Facility facility);
			public void RemoveFacility(Facility facility);
			private void SetElementalBonus();
			private void SetWeaponTypeBonus();
			public float SelectHp();
			public float SelectAtk();
			public bool IsNew();
			public bool IsMaxLevel();
			public bool IsUpgradeable();
			public bool IsLackingMaterialsForUpgrade();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<ManagedFacility> __9__6_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ClearAllStoredFaciliy_b__6_0(ManagedFacility managedFacility);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Facility removeFacility;
			public Func<Facility, bool> __9__0;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _RemoveFacility_b__0(Facility facility);
		}
	
		// Constructors
		public ManagedFacilityModel();
	
		// Methods
		public void ClearAllStoredFaciliy();
		public int GetAllStoredFacilityCount();
		public int GetStoredFacilityCount(int plantId);
		public int GetStoredFacilityCount(FortPlantType type);
		public int GetStoredFacilityTotalLevel();
		public List<ManagedFacility> GetFacilityList(FortMenuGroupType type);
		public void AddFacility(Facility facility, bool isStored);
		public void RemoveFacility(Facility removeFacility, bool isStored);
		public void MoveToStoreHouse(Facility facility);
		public void RemoveFromStoreHouse(Facility facility);
		public bool HasNewFacility(FortMenuGroupType groupType);
		public void SetNewFlag(ulong buildId, bool isNew);
		public void UpdateFacility(Facility previousFacility, Facility nextFacility);
		public bool ExistUpgradeableFacility(FortMenuGroupType type);
	}
}
