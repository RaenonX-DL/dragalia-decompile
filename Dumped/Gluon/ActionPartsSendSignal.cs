using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsSendSignal : ActionParts
	{
		private readonly SendSignalData _partsData;

		private bool _isStarted;

		private bool _isForceEnd;

		private RunActionIntParameter runActionIntParameter;

		public ActionPartsSendSignal(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		public override int[] GetActionIdsForLoad()
		{
			return null;
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void SendSignal(bool on, bool isActionEnd = false)
		{
		}

		public bool IsOnlyGuardCounter()
		{
			return default(bool);
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public bool NeedInspirationOnInitialize()
		{
			return default(bool);
		}
	}
}
