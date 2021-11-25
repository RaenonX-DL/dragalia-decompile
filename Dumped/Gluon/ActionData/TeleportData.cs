using System;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TeleportData : ActionParts.PartsData
	{
		public enum ActionType
		{
			Oriented,
			Random,
			Fixed,
			Veering
		}

		public enum AnchorType
		{
			Target,
			Self,
			PivotBase,
			GroundZero,
			CenterUnit,
			AreaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private ActionType _actionType;

		[SerializeField]
		[HideInInspector]
		private AnchorType _anchorType;

		[SerializeField]
		[HideInInspector]
		private float _angle;

		[SerializeField]
		[HideInInspector]
		private float _distanceMin;

		[SerializeField]
		[HideInInspector]
		private float _distanceMax;

		[SerializeField]
		[HideInInspector]
		private float _popOfsY;

		[SerializeField]
		[HideInInspector]
		private bool _adjustPosY;

		[SerializeField]
		[HideInInspector]
		private Vector3 _fixedOffset;

		[SerializeField]
		[HideInInspector]
		private bool _isSyncHostTargetPos;

		[SerializeField]
		[HideInInspector]
		private bool _targetCorrection;

		[SerializeField]
		[HideInInspector]
		private bool _isChangeRoom;

		[SerializeField]
		[HideInInspector]
		private WarpRoom.RoomGroup _roomGroup;

		[SerializeField]
		[HideInInspector]
		private bool _radiusIncludeSub;

		[SerializeField]
		[HideInInspector]
		private bool _checkSafeArea;

		public ActionType actionType => default(ActionType);

		public AnchorType anchorType => default(AnchorType);

		public float angle => default(float);

		public float distanceMin => default(float);

		public float distanceMax => default(float);

		public float popOfsY => default(float);

		public bool adjustPosY => default(bool);

		public Vector3 fixedOffset => default(Vector3);

		public bool isSyncHostTargetPos => default(bool);

		public bool targetCorrection => default(bool);

		public bool isChangeRoom => default(bool);

		public WarpRoom.RoomGroup roomGroup => default(WarpRoom.RoomGroup);

		public bool radiusIncludeSub => default(bool);

		public bool checkSafeArea => default(bool);
	}
}
