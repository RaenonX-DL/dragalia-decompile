using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gluon.Dungeon.Gimmick
{
	public class WarpRoom : Warp
	{
		public enum DirectionSettingType
		{
			Default,
			Agito_Shadow,
			Raid_Morsayati,
			BattleRoyale
		}

		public enum RoomGroup
		{
			GroupNone = -1,
			GroupA,
			GroupB,
			GroupC,
			GroupD,
			GroupE,
			GroupF,
			GroupG,
			GroupH,
			EnumMax
		}

		public enum DoorKind
		{
			Entrance,
			Exit,
			EnumMax
		}

		[SerializeField]
		protected DirectionSettingType directionSettingType;

		public RoomGroup roomGroupType;

		public DoorKind doorKind;

		public bool enableLockWarp;

		[FormerlySerializedAs("ignoreOutsideRoomBuffFlag")]
		public bool setUnitRoomGroupFlag;

		private static List<WarpRoom> warpRoomList;

		protected static readonly string[] effectLabelArray;

		protected static readonly int effectTriggerEnable;

		protected static readonly int effectTriggerDisable;

		public bool IsClosed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void SetEnableWarp(bool enableFlag)
		{
		}

		private void SetDirectionData(DirectionSettingType type)
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void InitJumpToTransform()
		{
		}

		public static WarpRoom GetWarpRoom(RoomGroup roomType, DoorKind doorKind)
		{
			return null;
		}

		public static void SetEnableRoom(RoomGroup roomType, DoorKind doorKind, bool enableFlag)
		{
		}

		public static void SetWarp(RoomGroup roomType, DoorKind doorKind, CharacterBase chara, bool checkIsDead, bool isForceReturn = false)
		{
		}

		public override void OnFinishWarp()
		{
		}

		public static void SetWarpForceReturn(RoomGroup roomType, bool checkIsDead = false)
		{
		}

		public override void OnTriggerEnter(Collider other)
		{
		}

		protected override void AddWarpedCharaList(CharacterBase chara)
		{
		}

		protected override void SetWarpedCharaDataPre(TargetData targetData)
		{
		}
	}
}
