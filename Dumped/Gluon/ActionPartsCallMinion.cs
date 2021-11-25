using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsCallMinion : ActionParts
	{
		private readonly CallMinionData _partsData;

		private EnemyCharacter.CallMinionInfo callMinionInfo;

		private int taskId;

		private RunActionIntParameter taskIdParam;

		public ActionPartsCallMinion(Gluon.ActionData.ActionParts resource)
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

		private Vector3 CalcPopPos(ref Transform transBase)
		{
			return default(Vector3);
		}
	}
}
