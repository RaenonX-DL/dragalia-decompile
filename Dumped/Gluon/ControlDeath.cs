using System.Runtime.InteropServices;
using Gluon.Event;

namespace Gluon
{
	public class ControlDeath
	{
		private enum State
		{
			Initilize,
			Living,
			Death,
			DeathReserved,
			DeadIdle,
			DeadParts,
			End
		}

		private const float DEFAULT_DEAD_IDLING_TIME = 1f;

		private const float DEATH_TIME_UP = 10f;

		private readonly CharacterBuffType[] excludeTypes;

		private State _state;

		private CharacterBase _owner;

		private float _time;

		private bool _isDeadEventReceived;

		public void Setup(CharacterBase owner)
		{
		}

		public void Reset()
		{
		}

		public bool OnDead([Optional] CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public void Update()
		{
		}

		public void RequestCancelWaitDead()
		{
		}

		public void SetEnd()
		{
		}

		public void OnDeadEvent(Dead dead)
		{
		}

		private void SetDeadIdle(bool immediate = false)
		{
		}

		private void SetDeath()
		{
		}

		private void SendDeathEvent()
		{
		}

		private bool CanProcessDeath()
		{
			return default(bool);
		}

		private void ResetStatus()
		{
		}

		private void ResetTransSkills()
		{
		}

		private bool IsMultiPlayEventSender()
		{
			return default(bool);
		}

		private bool IsMultiPlayEventReceiver()
		{
			return default(bool);
		}
	}
}
