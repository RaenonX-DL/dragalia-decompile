using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMoveInput : ActionParts
	{
		[SerializeField]
		private MoveInputData _data;

		public override PartsData data => null;
	}
}
