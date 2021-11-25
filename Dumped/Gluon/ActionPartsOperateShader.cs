using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOperateShader : ActionParts
	{
		public enum OperateType
		{
			SwitchingMaterial,
			ImageEffectProduction
		}

		private readonly OperateShaderData _partsData;

		public ActionPartsOperateShader(Gluon.ActionData.ActionParts resource)
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
