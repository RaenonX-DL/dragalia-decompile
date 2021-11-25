using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ThunderballObject : BulletBase
	{
		private enum State
		{
			Idle,
			Start,
			Run,
			LastSpark,
			Delete
		}

		private enum EffectTrriger
		{
			Stop = 1,
			Spawn = 8,
			Odd = 9,
			Even = 10
		}

		private State _state;

		private CharacterBase _owner;

		private int _actionId;

		private float _lifeTime;

		private float _timer;

		private int _sparkTimes;

		private int _sparkCount;

		private float _sparkInterval;

		private float _interval;

		private CollisionHitAttribute _hitAttribute;

		private CollisionHitAttribute _hitAttributeSpark;

		private HitException _hitException;

		private EffectObject _effectObject;

		private string _effectName;

		private string _seSpawn;

		private string _seDischarge;

		private int bulletUniqueId;

		private ChargeMarker[] _marker;

		public float collisionHitInterval
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

		private void Clear()
		{
		}

		public void Initialize(CharacterBase owner, int actionId, int skillId, int productId, InGameDef.CharacterType charaType, string hitAttrLabel, float radius, float lifetime, Vector3 sparkSize, int sparktimes)
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateSpark()
		{
		}

		private void OnSpark()
		{
		}

		private void CreateSparkMarker()
		{
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

		public void SetupEffect(string effName, string seSpawn, string seDischarge)
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
	}
}
