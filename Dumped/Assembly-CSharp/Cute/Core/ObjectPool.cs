/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class ObjectPool : MonoBehaviour
	{
		// Fields
		private static ObjectPool instance;
		private Dictionary<GameObject, Pool> dict;
		private Transform cachedTransform;
	
		// Properties
		public static ObjectPool Instance { get; }
		public static bool HasInstance { get; }
	
		// Nested types
		private class Pool
		{
			// Fields
			private GameObject prefab;
			private List<GameObject> lists;
			private Func<GameObject, GameObject> instantiateFunc;
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Predicate<GameObject> __9__4_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _Get_b__4_0(GameObject g);
			}
	
			// Constructors
			public Pool(GameObject prefab, Func<GameObject, GameObject> instantiateFunc);
	
			// Methods
			public GameObject Get(Transform parentTransform = null);
			public void PreLoad(int amount, Transform parentTransform);
			public bool Add(GameObject go, int limitNumber, Transform parentTransform);
			public int GetListCount();
			public void Subtract(GameObject obj);
			public GameObject GetIndexObject(int index);
			public Func<GameObject, GameObject> GetInstantiateFunc();
		}
	
		// Constructors
		public ObjectPool();
	
		// Methods
		public GameObject GetInstance(GameObject prefab, Func<GameObject, GameObject> instantiateFunc = null, bool setParent = false);
		public void PreLoad(GameObject prefab, int amount, Func<GameObject, GameObject> instantiateFunc = null);
		public int GetPoolCount(GameObject prefab);
		public void Release(GameObject obj);
		public bool AssignObject(GameObject prefab, GameObject obj, int limitnum, Func<GameObject, GameObject> instantiateFunc);
		public List<GameObject> ReleaseObject(GameObject prefab, int count, Func<GameObject, GameObject> instantiateFunc);
		private void OnDestroy();
	}
}
