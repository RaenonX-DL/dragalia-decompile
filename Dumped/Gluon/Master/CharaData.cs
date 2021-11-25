using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaData : IMaster<CharaData>
	{
		[SerializeField]
		private CharaDataDictionary dict;

		public CharaDataDictionary Dict => null;

		public SerializableDictionary<int, CharaDataElement>.ValueCollection List => null;
	}
}
