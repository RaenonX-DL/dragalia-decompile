using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsBodyScale : ActionParts
	{
		private readonly BodyScaleData _partsData;

		private float _scale;

		private float _elapsed;

		public ActionPartsBodyScale(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
