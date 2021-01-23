/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class Facility
	{
		// Fields
		[CompilerGenerated]
		private eFacilityStatus _currentFacilityStatus_k__BackingField;
		[CompilerGenerated]
		private int _facilityId_k__BackingField;
		[CompilerGenerated]
		private FortPlantDetailElement _detailData_k__BackingField;
		private FortPlantDataElement _parentData;
		[CompilerGenerated]
		private int _buildStartTime_k__BackingField;
		[CompilerGenerated]
		private int _buildEndTime_k__BackingField;
		private int _localBuildEndTime;
		[CompilerGenerated]
		private float _remainTime_k__BackingField;
		[CompilerGenerated]
		private int _lastIncomeTime_k__BackingField;
		public string gridImagePath;
		private ulong _buildId;
		[CompilerGenerated]
		private bool _completedAtOnce_k__BackingField;
		[CompilerGenerated]
		private Vector2 _gridPosition_k__BackingField;
		[CompilerGenerated]
		private bool _isNew_k__BackingField;
		private bool _isTimingStarted;
	
		// Properties
		public eFacilityStatus currentFacilityStatus { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int facilityId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortPlantDetailElement detailData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortPlantDataElement parentData { get; }
		[SerializeField]
		public string facilityName { get; }
		public string description { get; }
		public int buildStartTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int buildEndTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int localBuildEndTime { get; set; }
		public float remainTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int lastIncomeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int buildNeedMoney { get; }
		public int level { get; }
		public int gridSize { get; }
		public string imageUIName { get; }
		public string prefabPath { get; }
		public ulong buildId { get; set; }
		public bool completedAtOnce { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int[] materials { get; }
		public int[] materialNeedNumber { get; }
		public Vector2 gridPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isNew { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isTimingStarted { get; private set; }
	
		// Nested types
		public enum eFacilityStatus
		{
			NONE = -1,
			BUILDING = 0,
			WAIT_BUILD_FINISHED_ANIM = 1,
			BUILD_FINISHED_ANIM = 2,
			LEVEL_UP = 3,
			WAIT_LEVELUP_FINISHED_ANIM = 4,
			LEVELUP_FINISHED_ANIM = 5,
			NEUTRAL = 6
		}
	
		public enum eFacilityModelGrade
		{
			GRADE_1 = 0,
			GRADE_2 = 1,
			GRADE_3 = 2,
			GRADE_NUM = 3
		}
	
		// Constructors
		public Facility(int plantId);
	
		// Methods
		private void Init(int plantId);
		public static Facility CreateFacility(int plantId);
		public void OnApplicationBecomeActive();
		public void StartTiming();
		public void FinishTiming();
		public void TimeCount();
		public bool IsMainFacility();
		public bool IsCraftWeaponFacility();
		public bool IsFixedPosFacility();
		public bool IsCharaBoostFacility();
		public bool IsProductionFacility();
		public bool IsGoldFacility();
		public bool IsDragonFruitsFacility();
		public bool IsDecorationFacility();
		public bool IsBoostDragonFacility();
		public bool IsBoostDragonTimeFacility();
		public bool IsBoostDragonElementFacility();
		public bool IsBoostAll();
		public int GetMaxSetNumber();
		public bool NeedMaterials();
		public float GetProductMaxTime();
		public float GetProductMax();
		public int GetAppearLv();
		public Facility GetPreviousLevelFacility();
		public Facility GetNextLevelFacility();
		public int GetNeedStoneNumberToCompleteAtOnce();
		public string GetCompleteTimeString(StringBuilder strBuilder = null, int fontSize = 0, int unitFontSize = 0);
		public int GetBuildDuration();
		public eFacilityModelGrade GetFacilityGrade();
	}
}
