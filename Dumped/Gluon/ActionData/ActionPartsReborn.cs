using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsReborn : ActionParts
	{
		[SerializeField]
		private RebornData _data;

		public override PartsData data => null;
	}
}
