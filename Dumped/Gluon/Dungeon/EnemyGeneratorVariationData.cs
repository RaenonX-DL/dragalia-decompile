using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class EnemyGeneratorVariationData : MonoBehaviour
	{
		[Serializable]
		public class EnemyGenerateLimitData
		{
			public int enemyId;

			public int limitCount;
		}

		public List<EnemyGenerateLimitData> limitDataList;

		public Dictionary<int, int> GetEnemyGenerateLimitData()
		{
			return null;
		}
	}
}
