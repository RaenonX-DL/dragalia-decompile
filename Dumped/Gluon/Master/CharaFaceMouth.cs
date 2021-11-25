using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaFaceMouth : IMaster<CharaFaceMouth>
	{
		[SerializeField]
		private CharaFaceMouthDictionary dict;

		public CharaFaceMouthDictionary Dict => null;

		public SerializableDictionary<int, CharaFaceMouthElement>.ValueCollection List => null;
	}
}
