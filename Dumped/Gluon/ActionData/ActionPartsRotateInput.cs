using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsRotateInput : ActionParts
	{
		[SerializeField]
		private RotateInputData _data;

		public override PartsData data => null;
	}
}
