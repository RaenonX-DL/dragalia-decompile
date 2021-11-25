using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LoadingTips : IMaster<LoadingTips>
	{
		[SerializeField]
		private LoadingTipsDictionary dict;

		public LoadingTipsDictionary Dict => null;

		public SerializableDictionary<int, LoadingTipsElement>.ValueCollection List => null;
	}
}
