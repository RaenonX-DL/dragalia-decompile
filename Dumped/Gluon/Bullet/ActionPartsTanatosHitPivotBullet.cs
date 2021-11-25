using Gluon.ActionData;

namespace Gluon.Bullet
{
	public class ActionPartsTanatosHitPivotBullet : ActionParts
	{
		private readonly TanatosHitPivotBulletData _partsData;

		private string _hitAttrLabel;

		private ActionPartsBulletHitAttribute attr;

		public ActionPartsTanatosHitPivotBullet(Gluon.ActionData.ActionParts resource)
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

		private void Setup()
		{
		}
	}
}
