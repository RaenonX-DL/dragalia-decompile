using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsNavigateNPC : ActionParts
	{
		private readonly NavigateNPCData _partsData;

		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;

		public ActionPartsNavigateNPC(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}
	}
}
