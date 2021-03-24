/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveTargetData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AimType _aim;
		[HideInInspector]
		[SerializeField]
		private TranslateType _translate;
		[HideInInspector]
		[SerializeField]
		private float _moveSpeed;
		[HideInInspector]
		[SerializeField]
		private float _turnSpeed;
		[HideInInspector]
		[SerializeField]
		private bool _isFixPosition;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offset;
	
		// Properties
		public AimType aim { get; }
		public TranslateType translate { get; }
		public float moveSpeed { get; }
		public float turnSpeed { get; }
		public bool isFixPosition { get; }
		public Vector3 offset { get; }
	
		// Nested types
		public enum AimType
		{
			Target = 0,
			Marker = 1,
			StageCenter = 2,
			Pivot = 3,
			Registered = 4,
			RegisteredGround = 5,
			CenterEnemy = 6,
			Summoner = 7
		}
	
		public enum TranslateType
		{
			Speed_2D = 0,
			Time_2D = 1,
			Speed_3D = 2,
			Time_3D = 3
		}
	
		// Constructors
		public MoveTargetData();
	}
}
