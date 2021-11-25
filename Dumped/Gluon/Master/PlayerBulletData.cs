using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PlayerBulletData : IMaster<PlayerBulletData>
	{
		[SerializeField]
		private PlayerBulletDataDictionary dict;

		public PlayerBulletDataDictionary Dict => null;

		public SerializableDictionary<int, PlayerBulletDataElement>.ValueCollection List => null;
	}
}
