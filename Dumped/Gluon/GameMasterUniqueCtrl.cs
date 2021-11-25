using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Dungeon;

namespace Gluon
{
	public class GameMasterUniqueCtrl : EnemyUniqueCtrl
	{
		public enum EventType
		{
			None,
			TurnPop,
			CompleteTurn,
			Sudden,
			Bandit
		}

		public struct EventInfo
		{
			public string _enemyGeneratorLabel;
		}

		private const int TURN_MAX = 4;

		private const int TURN_SYNC_ENEMY_MAX = 7;

		private const int EVENT_SYNC_ENEMY_MAX = 5;

		private EventInfo _tmpEventinfo;

		public EventType tmpNextEvent
		{
			[CompilerGenerated]
			get
			{
				return default(EventType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EventType nextEvent
		{
			[CompilerGenerated]
			get
			{
				return default(EventType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int turnCount
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

		public int turnMax
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

		public bool hasSetTurnMax
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

		public EventInfo tmpEventinfo => default(EventInfo);

		public List<EnemyCharacter> turnMemberList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public List<EnemyCharacter> banditList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public List<FieldTalkTriggerAccessPoint> accessPoints
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override void Initialize()
		{
		}

		public int GetAliveFromGM(EventType type)
		{
			return default(int);
		}

		public void CallEnemyGenerator(string label, [Optional] EnemyCharacter caller)
		{
		}

		public void AddTurnCount()
		{
		}

		public void SetTurnMax(int num)
		{
		}

		public void DispEventUI(int id)
		{
		}

		public bool CanSetTurn()
		{
			return default(bool);
		}

		public void SetNextEvent(EventType type)
		{
		}

		public void SetTempEvent(EventType type, string eg_label)
		{
		}

		public void CompleateTurnEvent()
		{
		}

		public void CompleateTurnEventTemporary()
		{
		}

		public bool CanSetSyncEvent()
		{
			return default(bool);
		}

		public bool CanSetBanditEvent()
		{
			return default(bool);
		}
	}
}
