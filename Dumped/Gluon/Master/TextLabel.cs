using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TextLabel : IMaster<TextLabel>
	{
		[SerializeField]
		private TextLabelDictionary dict;

		public TextLabelDictionary Dict => null;

		public SerializableDictionary<string, TextLabelElement>.ValueCollection List => null;
	}
}
