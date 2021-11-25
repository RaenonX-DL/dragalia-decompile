using System.Runtime.CompilerServices;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlHealBlock : CUGCtrlBase
	{
		public enum State
		{
			Idle,
			Running
		}

		private string _effName;

		private const int EFF_TRIG = 8;

		private EffectObject _effectObject;

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override bool active => default(bool);

		public void Setup(CharacterSelector selector, string eff_name = "")
		{
		}

		public override void Abort()
		{
		}

		public void Start()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		public override void PlayEffect()
		{
		}

		public override void StopEffect()
		{
		}

		public void DeleteEffect()
		{
		}
	}
}
