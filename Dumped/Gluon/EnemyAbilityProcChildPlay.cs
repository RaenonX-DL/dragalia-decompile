using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcChildPlay : EnemyAbilityProcBase
	{
		private float _timer;

		private bool _reserveRestart;

		private float[] _abnormalResist;

		private float[] _abnormalPreResist;

		public float duration
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float restartTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EnemyAbilityProcChildPlay(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		private void OnPlay()
		{
		}

		public override void Stop()
		{
		}

		private void OnStop()
		{
		}

		public override void OnUpdate()
		{
		}

		public void SetAbnormalResist(AbnormalStatusType type, int value)
		{
		}

		private bool UnisonPlay()
		{
			return default(bool);
		}

		private bool UnisonStop()
		{
			return default(bool);
		}

		public void ResetTimer()
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
