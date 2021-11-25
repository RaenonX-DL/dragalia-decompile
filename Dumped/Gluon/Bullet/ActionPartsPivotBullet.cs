using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsPivotBullet : ActionParts
	{
		public enum BaseAxisType
		{
			World,
			AreaAnchor,
			Owner,
			OwnerGround,
			Target,
			TargetGround,
			MultiP1,
			MultiP2,
			MultiP3,
			MultiP4
		}

		private readonly PivotBulletData _partsData;

		private string _hitAttrLabel;

		private ActionPartsBulletHitAttribute attr;

		public ActionPartsPivotBullet(Gluon.ActionData.ActionParts resource)
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

		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label)
		{
			return null;
		}

		private Vector3 CalcAnchorPosition(BaseAxisType type, CommonObjectStatus target, out Transform anchor_transform)
		{
			return default(Vector3);
		}

		private bool GetTargetCharacter(BaseAxisType type, out CommonObjectStatus target)
		{
			return default(bool);
		}
	}
}
