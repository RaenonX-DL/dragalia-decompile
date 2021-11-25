using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CommonActionHitAttribute : IMaster<CommonActionHitAttribute>
	{
		[SerializeField]
		private CommonActionHitAttributeDictionary dict;

		public CommonActionHitAttributeDictionary Dict => null;

		public SerializableDictionary<string, CommonActionHitAttributeElement>.ValueCollection List => null;
	}
}
