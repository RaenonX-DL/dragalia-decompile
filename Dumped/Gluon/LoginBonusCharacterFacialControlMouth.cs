using UnityEngine;

namespace Gluon
{
	public class LoginBonusCharacterFacialControlMouth : SimpleCharacterFacialControlBase
	{
		private enum State
		{
			None,
			Idle,
			Smile,
			Talk
		}

		public const string StateTriggerNone = "None";

		public const string StateTriggerIdle = "Idle";

		public const string StateTriggerSmile = "Smile";

		public const string StateTriggerTalk = "Talk";

		private State _state;

		private float mouthTime;

		public float mouthFrame;

		protected override void OnSetup(out Vector2 defaultOffset)
		{
		}

		protected override bool OnLateUpdate(out Vector2 outTextureOffset)
		{
			return default(bool);
		}

		private void SetState(State state)
		{
		}

		protected override void OnTrigger(string triggerName)
		{
		}
	}
}
