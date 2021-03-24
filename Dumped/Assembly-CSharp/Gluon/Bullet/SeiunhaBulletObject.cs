/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class SeiunhaBulletObject : BulletBase
	{
		// Fields
		private State _state;
		[CompilerGenerated]
		private bool _active_k__BackingField;
		private CharacterBase _owner;
		private int _actionId;
		[CompilerGenerated]
		private float _bulletSpeed_k__BackingField;
		private Vector3 _direction;
		[CompilerGenerated]
		private CharacterBase _targetOrignal_k__BackingField;
		[CompilerGenerated]
		private float _lifeTime_k__BackingField;
		[CompilerGenerated]
		private float _afterglowTime_k__BackingField;
		private float _timer;
		private CollisionHitAttribute _hitAttribute;
		private CollisionHitAttribute _hitAttributeExplosion;
		private HitException _hitException;
		private float _radius;
		[CompilerGenerated]
		private float _scaleSpeed_k__BackingField;
		[CompilerGenerated]
		private float _radiusMax_k__BackingField;
		private bool _isReturning;
		private EffectObject _effectObject;
		private string _effectName;
		private string _seFire;
		private string _seExplosion;
		private AudioPlayback _fireSeHandle;
		private int bulletUniqueId;
	
		// Properties
		public bool active { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bulletSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase targetOrignal { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float lifeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float afterglowTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float scaleSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float radiusMax { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum State
		{
			Idle = 0,
			Fire = 1,
			Move = 2,
			Return = 3,
			Explosion = 4,
			Afterglow = 5,
			Delete = 6
		}
	
		private enum EffectTrriger
		{
			Stop = 1,
			Bullet = 8,
			Explosion = 9
		}
	
		// Constructors
		public SeiunhaBulletObject();
	
		// Methods
		private void OnDestroy();
		protected override void OnDisable();
		private void Clear();
		public void Initialize(CharacterBase owner, int actionId, int skillId, int productId, InGameDef.CharacterType charaType, string hitAttrLabel, string hitAttrLabelExplosion, float radius, Vector3 offsetPos, float offsetDir);
		public override void FastUpdate();
		private void ProcMove();
		public void OnBringBack();
		private void ProcExplosion();
		protected void UpdateHoming();
		private bool IsPassedWall();
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public override void OnNotCollided(CharacterBase chara);
		public override bool IsExcept(CharacterBase chara);
		public void SetupEffect(string effName, string seFire, string seExplosion);
		private void PlayEffect();
		private void StopEffect();
		public void ForceDelete();
		private void Delete();
	}
}
