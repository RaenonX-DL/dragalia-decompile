using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsStockBullet : ActionPartsBullet
	{
		private readonly StockBulletData _partsData;

		public ActionPartsStockBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void Fire()
		{
		}

		public override int[] GetActionIdsForLoad()
		{
			return null;
		}
	}
}
