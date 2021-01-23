/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;
using UnityEngine.Serialization;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class WarpRoom : Warp
	{
		// Fields
		[SerializeField]
		protected DirectionSettingType directionSettingType;
		public RoomGroup roomGroupType;
		public DoorKind doorKind;
		public bool enableLockWarp;
		[FormerlySerializedAs]
		public bool setUnitRoomGroupFlag;
		private static List<WarpRoom> warpRoomList;
		[CompilerGenerated]
		private bool _IsClosed_k__BackingField;
		protected static readonly string[] effectLabelArray;
		protected static readonly int effectTriggerEnable;
		protected static readonly int effectTriggerDisable;
	
		// Properties
		public bool IsClosed { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum DirectionSettingType
		{
			Default = 0,
			Agito_Shadow = 1,
			Raid_Morsayati = 2,
			BattleRoyale = 3
		}
	
		public enum RoomGroup
		{
			GroupNone = -1,
			GroupA = 0,
			GroupB = 1,
			GroupC = 2,
			GroupD = 3,
			GroupE = 4,
			GroupF = 5,
			GroupG = 6,
			GroupH = 7,
			EnumMax = 8
		}
	
		public enum DoorKind
		{
			Entrance = 0,
			Exit = 1,
			EnumMax = 2
		}
	
		// Constructors
		public WarpRoom();
		static WarpRoom();
	
		// Methods
		public override void SetEnableWarp(bool enableFlag);
		private void SetDirectionData(DirectionSettingType type);
		protected override void OnDestroy();
		protected override void InitJumpToTransform();
		public static WarpRoom GetWarpRoom(RoomGroup roomType, DoorKind doorKind);
		public static void SetEnableRoom(RoomGroup roomType, DoorKind doorKind, bool enableFlag);
		public static void SetWarp(RoomGroup roomType, DoorKind doorKind, CharacterBase chara, bool checkIsDead, bool isForceReturn = false);
		public override void OnFinishWarp();
		public static void SetWarpForceReturn(RoomGroup roomType, bool checkIsDead = false);
		public override void OnTriggerEnter(Collider other);
		protected override void AddWarpedCharaList(CharacterBase chara);
		protected override void SetWarpedCharaDataPre(TargetData targetData);
	}
}
