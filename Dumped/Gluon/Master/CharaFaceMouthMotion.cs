using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaFaceMouthMotion : IMaster<CharaFaceMouthMotion>
	{
		[SerializeField]
		private CharaFaceMouthMotionDictionary dict;

		public CharaFaceMouthMotionDictionary Dict => null;

		public SerializableDictionary<int, CharaFaceMouthMotionElement>.ValueCollection List => null;
	}
}
