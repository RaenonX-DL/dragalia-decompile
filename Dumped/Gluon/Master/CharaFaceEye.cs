using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaFaceEye : IMaster<CharaFaceEye>
	{
		[SerializeField]
		private CharaFaceEyeDictionary dict;

		public CharaFaceEyeDictionary Dict => null;

		public SerializableDictionary<int, CharaFaceEyeElement>.ValueCollection List => null;
	}
}
