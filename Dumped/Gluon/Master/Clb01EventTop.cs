using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class Clb01EventTop : IMasterGroupElement
	{
		[SerializeField]
		private Clb01EventTopDictionary dict;

		public Clb01EventTopDictionary Dict => null;

		public SerializableDictionary<int, Clb01EventTopElement>.ValueCollection List => null;
	}
}
