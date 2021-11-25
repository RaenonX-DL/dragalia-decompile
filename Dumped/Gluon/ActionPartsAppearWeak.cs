using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsAppearWeak : ActionPartsAppearEnemy
	{
		private readonly AppearWeakData _partsData;

		private int currentHp;

		private RunActionIntParameter reviveHpParam;

		public ActionPartsAppearWeak(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		protected override void OnStart()
		{
		}
	}
}
