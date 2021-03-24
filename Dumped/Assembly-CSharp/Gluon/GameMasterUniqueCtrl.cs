/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameMasterUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		[CompilerGenerated]
		private EventType _tmpNextEvent_k__BackingField;
		[CompilerGenerated]
		private EventType _nextEvent_k__BackingField;
		private EnemyCharacter.CallMinionInfo _callMinionInfo;
		[CompilerGenerated]
		private int _turnCount_k__BackingField;
		private const int TURN_MAX = 4;
		[CompilerGenerated]
		private int _turnMax_k__BackingField;
		[CompilerGenerated]
		private bool _hasSetTurnMax_k__BackingField;
		private const int TURN_SYNC_ENEMY_MAX = 7;
		private const int EVENT_SYNC_ENEMY_MAX = 5;
		private EventInfo _tmpEventinfo;
		[CompilerGenerated]
		private readonly List<EnemyCharacter> _turnMemberList_k__BackingField;
		[CompilerGenerated]
		private readonly List<EnemyCharacter> _banditList_k__BackingField;
		[CompilerGenerated]
		private readonly List<FieldTalkTriggerAccessPoint> _accessPoints_k__BackingField;
	
		// Properties
		public EventType tmpNextEvent { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EventType nextEvent { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int turnCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int turnMax { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasSetTurnMax { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public EventInfo tmpEventinfo { get; }
		public List<EnemyCharacter> turnMemberList { [CompilerGenerated] get; }
		public List<EnemyCharacter> banditList { [CompilerGenerated] get; }
		public List<FieldTalkTriggerAccessPoint> accessPoints { [CompilerGenerated] get; }
	
		// Nested types
		public enum EventType
		{
			None = 0,
			TurnPop = 1,
			CompleteTurn = 2,
			Sudden = 3,
			Bandit = 4
		}
	
		public struct EventInfo
		{
			// Fields
			public string _enemyGeneratorLabel;
		}
	
		// Constructors
		public GameMasterUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public int GetAliveFromGM(EventType type);
		public void CallEnemyGenerator(string label, EnemyCharacter caller = null);
		public void AddTurnCount();
		public void SetTurnMax(int num);
		public void DispEventUI(int id);
		public bool CanSetTurn();
		public void SetNextEvent(EventType type);
		public void SetTempEvent(EventType type, string eg_label);
		public void CompleateTurnEvent();
		public void CompleateTurnEventTemporary();
		public bool CanSetSyncEvent();
		public bool CanSetBanditEvent();
	}
}
