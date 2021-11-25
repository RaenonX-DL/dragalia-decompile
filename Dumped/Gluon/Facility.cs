using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class Facility
	{
		public enum eFacilityStatus
		{
			NONE = -1,
			BUILDING,
			WAIT_BUILD_FINISHED_ANIM,
			BUILD_FINISHED_ANIM,
			LEVEL_UP,
			WAIT_LEVELUP_FINISHED_ANIM,
			LEVELUP_FINISHED_ANIM,
			NEUTRAL
		}

		public enum eFacilityModelGrade
		{
			GRADE_1,
			GRADE_2,
			GRADE_3,
			GRADE_NUM
		}

		private FortPlantDataElement _parentData;

		private int _localBuildEndTime;

		public string gridImagePath;

		private ulong _buildId;

		private bool _isTimingStarted;

		public eFacilityStatus currentFacilityStatus
		{
			[CompilerGenerated]
			get
			{
				return default(eFacilityStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int facilityId
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

		public FortPlantDetailElement detailData
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

		public FortPlantDataElement parentData => null;

		[SerializeField]
		public string facilityName => null;

		public string description => null;

		public int buildStartTime
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int buildEndTime
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int localBuildEndTime
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float remainTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int lastIncomeTime
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int buildNeedMoney => default(int);

		public int level => default(int);

		public int gridSize => default(int);

		public string imageUIName => null;

		public string prefabPath => null;

		public ulong buildId
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		public bool completedAtOnce
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int[] materials => null;

		public int[] materialNeedNumber => null;

		public Vector2 gridPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isNew
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isTimingStarted
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public Facility(int plantId)
		{
		}

		private void Init(int plantId)
		{
		}

		public static Facility CreateFacility(int plantId)
		{
			return null;
		}

		public void OnApplicationBecomeActive()
		{
		}

		public void StartTiming()
		{
		}

		public void FinishTiming()
		{
		}

		public void TimeCount()
		{
		}

		public bool IsMainFacility()
		{
			return default(bool);
		}

		public bool IsCraftWeaponFacility()
		{
			return default(bool);
		}

		public bool IsFixedPosFacility()
		{
			return default(bool);
		}

		public bool IsCharaBoostFacility()
		{
			return default(bool);
		}

		public bool IsProductionFacility()
		{
			return default(bool);
		}

		public bool IsGoldFacility()
		{
			return default(bool);
		}

		public bool IsDragonFruitsFacility()
		{
			return default(bool);
		}

		public bool IsDecorationFacility()
		{
			return default(bool);
		}

		public bool IsBoostDragonFacility()
		{
			return default(bool);
		}

		public bool IsBoostDragonTimeFacility()
		{
			return default(bool);
		}

		public bool IsBoostDragonElementFacility()
		{
			return default(bool);
		}

		public bool IsBoostAll()
		{
			return default(bool);
		}

		public bool IsBuilding()
		{
			return default(bool);
		}

		public bool IsWaitingFinishBuilding()
		{
			return default(bool);
		}

		public int GetMaxSetNumber()
		{
			return default(int);
		}

		public bool NeedMaterials()
		{
			return default(bool);
		}

		public float GetProductMaxTime()
		{
			return default(float);
		}

		public float GetProductMax()
		{
			return default(float);
		}

		public int GetAppearLv()
		{
			return default(int);
		}

		public Facility GetPreviousLevelFacility()
		{
			return null;
		}

		public Facility GetNextLevelFacility()
		{
			return null;
		}

		public int FindNextFacilityElementId()
		{
			return default(int);
		}

		public int GetNeedStoneNumberToCompleteAtOnce()
		{
			return default(int);
		}

		public string GetCompleteTimeString([Optional] StringBuilder strBuilder, int fontSize = 0, int unitFontSize = 0)
		{
			return null;
		}

		public int GetBuildDuration()
		{
			return default(int);
		}

		public eFacilityModelGrade GetFacilityGrade()
		{
			return default(eFacilityModelGrade);
		}
	}
}
