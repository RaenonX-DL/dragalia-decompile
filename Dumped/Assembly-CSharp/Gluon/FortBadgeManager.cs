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
	public class FortBadgeManager
	{
		// Fields
		private List<int> tempNotNewFacilities;
		private List<Facility> buildList;
		private bool checkedManagedFacility;
		private bool hasCanLevelUpFacilityInManagedFacility;
		private bool checkedBuildList;
		private bool hasNewItemInBuildList;
		private static FortBadgeManager instance;
		[CompilerGenerated]
		private bool _hasNewProductionFacility_k__BackingField;
		[CompilerGenerated]
		private bool _hasNewCharaBoostFacility_k__BackingField;
		[CompilerGenerated]
		private bool _hasNewDecorationFacility_k__BackingField;
		private static int fortLastIncomeTime;
		private static DateTime fortCountStartTime;
	
		// Properties
		public bool hasNewProductionFacility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasNewCharaBoostFacility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasNewDecorationFacility { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static FortBadgeManager Instance { get; }
	
		// Constructors
		public FortBadgeManager();
		static FortBadgeManager();
	
		// Methods
		public void Init();
		public void Reset();
		public bool HasNewItemInFooter();
		public bool HasNewItemInFort();
		public bool IsDisplayFortBadge();
		public bool HasNewItemInManagedFacility();
		public bool NeedShowBadgeInManagedFacility();
		public bool IsOnFortInitialTutorial();
		private bool IsExistCompletedTent();
		private bool IsHoneyDrinkMax();
		private int GetFortLastIncomeTime();
		public bool HasNewItemInBuildDialog();
		public bool HasDragonContactFreeGift();
		public bool HasNewFacility(FortMenuGroupType groupType);
		private bool IsNewFacility(FortPlantDataElement plantElement, FortMenuGroupType groupType);
		public bool IsNewFacility(Facility facility);
		public void ClearFacilityNotNewList();
		public void SetFacilityNotNew(List<Facility> facilities);
		public void RegistFacilityNotNewList(Action onSuccess);
		private int GetFacilityCount(int plantId);
		private void InitBuildList();
	}
}
