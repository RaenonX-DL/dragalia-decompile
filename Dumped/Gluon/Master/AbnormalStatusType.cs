using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AbnormalStatusType : IMaster<AbnormalStatusType>
	{
		[SerializeField]
		private AbnormalStatusTypeDictionary dict;

		public AbnormalStatusTypeDictionary Dict => null;

		public SerializableDictionary<int, AbnormalStatusTypeElement>.ValueCollection List => null;
	}
}
