using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcScapegoat : EnemyAbilityProcBase
	{
		private float _timer;

		private float _totalTime;

		public List<EnemyCharacter> SubtractedTargets
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

		public EnemyAbilityProcScapegoat(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Stop()
		{
		}

		public override void Play()
		{
		}

		public override void OnUpdate()
		{
		}

		public void SetTimer(float time)
		{
		}

		private void ShowUI()
		{
		}

		private void HideUI()
		{
		}

		private void SetUIGaugeTimer()
		{
		}

		public override void CreateCharacterMarkRelationUI()
		{
		}

		public void OnScapegoatRites(CharacterBase enemy, string effName, int effTrigger)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
