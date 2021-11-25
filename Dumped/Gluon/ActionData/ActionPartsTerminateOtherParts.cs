using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsTerminateOtherParts : ActionParts
	{
		[SerializeField]
		private TerminateOtherData _data;

		public override PartsData data => null;
	}
}
