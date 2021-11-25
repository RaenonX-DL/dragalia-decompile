using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class ManagedFacilityModel
	{
		public class ManagedFacility
		{
			private const int defaultFacilityLevel = 1;

			public List<Facility> facilityList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isStored
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

			public ElementalType firstElementalBonus
			{
				[CompilerGenerated]
				get
				{
					return default(ElementalType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ElementalType secondElementalBonus
			{
				[CompilerGenerated]
				get
				{
					return default(ElementalType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int firstWeaponTypeBonus
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int secondWeaponTypeBonus
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ManagedFacility(bool isStored)
			{
			}

			public FortPlantDetailElement GetDetailData()
			{
				return null;
			}

			public FortPlantDataElement GetPlantData()
			{
				return null;
			}

			public int GetLevel()
			{
				return default(int);
			}

			public void AddFacility(Facility facility)
			{
			}

			public void RemoveFacility(Facility facility)
			{
			}

			private void SetElementalBonus()
			{
			}

			private void SetWeaponTypeBonus()
			{
			}

			public float SelectHp()
			{
				return default(float);
			}

			public float SelectAtk()
			{
				return default(float);
			}

			public bool IsNew()
			{
				return default(bool);
			}

			public bool IsMaxLevel()
			{
				return default(bool);
			}

			public bool IsUpgradeable()
			{
				return default(bool);
			}

			public bool IsLackingMaterialsForUpgrade()
			{
				return default(bool);
			}
		}

		public List<ManagedFacility> managedFacilityList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void ClearAllStoredFaciliy()
		{
		}

		public int GetAllStoredFacilityCount()
		{
			return default(int);
		}

		public int GetStoredFacilityCount(int plantId)
		{
			return default(int);
		}

		public int GetStoredFacilityCount(FortPlantType type)
		{
			return default(int);
		}

		public int GetStoredFacilityTotalLevel()
		{
			return default(int);
		}

		public List<ManagedFacility> GetFacilityList(FortMenuGroupType type)
		{
			return null;
		}

		public void AddFacility(Facility facility, bool isStored)
		{
		}

		public void RemoveFacility(Facility removeFacility, bool isStored)
		{
		}

		public void MoveToStoreHouse(Facility facility)
		{
		}

		public void RemoveFromStoreHouse(Facility facility)
		{
		}

		public bool HasNewFacility(FortMenuGroupType groupType)
		{
			return default(bool);
		}

		public void SetNewFlag(ulong buildId, bool isNew)
		{
		}

		public void UpdateFacility(Facility previousFacility, Facility nextFacility)
		{
		}

		public bool ExistUpgradeableFacility(FortMenuGroupType type)
		{
			return default(bool);
		}
	}
}
