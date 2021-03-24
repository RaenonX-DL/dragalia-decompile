/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class HitAttributeCrcUtil
	{
		// Fields
		private static Dictionary<GroupType, GroupData> _crcCache;
	
		// Nested types
		public enum GroupType
		{
			Player = 0,
			Enemy = 1,
			Common = 2
		}
	
		private class GroupData
		{
			// Fields
			public List<uint> Crc32List;
			public Dictionary<uint, int> Crc32ToIndexTable;
	
			// Constructors
			public GroupData(int capacity);
		}
	
		// Constructors
		static HitAttributeCrcUtil();
	
		// Methods
		public static uint GetCrc32FromHitAttributeIndex(GroupType type, int index);
		public static int GetHitAttributeIndexFromCrc32(GroupType type, uint crc32);
		public static string GetHitAttributeLabelFromCrc32(GroupType type, uint crc32);
		public static uint GetCrc32FromHitAttributeLabel(GroupType type, string label);
		public static void Reload();
		private static void Reload(PlayerActionHitAttribute playerActionHitAttr);
		private static void Reload(EnemyActionHitAttribute enemyActionHitAttr);
		private static void Reload(CommonActionHitAttribute commonActionHitAttr);
	}
}
