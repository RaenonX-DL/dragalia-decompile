using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.Dungeon
{
	public abstract class DungeonObjectBase : DungeonObjectStatus, ICollision
	{
		protected Animator anim;

		protected int idle;

		protected int open;

		public bool isTarget;

		public bool isPenetratable;

		public float hitRadius;

		public CharacterHitStopPlayer hitStopPlayer;

		public float radius
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual bool considerColliderOffsetHeight => default(bool);

		public Collider baseCollider
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

		protected virtual void Start()
		{
		}

		public float GetAnimationTime(int stateHash)
		{
			return default(float);
		}

		public float GetAnimationNormalizedTime(int stateHash)
		{
			return default(float);
		}

		public abstract void OnCollided(GameObject target, CollisionHitAttribute data);

		protected void SetTargetInvalid()
		{
		}

		protected void SetTargetValid()
		{
		}

		protected bool IsFinishAnimator()
		{
			return default(bool);
		}

		protected Transform GetHitCharacterTransform(GameObject obj)
		{
			return null;
		}

		public static void DisplaySystemMessage(Localize.TextId id)
		{
		}

		public static void DisplaySystemMessageOpen(Localize.TextId id, bool se = true)
		{
		}

		public static void DisplaySystemMessageClose()
		{
		}

		public float GetColliderHeight()
		{
			return default(float);
		}
	}
}
