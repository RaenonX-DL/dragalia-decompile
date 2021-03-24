/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ControlDeath
	{
		// Fields
		private const float DEFAULT_DEAD_IDLING_TIME = 1f;
		private const float DEATH_TIME_UP = 10f;
		private readonly CharacterBuffType[] excludeTypes;
		private State _state;
		private CharacterBase _owner;
		private float _time;
		private bool _isDeadEventReceived;
	
		// Nested types
		private enum State
		{
			Initilize = 0,
			Living = 1,
			Death = 2,
			DeathReserved = 3,
			DeadIdle = 4,
			DeadParts = 5,
			End = 6
		}
	
		// Constructors
		public ControlDeath();
	
		// Methods
		public void Setup(CharacterBase owner);
		public void Reset();
		public bool OnDead(CollisionHitAttribute hitAttr = null);
		public void Update();
		public void RequestCancelWaitDead();
		public void SetEnd();
		public void OnDeadEvent(Dead dead);
		private void SetDeadIdle(bool immediate = false);
		private void SetDeath();
		private void SendDeathEvent();
		private bool CanProcessDeath();
		private void ResetStatus();
		private void ResetTransSkills();
		private bool IsMultiPlayEventSender();
		private bool IsMultiPlayEventReceiver();
	}
}
