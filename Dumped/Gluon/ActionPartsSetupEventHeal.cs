using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsSetupEventHeal : ActionParts
	{
		private readonly SetupEventHealData _partsData;

		private bool _isValid;

		public ActionPartsSetupEventHeal(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		private void Proc()
		{
		}

		private CollisionHitAttribute CreateHitAttribute()
		{
			return null;
		}
	}
}
