using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsDestroyMotion : ActionParts
	{
		[SerializeField]
		private DestroyMotionData _data;

		public override PartsData data => null;
	}
}
