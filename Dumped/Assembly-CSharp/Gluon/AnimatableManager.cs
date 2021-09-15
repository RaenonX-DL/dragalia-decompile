/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimatableManager : SingletonMonoBehaviour<Gluon.AnimatableManager>
	{
		// Fields
		private Dictionary<string, AnimatableObjectListData> _animatableObjectListDic;
	
		// Nested types
		private class AnimatableObjectListData
		{
			// Fields
			private string _name;
			private GameObject _rootObject;
			private GameObject _basePrefabObject;
			private GameObject _richPrefabObject;
			private RuntimeAnimatorController _runtimeAnimatorController;
			private string _richPrefabPath;
			private bool _enableLimit;
			private List<AnimatableObject> _animatableObjectList;
			private List<AttachWeaponData> attachWeapons;
			private List<RootAttachObject> rootAttachObjects;
	
			// Properties
			public List<AnimatableObject> animatableObjectList { get; }
	
			// Nested types
			private class AttachWeaponData
			{
				// Fields
				public string prefabPath;
				public string nodeName;
	
				// Constructors
				public AttachWeaponData();
			}
	
			private class RootAttachObject
			{
				// Fields
				public GameObject prefab;
				public bool isOverrideTransform;
				public Vector3 overridePos;
				public Quaternion overrideRot;
				public Vector3 overrideScale;
	
				// Constructors
				public RootAttachObject();
			}
	
			// Constructors
			public AnimatableObjectListData();
	
			// Methods
			public void Load(InGameSettings.AnimatableObjectParam param, Transform parentTransform);
			public AnimatableObject CreateInstance();
			public void DestroyAll();
			public AnimatableObject GetAnimatableObject();
			public bool ReleaseAnimatableObject(AnimatableObject animatableObject);
		}
	
		// Constructors
		public AnimatableManager();
	
		// Methods
		protected override void Awake();
		public void Load(string name);
		public void UnloadAll();
		public AnimatableObject GetAnimatableObject(string keyName);
		public void ReleaseAnimatableObject(AnimatableObject animatableObject);
		public void SetSortingOrder();
	}
}
