/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Bullet;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class BindBulletData : BulletWithMarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private BindBulletObject.MoveType _moveType;
		[HideInInspector]
		[SerializeField]
		private ActionPartsBindBullet.GenerationPoint _generationPoint;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private float _bindHeight;
		[HideInInspector]
		[SerializeField]
		private string _releaseHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private int _releaseEffTrigger;
		[HideInInspector]
		[SerializeField]
		private float _bindingTime;
	
		// Properties
		public BindBulletObject.MoveType moveType { get; }
		public ActionPartsBindBullet.GenerationPoint generationPoint { get; }
		public Vector3 offsetPos { get; }
		public float bindHeight { get; }
		public string releaseHitAttrLabel { get; }
		public int releaseEffTrigger { get; }
		public float bindingTime { get; }
	
		// Constructors
		public BindBulletData();
	}
}
