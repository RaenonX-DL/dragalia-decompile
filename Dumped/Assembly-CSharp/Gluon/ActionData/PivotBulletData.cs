/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Bullet;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class PivotBulletData : BulletWithMarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsPivotBullet.BaseAxisType _baseAxis;
		[HideInInspector]
		[SerializeField]
		private Vector3 _anchorPos;
		[HideInInspector]
		[SerializeField]
		private float _pivotRadius;
		[HideInInspector]
		[SerializeField]
		private float _anchorForward;
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _collisionPosId;
		[HideInInspector]
		[SerializeField]
		private float _winchSpeed;
		[HideInInspector]
		[SerializeField]
		private bool _useMarker;
		[HideInInspector]
		[SerializeField]
		private bool _isUpdateAnchorPos;
		[HideInInspector]
		[SerializeField]
		private bool _isFinishHitTrap;
	
		// Properties
		public ActionPartsPivotBullet.BaseAxisType baseAxis { get; }
		public Vector3 anchorPos { get; }
		public float pivotRadius { get; }
		public float anchorForward { get; }
		public ActionCollisionPos collisionPosId { get; }
		public float winchSpeed { get; }
		public bool useMarker { get; }
		public bool isUpdateAnchorPos { get; }
		public bool isFinishHitTrap { get; }
	
		// Constructors
		public PivotBulletData();
	}
}
