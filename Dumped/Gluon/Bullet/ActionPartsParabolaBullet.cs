using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsParabolaBullet : ActionParts
	{
		private struct StartActionParam
		{
			public CommonObjectStatus target;

			public Vector3 initialPosition;

			public Vector3 initialDirection;

			public void Clear()
			{
			}
		}

		private readonly ParabolaBulletData _partsData;

		protected Vector3 _position;

		protected Quaternion _rotation;

		private string _hitAttrLabel;

		private ActionPartsBulletHitAttribute attr;

		private StartActionParam _startActionParam;

		public ActionPartsParabolaBullet(Gluon.ActionData.ActionParts resource)
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

		private CharacterBase GetTargetForAimCharacter()
		{
			return null;
		}
	}
}
