using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsSettingHit : ActionParts
	{
		private readonly SettingHitData _partsData;

		private readonly long _partsDataId;

		private Vector3 _position;

		private Quaternion _rotation;

		private Vector3 _offsetPos;

		private Vector3 _offsetRot;

		private ActionPartsBulletHitAttribute hitAttr;

		private int actionProductId;

		private RunActionIntParameter actionProductIdParam;

		private string hitAttrLabel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ActionPartsSettingHit(Gluon.ActionData.ActionParts resource, long resourceId)
		{
		}

		public override void Initialize(CharacterBase chara)
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

		protected virtual void Fire()
		{
		}

		private void CalculateTransform(Vector3 pos, Vector3 dir, SettingHitObject.BasePosition basePosition, float collisionParams01, float nearest)
		{
		}

		private Quaternion CalculateFireDirection(SettingHitObject.BasePosition basePosition, CommonObjectStatus target)
		{
			return default(Quaternion);
		}

		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label)
		{
			return null;
		}

		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label)
		{
		}

		private bool IsBuffField(string hitLabel)
		{
			return default(bool);
		}
	}
}
