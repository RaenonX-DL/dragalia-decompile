using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsLightningPillar : ActionParts
	{
		[SerializeField]
		private LightningPillarData _data;

		public override PartsData data => null;
	}
}
