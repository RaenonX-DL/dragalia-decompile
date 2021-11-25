using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsEAMelody : ActionParts
	{
		[SerializeField]
		private EAMelodyData _data;

		public override PartsData data => null;
	}
}
