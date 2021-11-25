using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class CampaignDataDictionary : SerializableDictionary<int, CampaignDataElement>
	{
	}
}
