using System;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class CondensBulletObject : BulletObjectWithMarker
	{
		[Serializable]
		public class MineData
		{
			public string hitAttrLabel
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

			public float range
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

			public float ignitionTime
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

			public int explodeEffTrig
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float explodingTime
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

			public string explodeSeName
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

			public ChargeMarker.eColorType markerColor
			{
				[CompilerGenerated]
				get
				{
					return default(ChargeMarker.eColorType);
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private enum MineState
		{
			Init,
			Fuse,
			Explode,
			Exploding
		}

		private MineData _minedata;

		private MineState _minestate;

		private CollisionHitAttribute _mineHitAttribute;

		private ChargeMarker _mineMarker;

		private float _mineRestTime;

		private string _impactSeName;

		protected override void Clear()
		{
		}

		public void Initialize(CharacterBase owner, CommonObjectStatus target, int traceDelay, string hitAttrLabel, MarkerData markerData, MineData minedata, Vector3 position, string impactSeName)
		{
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

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}
	}
}
