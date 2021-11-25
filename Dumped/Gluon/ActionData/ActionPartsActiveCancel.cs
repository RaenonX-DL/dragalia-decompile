using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsActiveCancel : ActionParts
	{
		[SerializeField]
		private ActiveCancelData _data;

		public override PartsData data => null;
	}
}
