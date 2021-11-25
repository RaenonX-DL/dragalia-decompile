using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class SeasonVoice : IMaster<SeasonVoice>
	{
		[SerializeField]
		private SeasonVoiceDictionary dict;

		public SeasonVoiceDictionary Dict => null;

		public SerializableDictionary<int, SeasonVoiceElement>.ValueCollection List => null;
	}
}
