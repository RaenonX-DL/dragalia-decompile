using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CommonObjectStatus : FastUpdateMonoBehaviour
	{
		[Serializable]
		public struct CullingSphere
		{
			public Vector3 position;

			public float radius;

			public bool disableClipping;
		}

		[Serializable]
		public class CommonStatus
		{
			public CullingSphere animatorCullingSphere;
		}

		public delegate void CommonObjectStatusDelegate(GameObject callObject);

		[SerializeField]
		private CommonStatus _commonStatus;

		public CommonStatus commonStatus => null;

		public Transform cacheTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CapsuleCollider capsuleCollider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BoxCollider boxCollider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SphereCollider sphereCollider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MeshCollider cylinderCollider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event CommonObjectStatusDelegate onDestroyEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual int GetSortingOrderOffset()
		{
			return default(int);
		}
	}
}
