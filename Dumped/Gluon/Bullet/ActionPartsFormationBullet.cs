using Gluon.ActionData;
using Gluon.Event;

namespace Gluon.Bullet
{
	public class ActionPartsFormationBullet : ActionPartsBullet
	{
		private readonly int childNumMax;

		private readonly FormationBulletData _partsData;

		private BulletDataClone[] _bulletData;

		private int actionProductId;

		private RunActionCompositeParameter _compositeParam;

		private RunActionIntParameter _actionProductIdParam;

		public ActionPartsFormationBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
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
	}
}
