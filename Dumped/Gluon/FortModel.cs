using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class FortModel
	{
		public enum BuildFacilityResult
		{
			YES,
			RANK,
			MONEY,
			STONE,
			MATERIAL,
			MAX_NUMBER,
			SMITH
		}

		public enum NeedLevelType
		{
			NONE,
			PLAYER_LV,
			MAINFACILITY_LV,
			FACILITIES_TOTAL_LV
		}

		private int carpenterMaxNum;

		public const int baseFortNo = 10010101;

		private List<Facility> puttedFacilities;

		private List<FacilityViewController> puttedFacilityVCs;

		private FortAreaMapSettingsElement _mapSetting;

		private List<float> _groundYPoses;

		private float cursorOffset;

		public FortDetail dragonSmithInfo => null;

		public ManagedFacilityModel managedFacilityModel
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

		public FortMapData mapData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Facility mainFacility
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortAreaMapSettingsElement mapSetting => null;

		public List<float> groundYPoses => null;

		public float minGroundY
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int GetMainFacilityMaxLevel()
		{
			return default(int);
		}

		public static bool CanWorkSmith()
		{
			return default(bool);
		}

		public bool CanAddSmith()
		{
			return default(bool);
		}

		public static BuildFacilityResult CanBuild(Facility facility, int currentCount)
		{
			return default(BuildFacilityResult);
		}

		public BuildFacilityResult CanBuild(Facility facility)
		{
			return default(BuildFacilityResult);
		}

		public static BuildFacilityResult CanLevelUp(Facility facility)
		{
			return default(BuildFacilityResult);
		}

		private static BuildFacilityResult CanBuildOrLevelUp(Facility facility, int currentCount, bool isBuild)
		{
			return default(BuildFacilityResult);
		}

		public static bool IsLevelEnough(Facility facility)
		{
			return default(bool);
		}

		public static bool IsMaterialsEnough(Facility facility)
		{
			return default(bool);
		}

		public int GetAllFacilityCount()
		{
			return default(int);
		}

		public List<Facility> GetPuttedFacilityList(FortPlantType type)
		{
			return null;
		}

		public int GetFacilityCount(int plantId)
		{
			return default(int);
		}

		public int GetFacilityCount(FortPlantType type)
		{
			return default(int);
		}

		public List<FacilityViewController> GetProductionFacilityVcList()
		{
			return null;
		}

		public int GetPuttedFacilityCount()
		{
			return default(int);
		}

		public List<Facility> GetPuttedFacilities(FortMenuGroupType type)
		{
			return null;
		}

		public int GetMaxBuildEndTime()
		{
			return default(int);
		}

		public List<ManagedFacilityModel.ManagedFacility> GetFacilitiesFromManagedFacilityModel(FortMenuGroupType type)
		{
			return null;
		}

		public void AddFacility(Facility facility)
		{
		}

		public void AddFacilityVC(FacilityViewController facilityVC)
		{
		}

		public void AddFacilityToManagedFacility(Facility facility, bool isStored)
		{
		}

		public void MoveFacilityToStoreHouse(Facility facility)
		{
		}

		public void UpdateFacility(Facility curFacility, Facility nextFacility)
		{
		}

		public void RemoveFacility(Facility facility, bool isStored)
		{
		}

		public bool IsEnablePut(Vector2 gridPos, int size, bool shouldUnPutted = true)
		{
			return default(bool);
		}

		public Vector2 FindValidPutPosition(int size)
		{
			return default(Vector2);
		}

		public Vector2 FindEnablePutPosition(int size)
		{
			return default(Vector2);
		}

		private Vector2 FindValidGridPos(Vector2 gridPos, int size)
		{
			return default(Vector2);
		}

		public Vector3 ConvertGridPosToLocalPos(Vector2 gridPos, float gridSize)
		{
			return default(Vector3);
		}

		public Vector3 GridPosToLocalPos(Vector2 gridPos)
		{
			return default(Vector3);
		}

		public Vector2 ConvertLocalPosToGridPos(Vector3 localPos, float gridSize)
		{
			return default(Vector2);
		}

		public MapCell? GetMapCellFromLocalPosition(Vector2 localPos, float gridSize)
		{
			return null;
		}

		public MapCell? GetMapCellFromGridPosition(Vector2 gridPos)
		{
			return null;
		}

		public static FortPlantDetailElement FindPlantDetailElement(int fortPlantId, int level)
		{
			return null;
		}

		public int GetFortFacilityTotalLevel()
		{
			return default(int);
		}

		public static int GetFortFacilityTotalLevelByDataManager()
		{
			return default(int);
		}

		public FacilityViewController GetFortBlackSmithFacility()
		{
			return null;
		}

		public FacilityViewController SearchFacilityViewController(Facility facility)
		{
			return null;
		}
	}
}
