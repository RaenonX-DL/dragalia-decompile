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
	public class LoiteringData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isTurnedMove;
		[HideInInspector]
		[SerializeField]
		private float _distance;
		[HideInInspector]
		[SerializeField]
		private MoveTarget _moveTarget;
		[HideInInspector]
		[SerializeField]
		private MoveType _moveType;
		[HideInInspector]
		[SerializeField]
		private float _idleDurationSec;
		[HideInInspector]
		[SerializeField]
		private string _moveMotion;
		[HideInInspector]
		[SerializeField]
		private float _delayMoveMotionSec;
		[HideInInspector]
		[SerializeField]
		private float _moveDurationSec;
		[HideInInspector]
		[SerializeField]
		private bool _isLoop;
	
		// Properties
		public bool isTurnedMove { get; }
		public float distance { get; }
		public MoveTarget moveTarget { get; }
		public MoveType moveType { get; }
		public float idleDurationSec { get; }
		public string moveMotion { get; }
		public float delayMoveMotionSec { get; }
		public float moveDurationSec { get; }
		public bool isLoop { get; }
	
		// Nested types
		public enum MoveTarget
		{
			random = 0,
			repeatMoveFB = 1,
			repeatMoveLR = 2
		}
	
		public enum MoveType
		{
			walkMove = 0,
			timeMove = 1,
			turningMove = 2
		}
	
		// Constructors
		public LoiteringData();
	}
}
