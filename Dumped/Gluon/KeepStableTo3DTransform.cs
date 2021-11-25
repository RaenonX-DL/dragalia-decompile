using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class KeepStableTo3DTransform : MonoBehaviour
	{
		public Transform keepStableTo;

		public float offsetScaleMul;

		public Vector3 localOffset;

		public bool lookAtTarget;

		public Vector3 lookAtOffset;

		private void LateUpdate()
		{
		}
	}
}
