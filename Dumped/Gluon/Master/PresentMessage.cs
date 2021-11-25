using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class PresentMessage : IMaster<PresentMessage>
	{
		[SerializeField]
		private PresentMessageDictionary dict;

		public PresentMessageDictionary Dict => null;

		public SerializableDictionary<int, PresentMessageElement>.ValueCollection List => null;
	}
}
