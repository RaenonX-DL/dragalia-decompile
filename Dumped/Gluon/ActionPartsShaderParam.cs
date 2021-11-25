using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsShaderParam : ActionParts
	{
		private readonly ShaderParamData _partsData;

		private ShaderParamData.ResetFlags _resetFlags;

		public ActionPartsShaderParam(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		private void UpdateShaderParameter()
		{
		}

		private void SetResetShaderParameter()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public override void Stop()
		{
		}
	}
}
