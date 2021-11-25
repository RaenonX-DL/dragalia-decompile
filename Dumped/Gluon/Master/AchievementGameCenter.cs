using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AchievementGameCenter : IMaster<AchievementGameCenter>
	{
		[SerializeField]
		private AchievementGameCenterDictionary dict;

		public AchievementGameCenterDictionary Dict => null;

		public SerializableDictionary<int, AchievementGameCenterElement>.ValueCollection List => null;
	}
}
