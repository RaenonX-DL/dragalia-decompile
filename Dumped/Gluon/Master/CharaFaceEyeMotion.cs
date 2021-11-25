using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaFaceEyeMotion : IMaster<CharaFaceEyeMotion>
	{
		[SerializeField]
		private CharaFaceEyeMotionDictionary dict;

		public CharaFaceEyeMotionDictionary Dict => null;

		public SerializableDictionary<int, CharaFaceEyeMotionElement>.ValueCollection List => null;
	}
}
