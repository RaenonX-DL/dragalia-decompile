using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsHypnosWatchWind : ActionParts
	{
		private readonly HypnosWatchWindData _partsData;

		private bool _hasExistedSub;

		public ActionPartsHypnosWatchWind(Gluon.ActionData.ActionParts resource)
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
