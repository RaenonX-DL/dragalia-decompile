using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsChangeMeshOfPartsEnemy : ActionParts
	{
		public enum PartsIndex
		{
			PartsA = 1,
			PartsB,
			PartsC,
			PartsD
		}

		private readonly ChangeMeshOfPartsEnemyData _partsData;

		public ActionPartsChangeMeshOfPartsEnemy(Gluon.ActionData.ActionParts resource)
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

		private void Procedure()
		{
		}
	}
}
