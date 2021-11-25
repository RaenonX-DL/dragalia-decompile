using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsSetupMiasma : ActionParts
	{
		[SerializeField]
		private SetupMiasmaData _data;

		public override PartsData data => null;
	}
}
