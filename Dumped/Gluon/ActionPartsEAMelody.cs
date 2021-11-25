using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsEAMelody : ActionParts
	{
		public enum OperateType
		{
			FirstSet,
			Switch
		}

		private readonly EAMelodyData _partsData;

		public ActionPartsEAMelody(Gluon.ActionData.ActionParts resource)
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
	}
}
