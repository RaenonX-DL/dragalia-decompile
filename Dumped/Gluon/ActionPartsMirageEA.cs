using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsMirageEA : ActionParts
	{
		private readonly MirageEAData _partsData;

		private EnemyCharacter.CallMinionInfo callMinionInfo;

		private int currentHp;

		private RunActionIntParameter setupHpParam;

		public ActionPartsMirageEA(Gluon.ActionData.ActionParts resource)
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
