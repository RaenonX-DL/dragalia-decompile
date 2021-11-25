using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MainStoryGuide : IMaster<MainStoryGuide>
	{
		[SerializeField]
		private MainStoryGuideDictionary dict;

		public MainStoryGuideDictionary Dict => null;

		public SerializableDictionary<int, MainStoryGuideElement>.ValueCollection List => null;
	}
}
