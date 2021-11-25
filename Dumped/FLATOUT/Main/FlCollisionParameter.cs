using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlCollisionParameter
	{
		public FlCollisionTypes _collisionType;

		public Vector3 _offset;

		public float _scale;

		public bool _through;

		public FlCollisionTypes CollisionType
		{
			get
			{
				return default(FlCollisionTypes);
			}
			set
			{
			}
		}

		public float Scale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 Offset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool Through
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void _CreateHierarchy(FlRoot root, GameObject parentGameObject)
		{
		}
	}
}
