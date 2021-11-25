using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsFreezePosition : ActionParts
	{
		private bool _isStart;

		public ActionPartsFreezePosition(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		public override void RemoveSelf()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void ResetConstraints()
		{
		}
	}
}
