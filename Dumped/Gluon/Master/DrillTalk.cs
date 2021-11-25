using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DrillTalk : IMaster<DrillTalk>
	{
		[SerializeField]
		private DrillTalkDictionary dict;

		public DrillTalkDictionary Dict => null;

		public SerializableDictionary<int, DrillTalkElement>.ValueCollection List => null;
	}
}
