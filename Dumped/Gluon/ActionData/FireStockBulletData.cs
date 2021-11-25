using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FireStockBulletData : BulletData
	{
		public enum FirePositionPattern
		{
			None,
			Horizontal,
			Radial,
			Circle
		}

		public enum FireStockPattern
		{
			None,
			StockBullet,
			BuffCount,
			SpecifiedNum,
			ButterflyNum,
			DuplicatedBuffCount,
			PartyAuraLevel
		}

		[SerializeField]
		[HideInInspector]
		private FirePositionPattern _firePositionPattern;

		[SerializeField]
		[HideInInspector]
		private FireStockPattern _fireStockPattern;

		[SerializeField]
		[HideInInspector]
		private int _fireMaxCount;

		[SerializeField]
		[HideInInspector]
		private float _baseInterval;

		[SerializeField]
		[HideInInspector]
		private float _maxWidth;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private float _pitch;

		[SerializeField]
		[HideInInspector]
		private float _fireAngle;

		[SerializeField]
		[HideInInspector]
		private float[] _delayFireSec;

		[SerializeField]
		[HideInInspector]
		private int _bulletNum;

		[SerializeField]
		[HideInInspector]
		private Vector3 _uniqueOffsetPos;

		[SerializeField]
		[HideInInspector]
		private bool _useInterpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve[] _interpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private bool _removeStockBulletOnFinish;

		public FirePositionPattern firePositionPattern => default(FirePositionPattern);

		public FireStockPattern fireStockPattern => default(FireStockPattern);

		public int fireMaxCount => default(int);

		public float baseInterval => default(float);

		public float maxWidth => default(float);

		public float radius => default(float);

		public float pitch => default(float);

		public float fireAngle => default(float);

		public float[] delayFireSec => null;

		public int bulletNum => default(int);

		public Vector3 uniqueOffsetPos => default(Vector3);

		public bool useInterpolationAngleCurve => default(bool);

		public AnimationCurve[] interpolationAngleCurve => null;

		public bool removeStockBulletOnFinish => default(bool);
	}
}
