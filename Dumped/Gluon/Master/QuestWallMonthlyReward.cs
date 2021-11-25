using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestWallMonthlyReward : IMaster<QuestWallMonthlyReward>
	{
		[SerializeField]
		private QuestWallMonthlyRewardDictionary dict;

		public QuestWallMonthlyRewardDictionary Dict => null;

		public SerializableDictionary<int, QuestWallMonthlyRewardElement>.ValueCollection List => null;
	}
}
