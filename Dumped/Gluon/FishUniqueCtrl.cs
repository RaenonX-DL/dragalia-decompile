using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class FishUniqueCtrl : EnemyUniqueCtrl
	{
		private class OptionCtrl
		{
			public CharacterBase chara;

			public ActionMove actMove;

			public Vector3 dir;
		}

		private enum State_DanceD
		{
			none,
			expansion,
			childAction,
			twoRound,
			end
		}

		private enum State_DanceC
		{
			none,
			expansion,
			bulletAttack,
			end
		}

		private enum State_DanceAB
		{
			none,
			expansion,
			rushAttack,
			end
		}

		private enum DanceType
		{
			none,
			abType,
			cType,
			dType
		}

		public enum EffectTrigger
		{
			INIT = 0,
			KILL = 1,
			NORMAL = 8,
			GOLD = 9,
			TAIYAKI = 10,
			LOOPEND = 11,
			GOLDCERTAIN = 12,
			TAIYAKICERTAIN = 13
		}

		private enum FishingPowerGrade
		{
			NONE,
			BRONZE,
			SILVER,
			GOLD,
			RAINBOW
		}

		public EnemyCharacter owner;

		public const int MAX_FISHING_POWER = 1000;

		public const int MAX_CHILD_NUM = 5;

		public const string TAI_EFFECT_NAME = "EFF_RID_012_002";

		private const int probability = 25;

		public const float EFFECT_DURATION = 5f;

		private DanceType dancingType;

		private State_DanceD stateDanceD;

		private State_DanceC stateDanceC;

		private State_DanceAB stateDanceAB;

		private float _expanLengthInward;

		private float _expanLengthOutside;

		private float _expanLength;

		private float _expanSec;

		private float _rollingCntInward;

		private float _rollingCntOutside;

		private float _rollingSec;

		private int _childActionId;

		private bool _isDanceA;

		private float _childSpace;

		private float _childDistance;

		private List<OptionCtrl> _options;

		private float elapsedTime;

		private EffectObject effectObject;

		private float effectTimer;

		private bool rewardFirstTime;

		private bool effectDuractionEnd;

		private float effectLimitTime;

		private bool isFishingPowerSet;

		private Dictionary<string, int> fishingScoreTable;

		private static FishUniqueCtrl _instance;

		private List<ActionMove> _actMoves;

		public List<EnemyCharacter> childCharacter
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

		private int tsuriPower
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

		public bool isMoveing
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

		public static bool HasInstance => default(bool);

		public override void Initialize()
		{
		}

		public void InitFishingPower(int redScore, int goldScore, int taiyakiScore)
		{
		}

		public void FishKilled(EnemyCharacter fish)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateMove()
		{
		}

		public void UpdateDanceAB()
		{
		}

		public void UpdateDanceC()
		{
		}

		public void UpdateDanceD()
		{
		}

		public int GetFishingPower()
		{
			return default(int);
		}

		public int GetGrade()
		{
			return default(int);
		}

		public void SetFishingPowerUI()
		{
		}

		public void SetGradePoint()
		{
		}

		public void FishReward()
		{
		}

		public void ChildCollisionSwitch(List<EnemyCharacter> children, bool isIgnore)
		{
		}

		public void Initialize_DanceAB(bool isDanceA, float expanSec, int childActionId, float childSpace, float childDistance)
		{
		}

		public void Initialize_DanceC(float expanLength, float expanSec, int childActionId)
		{
		}

		public void Initialize_DanceD(float expanLengthInward, float expanLengthOutside, float expanSec, float rollingCntInward, float rollingCntOutside, float rollingSec, int childActionId)
		{
		}

		public void Clear_DanceD()
		{
		}

		public void Clear_DanceAB()
		{
		}

		public void Clear_DanceC()
		{
		}

		public void UpdateChind()
		{
		}
	}
}
