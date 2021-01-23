/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GluonObjectPool : MonoBehaviour
	{
		// Fields
		private static GluonObjectPool instance;
		private Dictionary<GameObject, GluonPool> dict;
		private Dictionary<GameObject, int> assignCountDic;
		private HashSet<string> residentLoadEffectGroupNameList;
		public Transform cachedTransform;
	
		// Properties
		public static GluonObjectPool Instance { get; }
		public static bool HasInstance { get; }
	
		// Nested types
		private class GluonPool
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
			public GluonPool(GameObject prefab, Func<GameObject, GameObject> instantiateFunc);
	
			// Methods
			public GameObject Get(Transform parentTransform = null);
			public void PreLoad(int amount, Transform parentTransform);
			public bool Add(GameObject go, int limitNumber, Transform parentTransform);
			public void Release();
			public int GetListCount();
			public Func<GameObject, GameObject> GetInstantiateFunc();
			public GameObject GetContentInstance(int index);
			public void ClearList();
		}
	
		// Constructors
		public GluonObjectPool();
	
		// Methods
		public GameObject GetInstance(GameObject prefab, Func<GameObject, GameObject> instantiateFunc = null, bool setParent = false);
		public void PreLoad(GameObject prefab, int amount, Func<GameObject, GameObject> instantiateFunc = null);
		public int GetPoolCount(GameObject prefab);
		public void AssignListToCutePoolObject();
		public void WithdrawListFromCutePoolObject();
		private void OnDestroy();
		private void CreateResidentialEffectGroupNameList();
		public void LoadResidentialObjectForDungeon();
		public void UnLoadResidentialObjectForDungeon();
		public string[] GetResidentialEffectGroupNameList();
	}
}
