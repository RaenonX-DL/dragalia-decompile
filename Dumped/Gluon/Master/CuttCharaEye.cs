using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CuttCharaEye : IMaster<CuttCharaEye>
	{
		[SerializeField]
		private CuttCharaEyeDictionary dict;

		public CuttCharaEyeDictionary Dict => null;

		public SerializableDictionary<int, CuttCharaEyeElement>.ValueCollection List => null;
	}
}
