using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsBulletWithMarker : ActionParts
	{
		public enum GenerateType
		{
			Owner,
			RegisteredPos
		}

		private readonly BulletWithMarkerData _partsData;

		protected Vector3 _position;

		protected Quaternion _rotation;

		private ActionPartsBulletHitAttribute attr;

		private int _appearChildTaskId;

		private RunActionBulletParameter _runActionParam;

		public ActionPartsBulletWithMarker(Gluon.ActionData.ActionParts resource)
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

		public static void SetBulletEffect(BulletWithMarkerData data, CharacterBase owner, ref BulletDataClone bulletData)
		{
		}

		private void SetGenerateInfo(out Vector3 position)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}
	}
}
