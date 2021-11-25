using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public static class HitAttributeCrcUtil
	{
		public enum GroupType
		{
			Player,
			Enemy,
			Common
		}

		private class GroupData
		{
			public List<uint> Crc32List;

			public Dictionary<uint, int> Crc32ToIndexTable;

			public GroupData(int capacity)
			{
			}
		}

		private static Dictionary<GroupType, GroupData> _crcCache;

		public static uint GetCrc32FromHitAttributeIndex(GroupType type, int index)
		{
			return default(uint);
		}

		public static int GetHitAttributeIndexFromCrc32(GroupType type, uint crc32)
		{
			return default(int);
		}

		public static string GetHitAttributeLabelFromCrc32(GroupType type, uint crc32)
		{
			return null;
		}

		public static uint GetCrc32FromHitAttributeLabel(GroupType type, string label)
		{
			return default(uint);
		}

		public static void Reload()
		{
		}

		private static void Reload(PlayerActionHitAttribute playerActionHitAttr)
		{
		}

		private static void Reload(EnemyActionHitAttribute enemyActionHitAttr)
		{
		}

		private static void Reload(CommonActionHitAttribute commonActionHitAttr)
		{
		}
	}
}
