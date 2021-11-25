using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SystemMessage : IMaster<SystemMessage>
	{
		[SerializeField]
		private SystemMessageDictionary dict;

		public SystemMessageDictionary Dict => null;

		public SerializableDictionary<int, SystemMessageElement>.ValueCollection List => null;
	}
}
