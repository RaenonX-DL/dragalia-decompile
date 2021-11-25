using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcSubspace : EnemyAbilityProcBase
	{
		private enum SubspaceState
		{
			Deactive,
			Open,
			Active,
			TargetDead,
			TargetLeave,
			Close
		}

		private SubspaceState _state;

		private CharacterBase _target;

		private const float RETURN_TIME = 3f;

		private float _timer;

		private List<CharacterBase> _targets;

		private bool IsFinishedWarpOnMulti
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

		public EnemyAbilityProcSubspace(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		private void ProcDeactive()
		{
		}

		private void ProcOpen()
		{
		}

		private void ProcTargetDead()
		{
		}

		private void ProcTargetLeave()
		{
		}

		private void ProcClose()
		{
		}

		private CharacterBase GetTargetSolo()
		{
			return null;
		}

		private CharacterBase GetTargetMulti()
		{
			return null;
		}

		private void ReleaseSpRegenerationBuff(CharacterBase target)
		{
		}

		private void ReleasePhaseShiftInSubspace()
		{
		}

		public override void OnChangeRoomGroup(CharacterBase target)
		{
		}

		public override void OnDisconnectUser(int disconnectActorId)
		{
		}

		private CharacterBase FindPlayerCharacter()
		{
			return null;
		}

		private CharacterBase FindOtherPlayerCharacter()
		{
			return null;
		}
	}
}
