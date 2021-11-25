using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MC : IMasterGroupElement
	{
		[SerializeField]
		private MCDictionary dict;

		public MCDictionary Dict => null;

		public SerializableDictionary<int, MCElement>.ValueCollection List => null;
	}
}
