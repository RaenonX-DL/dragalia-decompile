using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsMultiDropBulletRegisteredPos : ActionPartsDropBullet
	{
		private readonly MultiDropBulletRegisteredPosData _partsData;

		private BulletDataClone bulletData;

		private int _generateNum;

		private int _generateCnt;

		private float _delayTime;

		private int _hostileIdx;

		private string _hitAttrLabel;

		public ActionPartsMultiDropBulletRegisteredPos(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected bool CreateBullet()
		{
			return default(bool);
		}
	}
}
