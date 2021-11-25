using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsThunder : ActionPartsBulletWithMarkerBase
	{
		[SerializeField]
		private ThunderData _data;

		public override PartsData data => null;
	}
}
