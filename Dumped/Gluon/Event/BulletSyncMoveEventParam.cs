using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BulletSyncMoveEventParam : BulletEventParamBase
	{
		[Required]
		[Key(0)]
		public Vector3 position;
	}
}
