using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class VesselBombEventResistedParameter : VesselBombEventParameterBase
	{
		[Key(0)]
		public Vector3 hitPos;
	}
}
