using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CameraTrackingRotator : FastUpdateMonoBehaviour
	{
		private Camera _targetCamera;

		private Transform _targetTransformCache;

		[SerializeField]
		protected Vector3 cameraEularRatation;

		public Camera targetCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform targetTransformCache => null;

		private void Start()
		{
		}
	}
}
