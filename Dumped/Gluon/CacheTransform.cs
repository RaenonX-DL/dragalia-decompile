using UnityEngine;

namespace Gluon
{
	public class CacheTransform : MonoBehaviour
	{
		private Transform _cacheTransform;

		private Vector3 _nowWorldPosition;

		private Vector3 _beforeWorldPosition;

		private Vector3 _moveDirection;

		private float _moveLength;

		public Transform chacheTransform => null;

		public Vector3 nowWorldPosition => default(Vector3);

		public Vector3 beforeWorldPosition => default(Vector3);

		public Vector3 moveDirection => default(Vector3);

		public float moveLength => default(float);

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
