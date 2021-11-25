using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AchievementGooglePlay : IMaster<AchievementGooglePlay>
	{
		[SerializeField]
		private AchievementGooglePlayDictionary dict;

		public AchievementGooglePlayDictionary Dict => null;

		public SerializableDictionary<int, AchievementGooglePlayElement>.ValueCollection List => null;
	}
}
