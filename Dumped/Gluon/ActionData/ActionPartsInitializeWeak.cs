using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsInitializeWeak : ActionParts
	{
		[SerializeField]
		private InitializeWeakData _data;

		public override PartsData data => null;
	}
}
