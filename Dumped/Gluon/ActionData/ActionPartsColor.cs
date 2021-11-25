using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsColor : ActionParts
	{
		[SerializeField]
		private ColorData _data;

		public override PartsData data => null;
	}
}
