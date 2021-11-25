using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ManaPieceElement : IMaster<ManaPieceElement>
	{
		[SerializeField]
		private ManaPieceElementDictionary dict;

		public ManaPieceElementDictionary Dict => null;

		public SerializableDictionary<int, ManaPieceElementElement>.ValueCollection List => null;
	}
}
