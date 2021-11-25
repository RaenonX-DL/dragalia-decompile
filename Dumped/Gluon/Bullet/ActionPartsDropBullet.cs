using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsDropBullet : ActionParts
	{
		private readonly DropBulletData _partsData;

		protected Vector3 _position;

		protected Quaternion _rotation;

		private ActionPartsBulletHitAttribute attr;

		public ActionPartsDropBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected BulletDataClone CreateBulletData()
		{
			return null;
		}

		protected void Setup()
		{
		}
	}
}
