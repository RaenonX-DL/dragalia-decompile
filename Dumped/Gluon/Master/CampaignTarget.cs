using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CampaignTarget : IMaster<CampaignTarget>
	{
		[SerializeField]
		private CampaignTargetDictionary dict;

		public CampaignTargetDictionary Dict => null;

		public SerializableDictionary<int, CampaignTargetElement>.ValueCollection List => null;
	}
}
