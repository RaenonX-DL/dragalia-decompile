using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsSalvationBubble : ActionParts
	{
		[SerializeField]
		private SalvationBubbleData _data;

		public override PartsData data => null;
	}
}
