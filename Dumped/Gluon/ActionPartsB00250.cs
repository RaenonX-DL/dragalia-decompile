using System.Collections.Generic;
using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsB00250 : ActionParts
	{
		private enum State
		{
			init,
			attack,
			retreat
		}

		private readonly B00250Data _partsData;

		private State _state;

		private StoneSatelliteUniqueCtrl _ctrl;

		private List<CharacterBase> _attackChild;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		public ActionPartsB00250(Gluon.ActionData.ActionParts resource)
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

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private bool UpdateAttack()
		{
			return default(bool);
		}

		private bool UpdateRetreat()
		{
			return default(bool);
		}

		private List<CharacterBase> GetTargetCharas()
		{
			return null;
		}
	}
}
