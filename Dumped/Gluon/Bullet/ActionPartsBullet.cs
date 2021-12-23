using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsBullet : ActionParts
	{
		private readonly BulletData _partsData;

		protected bool useInheritedFire;

		protected bool initInheritedHitAttr;

		protected Vector3 _position;

		protected Quaternion _rotation;

		protected Vector3 _offsetPos;

		protected Vector3 _directionEuler;

		protected CommonObjectStatus _target;

		private float _waitCount;

		protected const float TARGET_HEIGHT_MIN = 0.5f;

		private RandomXorshift _random;

		private RunActionBulletParameter _runActionParam;

		private bool skipMisfire;

		private int _appearChildTaskId;

		protected bool _isFireBulletReserved
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected ActionPartsBulletHitAttribute hitAttr
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

		protected ActionPartsBulletHitAttribute abHitAttr
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

		protected ActionPartsBulletHitAttribute[] addHitAttr
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

		protected string hitAttrLabel
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

		public ActionPartsBullet(Gluon.ActionData.ActionParts resource)
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

		protected virtual void Fire()
		{
		}

		public override void Clear()
		{
		}

		protected void CalculateTransform(BulletDataClone bulletData)
		{
		}

		protected void CalculateTransform(BulletData bulletData)
		{
		}

		protected void CalculateTransform(Vector3 pos, Vector3 dir, BulletData.GenerateStyle generateStyle, string generateNodeName, BulletObject.DirectionType directionType, float nearest, float collisionParams01, float generateNear, int loadPositionId)
		{
		}

		public static Quaternion CalculateFireDirection(BulletObject.DirectionType directionType, Vector3 position, CharacterBase owner, CommonObjectStatus target, float nearest, BulletData.GenerateStyle generateStyle, float generateNear, string targetDistinctionTag = "")
		{
			return default(Quaternion);
		}

		private bool Misfire()
		{
			return default(bool);
		}

		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label)
		{
			return null;
		}

		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label)
		{
		}

		protected void RegisterHitAttribute(InGameDef.CharacterType charaType, string label)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public override int[] GetActionIdsForLoad()
		{
			return null;
		}
	}
}
