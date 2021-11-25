using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class Clb01EventLocation : IMasterGroupElement
	{
		[SerializeField]
		private Clb01EventLocationDictionary dict;

		public Clb01EventLocationDictionary Dict => null;

		public SerializableDictionary<int, Clb01EventLocationElement>.ValueCollection List => null;
	}
}
