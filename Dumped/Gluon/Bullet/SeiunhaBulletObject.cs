using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon.Bullet
{
	public class SeiunhaBulletObject : BulletBase
	{
		private enum State
		{
			Idle,
			Fire,
			Move,
			Return,
			Explosion,
			Afterglow,
			Delete
		}

		private enum EffectTrriger
		{
			Stop = 1,
			Bullet = 8,
			Explosion = 9
		}

		private State _state;

		private CharacterBase _owner;

		private int _actionId;

		private Vector3 _direction;

		private float _timer;

		private CollisionHitAttribute _hitAttribute;

		private CollisionHitAttribute _hitAttributeExplosion;

		private HitException _hitException;

		private float _radius;

		private bool _isReturning;

		private EffectObject _effectObject;

		private string _effectName;

		private string _seFire;

		private string _seExplosion;

		private AudioPlayback _fireSeHandle;

		private int bulletUniqueId;

		public bool active
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float bulletSpeed
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

		public CharacterBase targetOrignal
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

		public float lifeTime
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

		public float afterglowTime
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

		public float scaleSpeed
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

		public float radiusMax
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

		private void OnDestroy()
		{
		}

		protected override void OnDisable()
		{
		}

		private void Clear()
		{
		}

		public void Initialize(CharacterBase owner, int actionId, int skillId, int productId, InGameDef.CharacterType charaType, string hitAttrLabel, string hitAttrLabelExplosion, float radius, Vector3 offsetPos, float offsetDir)
		{
		}

		public override void FastUpdate()
		{
		}

		private void ProcMove()
		{
		}

		public void OnBringBack()
		{
		}

		private void ProcExplosion()
		{
		}

		protected void UpdateHoming()
		{
		}

		private bool IsPassedWall()
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public override void OnNotCollided(CharacterBase chara)
		{
		}

		public override bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public void SetupEffect(string effName, string seFire, string seExplosion)
		{
		}

		private void PlayEffect()
		{
		}

		private void StopEffect()
		{
		}

		public void ForceDelete()
		{
		}

		private void Delete()
		{
		}
	}
}
