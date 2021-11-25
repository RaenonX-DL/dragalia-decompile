using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GuideWindow : IMaster<GuideWindow>
	{
		[SerializeField]
		private GuideWindowDictionary dict;

		public GuideWindowDictionary Dict => null;

		public SerializableDictionary<int, GuideWindowElement>.ValueCollection List => null;
	}
}
