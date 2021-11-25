using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsReactiveLightning : ActionParts
	{
		[SerializeField]
		private ReactiveLightningData _data;

		public override PartsData data => null;
	}
}
