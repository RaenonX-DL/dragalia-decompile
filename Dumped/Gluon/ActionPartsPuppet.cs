using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsPuppet : ActionParts
	{
		public enum Mode
		{
			Boot,
			Abort,
			Setup
		}

		private readonly PuppetData _partsData;

		private PuppetMasterUniqueCtrl ctrl;

		public ActionPartsPuppet(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
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

		private void Setup()
		{
		}

		private void Boot()
		{
		}

		private void Abort()
		{
		}
	}
}
