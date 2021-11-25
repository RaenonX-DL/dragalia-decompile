using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon.Bullet
{
	public class PivotBulletObject : BulletObjectWithMarker
	{
		private GameObject _anchor;

		private Action<HitException> _hitCallBack;

		public ActionPartsPivotBullet.BaseAxisType baseAxis
		{
			[CompilerGenerated]
			get
			{
				return default(ActionPartsPivotBullet.BaseAxisType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isUpdateAnchorPos
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

		public float anchorOffsetY
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CommonObjectStatus target
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool useMarker
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

		public float winchSpeed
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFinishHitTrap
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

		protected override void Clear()
		{
		}

		public bool Initialize(CharacterBase owner, CommonObjectStatus target_, string hitAttrLabel, Vector3 anchor_position, float pivotRadius, float anchorForward, Transform anchorTransform, [Optional] Action<HitException> hitCallBack)
		{
			return default(bool);
		}

		protected override bool State_Init()
		{
			return default(bool);
		}

		protected override bool State_Fire()
		{
			return default(bool);
		}

		protected override bool State_BulletRun()
		{
			return default(bool);
		}

		protected override bool State_End()
		{
			return default(bool);
		}

		private Vector3 UpdateAnchorPosition()
		{
			return default(Vector3);
		}
	}
}
