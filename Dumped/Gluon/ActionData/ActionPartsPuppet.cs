using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsPuppet : ActionParts
	{
		[SerializeField]
		private PuppetData _data;

		public override PartsData data => null;
	}
}
