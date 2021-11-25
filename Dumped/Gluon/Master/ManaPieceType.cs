using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ManaPieceType : IMaster<ManaPieceType>
	{
		[SerializeField]
		private ManaPieceTypeDictionary dict;

		public ManaPieceTypeDictionary Dict => null;

		public SerializableDictionary<int, ManaPieceTypeElement>.ValueCollection List => null;
	}
}
