using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMultiEffect : ActionParts
	{
		[SerializeField]
		private MultiEffectData _data;

		public override PartsData data => null;
	}
}
