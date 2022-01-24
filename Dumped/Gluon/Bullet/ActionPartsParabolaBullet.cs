using System.Runtime.CompilerServices;
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

		private StartActionParam _startActionParam;

		private ActionPartsBulletHitAttribute _attr
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

		private ActionPartsBulletHitAttribute _abHitAttr
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

		public ActionPartsParabolaBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		private void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label)
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
