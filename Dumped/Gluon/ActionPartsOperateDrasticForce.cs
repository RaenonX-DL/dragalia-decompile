using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOperateDrasticForce : ActionParts
	{
		public enum OperateType
		{
			Reset,
			AddStack,
			SubStack
		}

		private readonly OperateDrasticForceData _partsData;

		public ActionPartsOperateDrasticForce(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		private void Proc()
		{
		}
	}
}
