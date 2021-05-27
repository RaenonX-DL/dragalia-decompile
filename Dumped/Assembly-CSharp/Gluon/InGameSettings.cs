/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class InGameSettings : ScriptableObject
	{
		// Fields
		public const string path = "Settings/InGameSettings";
		[Header]
		public RebornParams rebornParam;
		[Header]
		public UnitScaleParam[] unitScaleParams;
		[Header]
		public PlayerAIParam[] playerAIParams;
		[Header]
		public WalkingParam walkingParam;
		[Header]
		public DragonRelayParam dragonRelayParam;
		[Header]
		public SwitchParam switches;
		[Header]
		public CameraParam cameraParam;
		[Header]
		public RaidParam raidParam;
		[Header]
		public BRParams brParams;
		[Header]
		public BuffParams buffParam;
		[Header]
		public AnimatableObjectParam[] animatableObjectParams;
		[Header]
		public DefenseQuestParam defenseParam;
		[Header]
		public ScoringQuestParam scoringQuestParam;
	
		// Nested types
		[Serializable]
		public class RebornParams
		{
			// Fields
			[Header]
			[SerializeField]
			public float hpRatio;
			[Header]
			[SerializeField]
			public float waitingSec;
			[Header]
			[SerializeField]
			public float invincibleSec;
			[Header]
			[SerializeField]
			public int debuffId;
	
			// Constructors
			public RebornParams();
		}
	
		[Serializable]
		public class UnitScaleParam
		{
			// Fields
			[Header]
			[SerializeField]
			public string modelId;
			[Header]
			[SerializeField]
			public float scale;
	
			// Constructors
			public UnitScaleParam();
		}
	
		[Serializable]
		public class PlayerAIParam
		{
			// Fields
			[Header]
			[SerializeField]
			public string charaId;
			[Header]
			[SerializeField]
			public PlayerAIType type;
			[Header]
			[SerializeField]
			public ModeParam[] modeParams;
			[Header]
			[SerializeField]
			public DisableMoveParam disableMoveParam;
			[Header]
			[SerializeField]
			public float overrideChargeWaitTime;
	
			// Nested types
			[Serializable]
			public class ModeParam
			{
				// Fields
				[Header]
				[SerializeField]
				public string skillId;
				[Header]
				[SerializeField]
				public int count;
	
				// Constructors
				public ModeParam();
			}
	
			[Serializable]
			public class DisableMoveParam
			{
				// Fields
				[Header]
				[SerializeField]
				public int actionId;
				[Header]
				[SerializeField]
				public float durationSec;
	
				// Constructors
				public DisableMoveParam();
			}
	
			// Constructors
			public PlayerAIParam();
		}
	
		public enum PlayerAIType
		{
			Normal = 0,
			Burst_00 = 1,
			Mode_00 = 2,
			DisableMove_00 = 3
		}
	
		[Serializable]
		public class WalkingParam
		{
			// Fields
			[Header]
			[SerializeField]
			public float cameraFocusTiming;
			[Header]
			[SerializeField]
			public float moveMargin;
			[Header]
			[SerializeField]
			public float moveMargin_back;
			[Header]
			[SerializeField]
			public float motionBlendSec_wait;
			[Header]
			[SerializeField]
			public float runTransitionSec;
			[Header]
			[SerializeField]
			public float giveUpCatchSec;
			[Header]
			[SerializeField]
			public float moveSpeed;
			[Header]
			[SerializeField]
			public float dashSpeedRatio;
			[Header]
			[SerializeField]
			public BallLotteryTable[] ballLotteryTables;
			[Header]
			[SerializeField]
			public int sleepSkillDataId;
			[Header]
			[SerializeField]
			public List<int> existsOnlyCharaOrDragonList;
			[Header]
			[SerializeField]
			public List<ChangePartsData> changePartsList;
			[Header]
			[SerializeField]
			public List<int> needsDragonTransformActionDragons;
	
			// Nested types
			[Serializable]
			public class BallLotteryTable
			{
				// Fields
				[Header]
				[SerializeField]
				public int prob_1;
				[Header]
				[SerializeField]
				public int prob_2;
				[Header]
				[SerializeField]
				public int prob_3;
				[Header]
				[SerializeField]
				public int prob_4;
	
				// Constructors
				public BallLotteryTable();
			}
	
			[Serializable]
			public class ChangePartsData
			{
				// Fields
				[Header]
				[SerializeField]
				public int charaId;
				[Header]
				[SerializeField]
				public string partsName;
				[Header]
				[SerializeField]
				public RenderPartsData.PartsNo partsNo;
	
				// Constructors
				public ChangePartsData();
			}
	
			// Constructors
			public WalkingParam();
		}
	
		[Serializable]
		public class DragonRelayParam
		{
			// Fields
			[Header]
			[SerializeField]
			public float beforeCharaChangeSec;
			[Header]
			[SerializeField]
			public float afterCharaChangeSec;
	
			// Constructors
			public DragonRelayParam();
		}
	
		[Serializable]
		public class SwitchParam
		{
			// Fields
			[Header]
			[SerializeField]
			public bool disableClearMultiOldEventsBeforeInitializeEnemy;
			[Header]
			[SerializeField]
			public bool revertCheckBurstForCamera;
			[Header]
			[SerializeField]
			public bool auraEnableLevelDown;
			[Header]
			[SerializeField]
			public bool isEnemyModelTypeNormalOnCreate;
	
			// Constructors
			public SwitchParam();
		}
	
		[Serializable]
		public class CameraParam
		{
			// Fields
			[Header]
			[SerializeField]
			public List<int> continueCameraChangeInstantlyQuestIds;
	
			// Constructors
			public CameraParam();
		}
	
		[Serializable]
		public class RaidParam
		{
			// Fields
			[Header]
			[SerializeField]
			public List<int> useNormalHitCheckQuestIds;
	
			// Constructors
			public RaidParam();
		}
	
		[Serializable]
		public class BRParams
		{
			// Fields
			[Header]
			[SerializeField]
			public List<BattleRoyalDungeonItem> fixedDropItemsOnCharaDead;
			[Header]
			[SerializeField]
			public float dropWeaponItemsRatioOnCharaDead;
			[Header]
			[SerializeField]
			public int dpOnCharaDead;
			[Header]
			[SerializeField]
			public float botEscapeHpRatio;
			[Header]
			[SerializeField]
			public List<int> skillIdsDependsOnHiding;
			[Header]
			[SerializeField]
			public float hidingDamageRatio;
			[Header]
			[SerializeField]
			public int changeBgmCharaCount;
			[Header]
			[SerializeField]
			public float changeBgmElapsedSec;
			[Header]
			[SerializeField]
			public Color hidingColor;
			[Header]
			[SerializeField]
			public float tutorialDamageRatio;
			[Header]
			[SerializeField]
			public float tutorialBotStartSec;
			[Header]
			[SerializeField]
			public List<int> tutorialCantPosEnemyParamIds;
			[Header]
			[SerializeField]
			public DungeonManager.eStageDifficulty tutorialStageDifficulty;
			[Header]
			[SerializeField]
			public int tutorialStartIndex;
			[Header]
			[SerializeField]
			public float itemPopRadius;
	
			// Constructors
			public BRParams();
		}
	
		[Serializable]
		public class BuffParams
		{
			// Fields
			[Header]
			[SerializeField]
			public List<int> partySwitchResetIds;
	
			// Constructors
			public BuffParams();
		}
	
		[Serializable]
		public class AnimatableObjectParam
		{
			// Fields
			[Header]
			[SerializeField]
			public string name;
			[Header]
			[SerializeField]
			public string modelPath;
			[Header]
			[SerializeField]
			public string motionPath;
			[Header]
			[SerializeField]
			public bool enableLimit;
			[Header]
			[SerializeField]
			public int chacheCount;
			[Header]
			[SerializeField]
			public AttachData[] attachData;
	
			// Nested types
			[Serializable]
			public class AttachData
			{
				// Fields
				[Header]
				[SerializeField]
				public string prefabPath;
				[Header]
				[SerializeField]
				public string nodeName;
	
				// Constructors
				public AttachData();
			}
	
			// Constructors
			public AnimatableObjectParam();
		}
	
		[Serializable]
		public class DefenseQuestParam
		{
			// Fields
			[Header]
			[SerializeField]
			public List<int> openNextAreaGateWithoutFinalWaveClearQuestIds;
	
			// Constructors
			public DefenseQuestParam();
		}
	
		[Serializable]
		public class ScoringQuestParam
		{
			// Fields
			[Header]
			[SerializeField]
			public float enemyPopInvincibleSec;
	
			// Constructors
			public ScoringQuestParam();
		}
	
		// Constructors
		public InGameSettings();
	
		// Methods
		public AnimatableObjectParam GetAnimatableObjectParam(string name);
	}
}
