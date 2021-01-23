/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	[Serializable]
	public class FlMultiPrefabItem
	{
		// Fields
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
	
		// Properties
		public FlMultiPrefabComponent Manager { get; set; }
		public int Index { get; set; }
		public GameObject PrefabObject { get; }
		public GameObject InstanceObject { get; }
		public Vector3 CenterPosition { get; }
		public Vector3 CenterRotate { get; }
		public Vector3 CenterScaleOffset { get; }
		public Vector3 LocalPosition { get; }
		public Vector3 LocalRotate { get; }
		public Vector3 LocalScaleOffset { get; }
		public FlRoot Root { get; }
	
		// Constructors
		public FlMultiPrefabItem();
	
		// Methods
		public void CreateInstance();
		public void UpdateInstanceTransform(bool valueFromObject);
		private void UpdateTransformBase(GameObject targetObject, GameObject centerObject, bool valueFromObject);
	}
}
