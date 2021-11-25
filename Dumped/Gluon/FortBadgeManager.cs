using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class FortBadgeManager
	{
		private List<int> tempNotNewFacilities;

		private List<Facility> buildList;

		private bool checkedManagedFacility;

		private bool hasCanLevelUpFacilityInManagedFacility;

		private bool checkedBuildList;

		private bool hasNewItemInBuildList;

		private static FortBadgeManager instance;

		private static int fortLastIncomeTime;

		private static DateTime fortCountStartTime;

		public bool hasNewProductionFacility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool hasNewCharaBoostFacility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool hasNewDecorationFacility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static FortBadgeManager Instance => null;

		public void Init()
		{
		}

		public void Reset()
		{
		}

		public bool HasNewItemInFooter()
		{
			return default(bool);
		}

		public bool HasNewItemInFort()
		{
			return default(bool);
		}

		public bool IsDisplayFortBadge()
		{
			return default(bool);
		}

		public bool HasNewItemInManagedFacility()
		{
			return default(bool);
		}

		public bool NeedShowBadgeInManagedFacility()
		{
			return default(bool);
		}

		public bool IsOnFortInitialTutorial()
		{
			return default(bool);
		}

		private bool IsExistCompletedTent()
		{
			return default(bool);
		}

		private bool IsHoneyDrinkMax()
		{
			return default(bool);
		}

		private int GetFortLastIncomeTime()
		{
			return default(int);
		}

		public bool HasNewItemInBuildDialog()
		{
			return default(bool);
		}

		public bool HasDragonContactFreeGift()
		{
			return default(bool);
		}

		public bool HasNewFacility(FortMenuGroupType groupType)
		{
			return default(bool);
		}

		private bool IsNewFacility(FortPlantDataElement plantElement, FortMenuGroupType groupType)
		{
			return default(bool);
		}

		public bool IsNewFacility(Facility facility)
		{
			return default(bool);
		}

		public void ClearFacilityNotNewList()
		{
		}

		public void SetFacilityNotNew(List<Facility> facilities)
		{
		}

		public void RegistFacilityNotNewList(Action onSuccess)
		{
		}

		private int GetFacilityCount(int plantId)
		{
			return default(int);
		}

		private void InitBuildList()
		{
		}
	}
}
