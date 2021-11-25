using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsAppearWeak : ActionParts
	{
		[SerializeField]
		private AppearWeakData _data;

		public override PartsData data => null;
	}
}
