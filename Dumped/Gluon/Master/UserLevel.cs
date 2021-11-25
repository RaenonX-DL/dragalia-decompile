using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class UserLevel : IMaster<UserLevel>
	{
		[SerializeField]
		private UserLevelDictionary dict;

		public UserLevelDictionary Dict => null;

		public SerializableDictionary<int, UserLevelElement>.ValueCollection List => null;
	}
}
