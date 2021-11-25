using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsEAPowerCrystal : ActionParts
	{
		public enum ConditionType
		{
			FirstSet,
			Switch
		}

		private readonly EAPowerCrystalData _partsData;

		public ActionPartsEAPowerCrystal(Gluon.ActionData.ActionParts resource)
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
