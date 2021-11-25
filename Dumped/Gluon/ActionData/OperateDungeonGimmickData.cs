using System;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateDungeonGimmickData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateDungeonGimmick.GimmickType _gimmickType;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateDungeonGimmick.OperateType _operateType;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateDungeonGimmick.WarpTarget _warpTarget;

		[SerializeField]
		[HideInInspector]
		private WarpRoom.RoomGroup _roomGroup;

		[SerializeField]
		[HideInInspector]
		private WarpRoom.DoorKind _door;

		[SerializeField]
		[HideInInspector]
		private bool _isDeadmanWarp;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsOperateDungeonGimmick.GimmickType gimmickType => default(Gluon.ActionPartsOperateDungeonGimmick.GimmickType);

		public Gluon.ActionPartsOperateDungeonGimmick.OperateType operateType => default(Gluon.ActionPartsOperateDungeonGimmick.OperateType);

		public Gluon.ActionPartsOperateDungeonGimmick.WarpTarget warpTarget => default(Gluon.ActionPartsOperateDungeonGimmick.WarpTarget);

		public WarpRoom.RoomGroup roomGroup => default(WarpRoom.RoomGroup);

		public WarpRoom.DoorKind door => default(WarpRoom.DoorKind);

		public bool isDeadmanWarp => default(bool);

		public bool guarantee => default(bool);
	}
}
