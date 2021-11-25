using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CampaignData : IMaster<CampaignData>
	{
		[SerializeField]
		private CampaignDataDictionary dict;

		public CampaignDataDictionary Dict => null;

		public SerializableDictionary<int, CampaignDataElement>.ValueCollection List => null;
	}
}
