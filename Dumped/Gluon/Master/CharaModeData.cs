using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaModeData : IMaster<CharaModeData>
	{
		[SerializeField]
		private CharaModeDataDictionary dict;

		public CharaModeDataDictionary Dict => null;

		public SerializableDictionary<int, CharaModeDataElement>.ValueCollection List => null;
	}
}
