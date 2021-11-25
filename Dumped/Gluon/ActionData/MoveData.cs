using System;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveData : ActionParts.PartsData
	{
		public enum MoveStyle
		{
			Normal,
			SafeCollider,
			Ignore,
			Teleport,
			ThroughChara,
			ToWall
		}

		public enum Orientation
		{
			Center,
			FrontSide,
			BackSide,
			RightSide,
			LeftSide,
			NearPlayer,
			Pivot,
			AreaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private Vector3 _position;

		[SerializeField]
		[HideInInspector]
		private bool _pushOut;

		[SerializeField]
		[HideInInspector]
		private bool _autoDash;

		[SerializeField]
		[HideInInspector]
		private bool _chargeMarker;

		[SerializeField]
		[HideInInspector]
		private float _gravity;

		[SerializeField]
		[HideInInspector]
		private bool _isLookToTarget;

		[SerializeField]
		[HideInInspector]
		private MoveStyle _moveStyle;

		[SerializeField]
		[HideInInspector]
		private Orientation _teleportPosition;

		[SerializeField]
		[HideInInspector]
		private Orientation _teleportDirection;

		[SerializeField]
		[HideInInspector]
		private float _distance;

		[SerializeField]
		[HideInInspector]
		private bool _isChangeRoom;

		[SerializeField]
		[HideInInspector]
		private WarpRoom.RoomGroup _roomGroup;

		public Vector3 position => default(Vector3);

		public bool pushOut => default(bool);

		public bool autoDash => default(bool);

		public bool isMoveToChargeMarker => default(bool);

		public float gravity => default(float);

		public bool isLookToTarget => default(bool);

		public MoveStyle moveStyle => default(MoveStyle);

		public Orientation teleportPosition => default(Orientation);

		public Orientation teleportDirection => default(Orientation);

		public float distance => default(float);

		public bool isChangeRoom => default(bool);

		public WarpRoom.RoomGroup roomGroup => default(WarpRoom.RoomGroup);
	}
}
