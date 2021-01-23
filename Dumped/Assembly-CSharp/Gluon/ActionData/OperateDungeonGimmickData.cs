/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateDungeonGimmickData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateDungeonGimmick.GimmickType _gimmickType;
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateDungeonGimmick.OperateType _operateType;
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateDungeonGimmick.WarpTarget _warpTarget;
		[HideInInspector]
		[SerializeField]
		private WarpRoom.RoomGroup _roomGroup;
		[HideInInspector]
		[SerializeField]
		private WarpRoom.DoorKind _door;
		[HideInInspector]
		[SerializeField]
		private bool _isDeadmanWarp;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsOperateDungeonGimmick.GimmickType gimmickType { get; }
		public ActionPartsOperateDungeonGimmick.OperateType operateType { get; }
		public ActionPartsOperateDungeonGimmick.WarpTarget warpTarget { get; }
		public WarpRoom.RoomGroup roomGroup { get; }
		public WarpRoom.DoorKind door { get; }
		public bool isDeadmanWarp { get; }
		public bool guarantee { get; }
	
		// Constructors
		public OperateDungeonGimmickData();
	}
}
