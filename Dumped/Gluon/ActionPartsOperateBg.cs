using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOperateBg : ActionParts
	{
		public enum OperateType
		{
			ChangeTexture,
			SwitchTransformParam
		}

		private readonly OperateBgData _partsData;

		public ActionPartsOperateBg(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		private void Proc()
		{
		}
	}
}
