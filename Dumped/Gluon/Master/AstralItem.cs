using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AstralItem : IMaster<AstralItem>
	{
		[SerializeField]
		private AstralItemDictionary dict;

		public AstralItemDictionary Dict => null;

		public SerializableDictionary<int, AstralItemElement>.ValueCollection List => null;
	}
}
