using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsMultiDropBulletRegisteredPos : ActionPartsDropBullet
	{
		[SerializeField]
		private MultiDropBulletRegisteredPosData _multiData;

		public override PartsData data => null;
	}
}
