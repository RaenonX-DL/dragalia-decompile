using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ManaPieceMaterial : IMaster<ManaPieceMaterial>
	{
		[SerializeField]
		private ManaPieceMaterialDictionary dict;

		public ManaPieceMaterialDictionary Dict => null;

		public SerializableDictionary<int, ManaPieceMaterialElement>.ValueCollection List => null;
	}
}
