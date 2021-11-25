using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsExtraCamera : ActionParts
	{
		[SerializeField]
		private ExtraCameraData _data;

		public override PartsData data => null;
	}
}
