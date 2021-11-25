using System;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	[Serializable]
	public class FlMultiPrefabItem
	{
		[SerializeField]
		private GameObject _prefabObject;

		[SerializeField]
		private Vector3 _centerPosition;

		[SerializeField]
		private Vector3 _centerRotate;

		[SerializeField]
		private Vector3 _centerScaleOffset;

		[SerializeField]
		private Vector3 _localPosition;

		[SerializeField]
		private Vector3 _localRotate;

		[SerializeField]
		private Vector3 _localScaleOffset;

		[SerializeField]
		private int _sortOffset;

		[SerializeField]
		private float _depthOffset;

		[SerializeField]
		private int _stencilRefOffset;

		[NonSerialized]
		private FlMultiPrefabComponent _manager;

		private int _index;

		private GameObject _centerObject;

		private GameObject _instanceObject;

		private FlRoot _root;

		private string _centerSuffix;

		public FlMultiPrefabComponent Manager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public GameObject PrefabObject => null;

		public GameObject InstanceObject => null;

		public Vector3 CenterPosition => default(Vector3);

		public Vector3 CenterRotate => default(Vector3);

		public Vector3 CenterScaleOffset => default(Vector3);

		public Vector3 LocalPosition => default(Vector3);

		public Vector3 LocalRotate => default(Vector3);

		public Vector3 LocalScaleOffset => default(Vector3);

		public FlRoot Root => null;

		public void CreateInstance()
		{
		}

		public void UpdateInstanceTransform(bool valueFromObject)
		{
		}

		private void UpdateTransformBase(GameObject targetObject, GameObject centerObject, bool valueFromObject)
		{
		}
	}
}
