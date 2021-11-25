using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class PlayerBulletDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Detail;

		[SerializeField]
		private string _ObjectUid;

		[SerializeField]
		private string _ImageAtlsID;

		[SerializeField]
		private float _Scale;

		[SerializeField]
		private int _IsDirRot;

		[SerializeField]
		private string _EffectID;

		[SerializeField]
		private int _EffEmissionEnd;

		[SerializeField]
		private int _IsClipping;

		[SerializeField]
		private float _FirePosOfsX;

		[SerializeField]
		private float _FirePosOfsY;

		[SerializeField]
		private float _FirePosOfsZ;

		[SerializeField]
		private float _FireAngleX;

		[SerializeField]
		private float _FireAngleY;

		[SerializeField]
		private float _FireAngleZ;

		[SerializeField]
		private float _Speed;

		[SerializeField]
		private float _AccelSpeed;

		[SerializeField]
		private float _Duration;

		[SerializeField]
		private float _Distance;

		[SerializeField]
		private float _StartSec;

		[SerializeField]
		private float _HomingAngle;

		[SerializeField]
		private float _HomingStSec;

		[SerializeField]
		private float _HomingEdSec;

		[SerializeField]
		private float _CollisionSize;

		[SerializeField]
		private float _ExplosionSize;

		[SerializeField]
		private float _RotTime;

		[SerializeField]
		private float _WaitTime;

		[SerializeField]
		private string _HitAttr;

		[SerializeField]
		private int _HitDelete;

		[SerializeField]
		private int _HitGroundDelete;

		[SerializeField]
		private int _HitWallDelete;

		[SerializeField]
		private float _IntervalHitTime;

		[SerializeField]
		private string _MuzzleEff;

		[SerializeField]
		private string _HitEff;

		[SerializeField]
		private string _EmitEffId;

		[SerializeField]
		private float _EmitEffDuration;

		[SerializeField]
		private float _EmitEffOfsZ;

		[SerializeField]
		private string _SEFire;

		[SerializeField]
		private string _SEHit;

		public int Id => default(int);

		public string Name => null;

		public string Detail => null;

		public string ObjectUid => null;

		public string ImageAtlsID => null;

		public float Scale => default(float);

		public int IsDirRot => default(int);

		public string EffectID => null;

		public int EffEmissionEnd => default(int);

		public int IsClipping => default(int);

		public float FirePosOfsX => default(float);

		public float FirePosOfsY => default(float);

		public float FirePosOfsZ => default(float);

		public float FireAngleX => default(float);

		public float FireAngleY => default(float);

		public float FireAngleZ => default(float);

		public float Speed => default(float);

		public float AccelSpeed => default(float);

		public float Duration => default(float);

		public float Distance => default(float);

		public float StartSec => default(float);

		public float HomingAngle => default(float);

		public float HomingStSec => default(float);

		public float HomingEdSec => default(float);

		public float CollisionSize => default(float);

		public float ExplosionSize => default(float);

		public float RotTime => default(float);

		public float WaitTime => default(float);

		public string HitAttr => null;

		public int HitDelete => default(int);

		public int HitGroundDelete => default(int);

		public int HitWallDelete => default(int);

		public float IntervalHitTime => default(float);

		public string MuzzleEff => null;

		public string HitEff => null;

		public string EmitEffId => null;

		public float EmitEffDuration => default(float);

		public float EmitEffOfsZ => default(float);

		public string SEFire => null;

		public string SEHit => null;
	}
}
