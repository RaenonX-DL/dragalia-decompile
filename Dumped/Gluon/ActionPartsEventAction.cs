using Gluon.ActionData;
using Gluon.Event;
using UnityEngine.Events;

namespace Gluon
{
	public class ActionPartsEventAction : ActionParts
	{
		private readonly EventActionData _partsData;

		private UnityEvent _resEvent;

		private RunActionIntParameter _runActionParam;

		public ActionPartsEventAction(Gluon.ActionData.ActionParts resource)
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

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		private void OnResponceEvent()
		{
		}
	}
}
