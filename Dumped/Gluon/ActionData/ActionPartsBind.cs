using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsBind : ActionParts
	{
		[SerializeField]
		private BindData _data;

		public override PartsData data => null;
	}
}
