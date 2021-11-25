using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CameraMotionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _shakeType;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakePriority _shakePrio;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _amplitudeDampingCoef;

		[SerializeField]
		[HideInInspector]
		private bool _onlySelf;

		public CameraController.ShakeType shakeType => default(CameraController.ShakeType);

		public CameraController.ShakePriority shakePrio => default(CameraController.ShakePriority);

		public AnimationCurve amplitudeDampingCoef => null;

		public bool onlySelf => default(bool);
	}
}
