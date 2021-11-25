using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsDeathTimer : ActionParts
	{
		public enum ProcType
		{
			Give,
			TimeMarker
		}

		private readonly DeathTimerData _partsData;

		public ActionPartsDeathTimer(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		private void CreateTimeMarker(DeathTimerUniqueCtrl ctrl)
		{
		}
	}
}
