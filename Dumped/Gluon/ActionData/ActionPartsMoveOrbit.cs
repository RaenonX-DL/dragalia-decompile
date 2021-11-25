using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMoveOrbit : ActionParts
	{
		[SerializeField]
		private MoveOrbitData _data;

		public override PartsData data => null;
	}
}
