using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsAiTarget : ActionParts
	{
		[SerializeField]
		private AiTargetData _data;

		public override PartsData data => null;
	}
}
