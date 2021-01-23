/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class FireStockBulletData : BulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private FirePositionPattern _firePositionPattern;
		[HideInInspector]
		[SerializeField]
		private FireStockPattern _fireStockPattern;
		[HideInInspector]
		[SerializeField]
		private float _baseInterval;
		[HideInInspector]
		[SerializeField]
		private float _maxWidth;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private float _pitch;
		[HideInInspector]
		[SerializeField]
		private float _fireAngle;
		[HideInInspector]
		[SerializeField]
		private float[] _delayFireSec;
		[HideInInspector]
		[SerializeField]
		private int _bulletNum;
		[HideInInspector]
		[SerializeField]
		private Vector3 _uniqueOffsetPos;
		[HideInInspector]
		[SerializeField]
		private bool _useInterpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve[] _interpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private bool _removeStockBulletOnFinish;
	
		// Properties
		public FirePositionPattern firePositionPattern { get; }
		public FireStockPattern fireStockPattern { get; }
		public float baseInterval { get; }
		public float maxWidth { get; }
		public float radius { get; }
		public float pitch { get; }
		public float fireAngle { get; }
		public float[] delayFireSec { get; }
		public int bulletNum { get; }
		public Vector3 uniqueOffsetPos { get; }
		public bool useInterpolationAngleCurve { get; }
		public AnimationCurve[] interpolationAngleCurve { get; }
		public bool removeStockBulletOnFinish { get; }
	
		// Nested types
		public enum FirePositionPattern
		{
			None = 0,
			Horizontal = 1,
			Radial = 2,
			Circle = 3
		}
	
		public enum FireStockPattern
		{
			None = 0,
			StockBullet = 1,
			BuffCount = 2,
			SpecifiedNum = 3,
			ButterflyNum = 4
		}
	
		// Constructors
		public FireStockBulletData();
	}
}
