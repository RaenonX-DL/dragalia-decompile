using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickMovePanelObj : IMaster<GimmickMovePanelObj>
	{
		[SerializeField]
		private GimmickMovePanelObjDictionary dict;

		public GimmickMovePanelObjDictionary Dict => null;

		public SerializableDictionary<string, GimmickMovePanelObjElement>.ValueCollection List => null;
	}
}
