using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsDoll : ActionParts
	{
		[SerializeField]
		private DollData _data;

		public override PartsData data => null;
	}
}
