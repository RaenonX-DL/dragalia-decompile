using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsFireStockBullet : ActionPartsBullet
	{
		private const int defaultBulletDataMax = 10;

		private readonly FireStockBulletData _partsData;

		private BulletDataClone[] _bulletData;

		private List<Vector3> bulletPositions;

		public ActionPartsFireStockBullet(Gluon.ActionData.ActionParts resource)
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

		protected override void OnFinish()
		{
		}

		private void SetupBulletData(int index)
		{
		}

		private void CalculateTransform(int index)
		{
		}

		private void FireStockBullet(int bulletCount)
		{
		}

		private Vector3 StockBulletOriginalPosition(int index)
		{
			return default(Vector3);
		}
	}
}
