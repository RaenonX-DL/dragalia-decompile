using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsCtrlSeiunha : ActionParts
	{
		public enum Order
		{
			Fire,
			BringBack
		}

		private readonly CtrlSeiunhaData _partsData;

		public ActionPartsCtrlSeiunha(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		private void Proc()
		{
		}

		private void Fire()
		{
		}

		private void BringBack()
		{
		}
	}
}
