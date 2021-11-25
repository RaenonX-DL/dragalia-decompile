using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class NavMeshObstacleListInitializer : MonoBehaviour
	{
		[Serializable]
		public class ObstacleData
		{
			public Vector3 boxOffset;

			public float rotY;

			public Vector3 boxSize;

			public ObstacleData(Vector3 offset, Vector3 size)
			{
			}
		}

		private void Awake()
		{
		}
	}
}
