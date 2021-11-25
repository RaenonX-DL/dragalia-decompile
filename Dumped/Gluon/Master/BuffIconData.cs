using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BuffIconData : IMaster<BuffIconData>
	{
		[SerializeField]
		private BuffIconDataDictionary dict;

		public BuffIconDataDictionary Dict => null;

		public SerializableDictionary<int, BuffIconDataElement>.ValueCollection List => null;
	}
}
