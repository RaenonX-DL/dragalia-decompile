using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterStateChargeImpactSyncBody : CharacterStateExtraSyncBody
	{
		[Key(0)]
		public Vector3 impactPosition;
	}
}
