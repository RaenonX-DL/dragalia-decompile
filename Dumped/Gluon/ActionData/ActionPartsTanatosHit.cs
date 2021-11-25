using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsTanatosHit : ActionPartsHit
	{
		[SerializeField]
		private TanatosHitData _customData;

		public override PartsData data => null;
	}
}
