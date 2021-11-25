using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsGameMasterEvent : ActionParts
	{
		private readonly GameMasterEventData _partsData;

		private GameMasterUniqueCtrl _gm;

		private int _nextEvent;

		private string _egLabel;

		private RunActionGameMasterEvent tmpSetupParam;

		private bool _isDone;

		public ActionPartsGameMasterEvent(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void ProcCommand()
		{
		}

		private void ProcTurn()
		{
		}

		private void ProcCompleteTurn()
		{
		}

		private void ProcSudden()
		{
		}

		private void ProcBandit()
		{
		}
	}
}
