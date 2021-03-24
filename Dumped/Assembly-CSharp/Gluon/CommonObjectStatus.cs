/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonObjectStatus : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonStatus _commonStatus;
		[CompilerGenerated]
		private CommonObjectStatusDelegate onDestroyEvent;
		[CompilerGenerated]
		private Transform _cacheTransform_k__BackingField;
		[CompilerGenerated]
		private CapsuleCollider _capsuleCollider_k__BackingField;
		[CompilerGenerated]
		private BoxCollider _boxCollider_k__BackingField;
		[CompilerGenerated]
		private SphereCollider _sphereCollider_k__BackingField;
		[CompilerGenerated]
		private MeshCollider _cylinderCollider_k__BackingField;
	
		// Properties
		public CommonStatus commonStatus { get; }
		public Transform cacheTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CapsuleCollider capsuleCollider { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BoxCollider boxCollider { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public SphereCollider sphereCollider { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MeshCollider cylinderCollider { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Events
		public event CommonObjectStatusDelegate onDestroyEvent {
			add;
			remove;
		}
	
		// Nested types
		[Serializable]
		public struct CullingSphere
		{
			// Fields
			public Vector3 position;
			public float radius;
			public bool disableClipping;
		}
	
		[Serializable]
		public class CommonStatus
		{
			// Fields
			public CullingSphere animatorCullingSphere;
	
			// Constructors
			public CommonStatus();
		}
	
		public delegate void CommonObjectStatusDelegate(GameObject callObject);
	
		// Constructors
		public CommonObjectStatus();
	
		// Methods
		protected virtual void Awake();
		protected virtual void OnDestroy();
		public virtual int GetSortingOrderOffset();
	}
}
