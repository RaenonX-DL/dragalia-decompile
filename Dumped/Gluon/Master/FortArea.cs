using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortArea : IMaster<FortArea>
	{
		[SerializeField]
		private FortAreaDictionary dict;

		public FortAreaDictionary Dict => null;

		public SerializableDictionary<int, FortAreaElement>.ValueCollection List => null;
	}
}
