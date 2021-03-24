/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FishUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		[CompilerGenerated]
		private List<EnemyCharacter> _childCharacter_k__BackingField;
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
		[CompilerGenerated]
		private int _tsuriPower_k__BackingField;
		private bool effectDuractionEnd;
		private float effectLimitTime;
		private bool isFishingPowerSet;
		private Dictionary<string, int> fishingScoreTable;
		[CompilerGenerated]
		private bool _isMoveing_k__BackingField;
		private static FishUniqueCtrl _instance;
		private List<ActionMove> _actMoves;
	
		// Properties
		public List<EnemyCharacter> childCharacter { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private int tsuriPower { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isMoveing { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool HasInstance { get; }
	
		// Nested types
		private class OptionCtrl
		{
			// Fields
			public CharacterBase chara;
			public ActionMove actMove;
			public Vector3 dir;
	
			// Constructors
			public OptionCtrl();
		}
	
		private enum State_DanceD
		{
			none = 0,
			expansion = 1,
			childAction = 2,
			twoRound = 3,
			end = 4
		}
	
		private enum State_DanceC
		{
			none = 0,
			expansion = 1,
			bulletAttack = 2,
			end = 3
		}
	
		private enum State_DanceAB
		{
			none = 0,
			expansion = 1,
			rushAttack = 2,
			end = 3
		}
	
		private enum DanceType
		{
			none = 0,
			abType = 1,
			cType = 2,
			dType = 3
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
			NONE = 0,
			BRONZE = 1,
			SILVER = 2,
			GOLD = 3,
			RAINBOW = 4
		}
	
		// Constructors
		public FishUniqueCtrl();
		static FishUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void InitFishingPower(int redScore, int goldScore, int taiyakiScore);
		public void FishKilled(EnemyCharacter fish);
		private void OnDestroy();
		public override void FastUpdate();
		private void UpdateMove();
		public void UpdateDanceAB();
		public void UpdateDanceC();
		public void UpdateDanceD();
		public int GetFishingPower();
		public int GetGrade();
		public void SetFishingPowerUI();
		public void SetGradePoint();
		public void FishReward();
		public void ChildCollisionSwitch(List<EnemyCharacter> children, bool isIgnore);
		public void Initialize_DanceAB(bool isDanceA, float expanSec, int childActionId, float childSpace, float childDistance);
		public void Initialize_DanceC(float expanLength, float expanSec, int childActionId);
		public void Initialize_DanceD(float expanLengthInward, float expanLengthOutside, float expanSec, float rollingCntInward, float rollingCntOutside, float rollingSec, int childActionId);
		public void Clear_DanceD();
		public void Clear_DanceAB();
		public void Clear_DanceC();
		public void UpdateChind();
	}
}
