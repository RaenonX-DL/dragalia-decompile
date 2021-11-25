using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsHitStop : ActionParts
	{
		[SerializeField]
		private HitStopData _data;

		public override PartsData data => null;
	}
}
