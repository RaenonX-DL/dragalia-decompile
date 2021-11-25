using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcMelody : EnemyAbilityProcBase
	{
		private enum SongType
		{
			Hell,
			Heaven
		}

		private EnemyAbilityProcMelody _melody0;

		private EnemyAbilityProcMelody _melody1;

		private EnemyAbilityProcDissonance _dissonance;

		private int _tuningResetCount;

		private Dictionary<int, int> _tuningCountReservedMap;

		private bool _isSwitchReserved;

		private bool _isSwitchSyncd;

		private float _preAbnormalRate_Poison;

		private float _preAbnormalRate_CrashWind;

		private float _preAbnormalRate_Paralysis;

		private float _preAbnormalRate_FlashHeat;

		public int tuningCount
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

		public override string effKey => null;

		public EnemyAbilityProcMelody(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnEntry()
		{
		}

		public override void OnAbnormalStatusProbability(int type, float probability, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnSwitchElement()
		{
		}

		public void Switch()
		{
		}

		private void SetupAbnormalResist()
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}

		private int AddTuningResetCount()
		{
			return default(int);
		}

		public override void OnRecieveCharacterState(CharacterState recvEvent)
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
