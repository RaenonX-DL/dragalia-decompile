using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickCursebox : IMaster<GimmickCursebox>
	{
		[SerializeField]
		private GimmickCurseboxDictionary dict;

		public GimmickCurseboxDictionary Dict => null;

		public SerializableDictionary<string, GimmickCurseboxElement>.ValueCollection List => null;
	}
}
