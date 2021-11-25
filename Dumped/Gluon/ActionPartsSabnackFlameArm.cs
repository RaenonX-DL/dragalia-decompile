using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsSabnackFlameArm : ActionParts
	{
		public enum FlameType
		{
			Disappear,
			ChangeColor
		}

		public enum PartsType
		{
			Left,
			Right,
			Head
		}

		private float _time;

		private EnemyCharacter _parts;

		private readonly SabnackFlameArmData _partsData;

		public ActionPartsSabnackFlameArm(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void ControlFlame(float ratio)
		{
		}
	}
}
