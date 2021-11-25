using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsCameraMotion : ActionParts
	{
		[SerializeField]
		private CameraMotionData _data;

		public override PartsData data => null;
	}
}
