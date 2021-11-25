using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestOverwriteParam : IMaster<QuestOverwriteParam>
	{
		[SerializeField]
		private QuestOverwriteParamDictionary dict;

		public QuestOverwriteParamDictionary Dict => null;

		public SerializableDictionary<int, QuestOverwriteParamElement>.ValueCollection List => null;
	}
}
