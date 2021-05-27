/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyManage : SingletonMonoBehaviour<Gluon.EnemyManage>, IGetCharacter
	{
		// Fields
		[CompilerGenerated]
		private int _storedCount_k__BackingField;
		public static readonly string ENEMY_OBJECT_POOL;
		private GameObject _goEnemyObjectPool;
		[CompilerGenerated]
		private readonly List<EnemyCharacter> _listEnemyInPool_k__BackingField;
		private List<EnemyInfo> _enemies;
		public EnemyCharacter lastDeadEnemy;
		public EnemyCharacter lastDeadBoss;
		private Dictionary<int, ActionOrder> _actionOrders;
		public List<SafetyZone> saftyZones;
		private EnemyDeadMultiPlayService _enemyDeadMultiPlayService;
		private EnemyAppearMultiPlayService _enemyAppearMultiPlayService;
		private Dictionary<int, int> shiftStoredCountDict;
		private EnemyCallMinionMultiPlayService _enemyCallMinionMultiPlayService;
		private EnemyAppearEnemyMultiPlayService _enemyAppearEnemyMultiPlayService;
	
		// Properties
		public int storedCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isExistPool { get; }
		private List<EnemyCharacter> listEnemyInPool { [CompilerGenerated] get; }
		public int NumEnemyInPool { get; }
		public List<EnemyInfo> enemies { get; }
		public EnemyCallMinionMultiPlayService CallMinionMultiPlayService { get; }
		public EnemyAppearEnemyMultiPlayService AppearEnemyMultiPlayService { get; }
		public int characterCount { get; }
	
		// Nested types
		public struct EnemyInfo
		{
			// Fields
			public EnemyCharacter chara;
			public EnemyCtrl ctrl;
		}
	
		private class ActionOrder
		{
			// Fields
			public List<EnemyCtrl> enemies;
			public List<EnemyCtrl> order;
			public int multiSafeActionNum;
	
			// Constructors
			public ActionOrder();
		}
	
		public class SafetyZone
		{
			// Fields
			public EnemyCharacter enemy;
			public int invalidActionId;
			public int[] invalidActionIdArray;
			public SafetyZoneComponent.Shape shape;
			public Vector3 forward;
			public float length;
			public float width;
			public float height;
			public bool isCheckHitByCollisionForward;
	
			// Constructors
			public SafetyZone();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public int id;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal bool _GenerateWallBossToEnemyObjectPool_b__0(EnemyInfo s);
			internal bool _GenerateWallBossToEnemyObjectPool_b__1(EnemyCharacter s);
		}
	
		// Constructors
		public EnemyManage();
		static EnemyManage();
	
		// Methods
		public void Initialize();
		public void PostInitializeEnemies();
		public EnemyCtrl Generate(int paramId, int generatorId = -1, bool toPool = false);
		public void CountingStored(int paramId);
		public void CreateEnemyObjectPool();
		public void GenerateToEnemyObjectPool();
		public void GenerateWallBossToEnemyObjectPool();
		public EnemyCharacter PickupEnemyFromPool(int paramId, int serial_idx, int generatorId = -1);
		public void ReturnEnemyToPool(EnemyCharacter enemy);
		public static void AddUniqueCtrlComponet(EnemyCharacter character);
		public void AddOrderActionEnemy(int groupId, int mulitSafeActionNum, List<EnemyCtrl> enemies);
		public void RemoveOrderActionEnemy(int groupId);
		public int GetAliveNum();
		public int GetMinionAliveNum(EnemyCharacter ownerEnemy);
		public int GetAwakeEnemies(List<CharacterBase> ret);
		public bool IsAwakeEnemy(CharacterBase enemy);
		public bool IsAllDeadEnemies();
		public bool IsValidSelfEnemies();
		public bool IsValidSelfEnemiesExceptPlayerSide();
		public void RequestCancelWaitDead();
		public bool IsExistsSpecialDeadEnemies();
		public bool IsBossDead();
		public CharacterBase GetBossCharacter();
		public CharacterBase GetNearestEnemyForFollower(Vector3 position, float radius, List<CharacterBase> exceptEnemies = null, bool checkAwake = true, bool considerEnemyR = false, bool ignoreHeight = false);
		public CharacterBase GetFarthestEnemyForFollower(Vector3 position, float radius, CharacterBase exceptEnemy = null, bool checkAwake = true);
		public CharacterBase GetCharacter(int index);
		public void AcitveAI(bool sw);
		public void AllInvincible(bool sw);
		public List<CharacterBase> FindEnemys(int paramId);
		public int FindEnemyParamFromEnemyData(int enemyDataId);
		public void SetVisibleEnemies(bool sw);
		public void ForcedDeadEnemy(bool isRegistLastDead = true, bool isInvolveBossDead = false, bool isAllDead = true);
		public void SucceedToAIScript();
		public EnemyCtrl GetCtrl(CharacterBase chara);
		public void GetPoppedRareEnemies(List<EnemyCharacter> ret);
		public void GetPoppedStrongEnemies(List<EnemyCharacter> ret);
		private void GetPoppedToughEnemies(EnemyToughType type, List<EnemyCharacter> ret);
		public bool IsPoppedToughEnemy(EnemyCharacter enemy, EnemyToughType type);
		public void DeleteAllBullet();
		private void Update();
		private void UpdateOrderAction();
		public void OnEnemyDead(EnemyCharacter deadEnemy, DeadReason reason);
		public void SetQuestFailure();
		public void SetQuestTimeupCleared();
		public static GameMasterUniqueCtrl FindGameMaster();
		public void AddSafetyZone(EnemyCtrl ctrl);
		public void OnChangeRoomGroup(CharacterBase target, WarpRoom.RoomGroup prevRoomGroup);
		public void OnDisconnectUser(int disconnectActorId);
		public void OnEnemyWallOpend();
	}
}
