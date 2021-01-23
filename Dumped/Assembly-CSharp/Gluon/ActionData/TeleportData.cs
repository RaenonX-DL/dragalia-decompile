/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class TeleportData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionType _actionType;
		[HideInInspector]
		[SerializeField]
		private AnchorType _anchorType;
		[HideInInspector]
		[SerializeField]
		private float _angle;
		[HideInInspector]
		[SerializeField]
		private float _distanceMin;
		[HideInInspector]
		[SerializeField]
		private float _distanceMax;
		[HideInInspector]
		[SerializeField]
		private float _popOfsY;
		[HideInInspector]
		[SerializeField]
		private bool _adjustPosY;
		[HideInInspector]
		[SerializeField]
		private Vector3 _fixedOffset;
		[HideInInspector]
		[SerializeField]
		private bool _isSyncHostTargetPos;
		[HideInInspector]
		[SerializeField]
		private bool _targetCorrection;
		[HideInInspector]
		[SerializeField]
		private bool _isChangeRoom;
		[HideInInspector]
		[SerializeField]
		private WarpRoom.RoomGroup _roomGroup;
		[HideInInspector]
		[SerializeField]
		private bool _radiusIncludeSub;
		[HideInInspector]
		[SerializeField]
		private bool _checkSafeArea;
	
		// Properties
		public ActionType actionType { get; }
		public AnchorType anchorType { get; }
		public float angle { get; }
		public float distanceMin { get; }
		public float distanceMax { get; }
		public float popOfsY { get; }
		public bool adjustPosY { get; }
		public Vector3 fixedOffset { get; }
		public bool isSyncHostTargetPos { get; }
		public bool targetCorrection { get; }
		public bool isChangeRoom { get; }
		public WarpRoom.RoomGroup roomGroup { get; }
		public bool radiusIncludeSub { get; }
		public bool checkSafeArea { get; }
	
		// Nested types
		public enum ActionType
		{
			Oriented = 0,
			Random = 1,
			Fixed = 2,
			Veering = 3
		}
	
		public enum AnchorType
		{
			Target = 0,
			Self = 1,
			PivotBase = 2,
			GroundZero = 3,
			CenterUnit = 4,
			AreaAnchor = 5
		}
	
		// Constructors
		public TeleportData();
	}
}
