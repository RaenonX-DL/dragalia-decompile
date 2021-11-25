using UnityEngine;

namespace Gluon.Dungeon
{
	public class EnvironmentMapTransform : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private Vector3 _mapTransformAxisX;

		[SerializeField]
		[HideInInspector]
		private Vector3 _mapTransformAxisZ;

		public Vector3 mapTransformAxisX => default(Vector3);

		public Vector3 mapTransformAxisZ => default(Vector3);
	}
}
