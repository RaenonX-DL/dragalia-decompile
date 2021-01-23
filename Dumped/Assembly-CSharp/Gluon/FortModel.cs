/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortModel
	{
		// Fields
		private int carpenterMaxNum;
		public const int baseFortNo = 10010101;
		private List<Facility> puttedFacilities;
		private List<FacilityViewController> puttedFacilityVCs;
		[CompilerGenerated]
		private StoreHouse _storeHouse_k__BackingField;
		[CompilerGenerated]
		private FortMapData _mapData_k__BackingField;
		[CompilerGenerated]
		private Facility _mainFacility_k__BackingField;
		private FortAreaMapSettingsElement _mapSetting;
		private List<float> _groundYPoses;
		[CompilerGenerated]
		private float _minGroundY_k__BackingField;
		private float cursorOffset;
	
		// Properties
		public FortDetail dragonSmithInfo { get; }
		public StoreHouse storeHouse { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortMapData mapData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Facility mainFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortAreaMapSettingsElement mapSetting { get; }
		public List<float> groundYPoses { get; }
		public float minGroundY { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum BuildFacilityResult
		{
			YES = 0,
			RANK = 1,
			MONEY = 2,
			STONE = 3,
			MATERIAL = 4,
			MAX_NUMBER = 5,
			SMITH = 6
		}
	
		public enum NeedLevelType
		{
			NONE = 0,
			PLAYER_LV = 1,
			MAINFACILITY_LV = 2,
			FACILITIES_TOTAL_LV = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public Facility facility;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal bool _MoveFacilityToStoreHouse_b__0(FacilityViewController x);
		}
	
		// Constructors
		public FortModel();
	
		// Methods
		public int GetMainFacilityMaxLevel();
		public static bool CanWorkSmith();
		public bool CanAddSmith();
		public static BuildFacilityResult CanBuild(Facility facility, int currentCount);
		public BuildFacilityResult CanBuild(Facility facility);
		public BuildFacilityResult CanLevelUp(Facility facility);
		private static BuildFacilityResult CanBuildOrLevelUp(Facility facility, int currentCount, bool isBuild);
		public static bool IsLevelEnough(Facility facility);
		public int GetAllFacilityCount();
		public List<Facility> GetPuttedFacilityList(FortPlantType type);
		public int GetFacilityCount(int plantId);
		public int GetFacilityCount(FortPlantType type);
		public List<FacilityViewController> GetProductionFacilityVcList();
		public int GetPuttedFacilityCount();
		public List<Facility> GetPuttedFacilities(FortMenuGroupType type);
		public int GetMaxBuildEndTime();
		public List<StoreHouse.StoreHouseFacility> GetFacilitiesFromStoreHouse(FortMenuGroupType type);
		public void AddFacility(Facility facility);
		public void AddFacilityVC(FacilityViewController facilityVC);
		public void AddFacilityToStoreHouse(Facility facility);
		public void MoveFacilityToStoreHouse(Facility facility);
		public void UpdateFacility(Facility curFacility, Facility nextFacility);
		public void RemoveFacility(Facility facility);
		public bool IsEnablePut(Vector2 gridPos, int size, bool shouldUnPutted = true);
		public Vector2 FindValidPutPosition(int size);
		public Vector2 FindEnablePutPosition(int size);
		private Vector2 FindValidGridPos(Vector2 gridPos, int size);
		public Vector3 ConvertGridPosToLocalPos(Vector2 gridPos, float gridSize);
		public Vector3 GridPosToLocalPos(Vector2 gridPos);
		public Vector2 ConvertLocalPosToGridPos(Vector3 localPos, float gridSize);
		public MapCell? GetMapCellFromLocalPosition(Vector2 localPos, float gridSize);
		public MapCell? GetMapCellFromGridPosition(Vector2 gridPos);
		public static FortPlantDetailElement FindPlantDetailElement(int fortPlantId, int level);
		public int GetFortFacilityTotalLevel();
		public FacilityViewController GetFortBlackSmithFacility();
	}
}
