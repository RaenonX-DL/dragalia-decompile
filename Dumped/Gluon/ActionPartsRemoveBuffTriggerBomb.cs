using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsRemoveBuffTriggerBomb : ActionParts
	{
		private readonly RemoveBuffTriggerBombData _partsData;

		private CharacterBuffTriggerReactionBomb _reaction;

		public ActionPartsRemoveBuffTriggerBomb(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		private string ConvertHitAttributeForPlayer(string label)
		{
			return null;
		}
	}
}
