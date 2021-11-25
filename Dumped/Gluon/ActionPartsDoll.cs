using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsDoll : ActionParts
	{
		public enum Mode
		{
			Execute,
			Release,
			Field,
			FieldOff
		}

		public enum TargetType
		{
			ActionTarget,
			HandlingPlayer,
			ExceptHandlingPlayerInSameParty
		}

		private readonly DollData _partsData;

		private int[] _partyIdxs;

		private List<CharacterBase> _listTarget;

		private DollFieldUniqueCtrl _fieldCtrl;

		public ActionPartsDoll(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		private void Proc()
		{
		}

		private void Execute()
		{
		}

		private void Release()
		{
		}

		private void Field(bool on = true)
		{
		}

		private void CreateCtrlDoll(CharacterBase target, CharacterSelector targetSelector)
		{
		}

		private void GetTargetOnExecute()
		{
		}

		private void ExcludeOutOfRangeTargets(List<CharacterBase> targets)
		{
		}
	}
}
