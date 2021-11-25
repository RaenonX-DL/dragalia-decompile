using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsSetupAlloutAssault : ActionParts
	{
		private readonly SetupAlloutAssaultData _partsData;

		private AlloutAssaultUniqueCtrl _ctrl;

		public ActionPartsSetupAlloutAssault(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		private CollisionHitAttribute CreateHitAttribute()
		{
			return null;
		}
	}
}
