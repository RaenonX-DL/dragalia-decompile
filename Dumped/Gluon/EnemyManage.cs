using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class EnemyManage : SingletonMonoBehaviour<EnemyManage>, IGetCharacter
	{
		public struct EnemyInfo
		{
			public EnemyCharacter chara;

			public EnemyCtrl ctrl;
		}

		private class ActionOrder
		{
			public List<EnemyCtrl> enemies;

			public List<EnemyCtrl> order;

			public int multiSafeActionNum;
		}

		public class SafetyZone
		{
			public EnemyCharacter enemy;

			public int invalidActionId;

			public int[] invalidActionIdArray;

			public SafetyZoneComponent.Shape shape;

			public Vector3 forward;

			public float length;

			public float width;

			public float height;

			public bool isCheckHitByCollisionForward;
		}

		public static readonly string ENEMY_OBJECT_POOL;

		private GameObject _goEnemyObjectPool;

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

		public int storedCount
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

		public bool isExistPool => default(bool);

		private List<EnemyCharacter> listEnemyInPool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int NumEnemyInPool => default(int);

		public List<EnemyInfo> enemies => null;

		public EnemyCallMinionMultiPlayService CallMinionMultiPlayService => null;

		public EnemyAppearEnemyMultiPlayService AppearEnemyMultiPlayService => null;

		public int characterCount => default(int);

		public void Initialize()
		{
		}

		public void PostInitializeEnemies()
		{
		}

		public EnemyCtrl Generate(int paramId, int generatorId = -1, bool toPool = false)
		{
			return null;
		}

		public void CountingStored(int paramId)
		{
		}

		public void CreateEnemyObjectPool()
		{
		}

		public void GenerateToEnemyObjectPool()
		{
		}

		public void GenerateWallBossToEnemyObjectPool()
		{
		}

		public EnemyCharacter PickupEnemyFromPool(int paramId, int serial_idx, int generatorId = -1)
		{
			return null;
		}

		public void ReturnEnemyToPool(EnemyCharacter enemy)
		{
		}

		public static void AddUniqueCtrlComponet(EnemyCharacter character)
		{
		}

		public void AddOrderActionEnemy(int groupId, int mulitSafeActionNum, List<EnemyCtrl> enemies)
		{
		}

		public void RemoveOrderActionEnemy(int groupId)
		{
		}

		public int GetAliveNum(int paramId = 0)
		{
			return default(int);
		}

		public int GetMinionAliveNum(EnemyCharacter ownerEnemy)
		{
			return default(int);
		}

		public int GetAwakeEnemies(List<CharacterBase> ret)
		{
			return default(int);
		}

		public bool IsAwakeEnemy(CharacterBase enemy)
		{
			return default(bool);
		}

		public bool IsAllDeadEnemies()
		{
			return default(bool);
		}

		public void DebugReportIngameState(StringBuilder sb)
		{
		}

		public bool IsValidSelfEnemies()
		{
			return default(bool);
		}

		public bool IsValidSelfEnemiesExceptPlayerSide()
		{
			return default(bool);
		}

		public void RequestCancelWaitDead()
		{
		}

		public bool IsExistsSpecialDeadEnemies()
		{
			return default(bool);
		}

		public bool IsBossDead()
		{
			return default(bool);
		}

		public CharacterBase GetBossCharacter()
		{
			return null;
		}

		public CharacterBase GetNearestEnemyForFollower(Vector3 position, float radius, [Optional] List<CharacterBase> exceptEnemies, bool checkAwake = true, bool considerEnemyR = false, bool ignoreHeight = false)
		{
			return null;
		}

		public CharacterBase GetFarthestEnemyForFollower(PlayerCharacter playerChara, float radius, [Optional] CharacterBase exceptEnemy, bool checkAwake = true)
		{
			return null;
		}

		public CharacterBase GetCharacter(int index)
		{
			return null;
		}

		public void AcitveAI(bool sw)
		{
		}

		public void AllInvincible(bool sw)
		{
		}

		public List<CharacterBase> FindEnemys(int paramId)
		{
			return null;
		}

		public int FindEnemyParamFromEnemyData(int enemyDataId)
		{
			return default(int);
		}

		public void SetVisibleEnemies(bool sw)
		{
		}

		public void ForcedDeadEnemy(bool isRegistLastDead = true, bool isInvolveBossDead = false, bool isAllDead = true)
		{
		}

		public void SucceedToAIScript()
		{
		}

		public EnemyCtrl GetCtrl(CharacterBase chara)
		{
			return null;
		}

		public void GetPoppedRareEnemies(List<EnemyCharacter> ret)
		{
		}

		public void GetPoppedStrongEnemies(List<EnemyCharacter> ret)
		{
		}

		private void GetPoppedToughEnemies(EnemyToughType type, List<EnemyCharacter> ret)
		{
		}

		public bool IsPoppedToughEnemy(EnemyCharacter enemy, EnemyToughType type)
		{
			return default(bool);
		}

		public void DeleteAllBullet()
		{
		}

		private void Update()
		{
		}

		private void UpdateOrderAction()
		{
		}

		public void OnEnemyDead(EnemyCharacter deadEnemy, DeadReason reason)
		{
		}

		public void SetQuestFailure()
		{
		}

		public void SetQuestTimeupCleared()
		{
		}

		public static GameMasterUniqueCtrl FindGameMaster()
		{
			return null;
		}

		public void AddSafetyZone(EnemyCtrl ctrl)
		{
		}

		public void OnChangeRoomGroup(CharacterBase target, WarpRoom.RoomGroup prevRoomGroup)
		{
		}

		public void OnDisconnectUser(int disconnectActorId)
		{
		}

		public void OnEnemyWallOpend()
		{
		}

		public IEnumerator CoInitialActions(EnemyCharacter chara)
		{
			return null;
		}

		public bool IsExistsEnemyWithDamageImmunity(DamageImmunity.Type type)
		{
			return default(bool);
		}
	}
}
