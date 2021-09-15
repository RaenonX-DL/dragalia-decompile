/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcMelody : EnemyAbilityProcBase
	{
		// Fields
		private EnemyAbilityProcMelody _melody0;
		private EnemyAbilityProcMelody _melody1;
		private EnemyAbilityProcDissonance _dissonance;
		[CompilerGenerated]
		private int _tuningCount_k__BackingField;
		private int _tuningResetCount;
		private Dictionary<int, int> _tuningCountReservedMap;
		private bool _isSwitchReserved;
		private bool _isSwitchSyncd;
		private float _preAbnormalRate_Poison;
		private float _preAbnormalRate_CrashWind;
		private float _preAbnormalRate_Paralysis;
		private float _preAbnormalRate_FlashHeat;
	
		// Properties
		public int tuningCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override string effKey { get; }
	
		// Nested types
		private enum SongType
		{
			Hell = 0,
			Heaven = 1
		}
	
		// Constructors
		public EnemyAbilityProcMelody(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void OnEntry();
		public override void OnAbnormalStatusProbability(int type, ref Gluon.EnemyAbility.Argument arg);
		public override void OnSwitchElement();
		public void Switch();
		private void SetupAbnormalResist();
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
		private int AddTuningResetCount();
		public override void OnRecieveCharacterState(CharacterState recvEvent);
		public override void OnUpdate();
	}
}
