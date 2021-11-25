using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DefenseEventSystemInfo : IMaster<DefenseEventSystemInfo>
	{
		[SerializeField]
		private DefenseEventSystemInfoDictionary dict;

		public DefenseEventSystemInfoDictionary Dict => null;

		public SerializableDictionary<int, DefenseEventSystemInfoElement>.ValueCollection List => null;
	}
}
