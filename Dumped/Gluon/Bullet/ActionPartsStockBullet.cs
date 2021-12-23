using System;
using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsStockBullet : ActionPartsBullet
	{
		private readonly StockBulletData _partsData;

		private Action<StockBulletObject> onGeneratedStockBulletObjectAction;

		public ActionPartsStockBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
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
