/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Vector3 _position;
		[HideInInspector]
		[SerializeField]
		private bool _pushOut;
		[HideInInspector]
		[SerializeField]
		private bool _autoDash;
		[HideInInspector]
		[SerializeField]
		private bool _chargeMarker;
		[HideInInspector]
		[SerializeField]
		private float _gravity;
		[HideInInspector]
		[SerializeField]
		private bool _isLookToTarget;
		[HideInInspector]
		[SerializeField]
		private MoveStyle _moveStyle;
		[HideInInspector]
		[SerializeField]
		private Orientation _teleportPosition;
		[HideInInspector]
		[SerializeField]
		private Orientation _teleportDirection;
		[HideInInspector]
		[SerializeField]
		private float _distance;
		[HideInInspector]
		[SerializeField]
		private bool _isChangeRoom;
		[HideInInspector]
		[SerializeField]
		private WarpRoom.RoomGroup _roomGroup;
	
		// Properties
		public Vector3 position { get; }
		public bool pushOut { get; }
		public bool autoDash { get; }
		public bool isMoveToChargeMarker { get; }
		public float gravity { get; }
		public bool isLookToTarget { get; }
		public MoveStyle moveStyle { get; }
		public Orientation teleportPosition { get; }
		public Orientation teleportDirection { get; }
		public float distance { get; }
		public bool isChangeRoom { get; }
		public WarpRoom.RoomGroup roomGroup { get; }
	
		// Nested types
		public enum MoveStyle
		{
			Normal = 0,
			SafeCollider = 1,
			Ignore = 2,
			Teleport = 3,
			ThroughChara = 4,
			ToWall = 5
		}
	
		public enum Orientation
		{
			Center = 0,
			FrontSide = 1,
			BackSide = 2,
			RightSide = 3,
			LeftSide = 4,
			NearPlayer = 5,
			Pivot = 6,
			AreaAnchor = 7
		}
	
		// Constructors
		public MoveData();
	}
}
