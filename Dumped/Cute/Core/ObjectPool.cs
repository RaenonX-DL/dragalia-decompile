using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Cute.Core
{
	public class ObjectPool : MonoBehaviour
	{
		private class Pool
		{
			private GameObject prefab;

			private List<GameObject> lists;

			private Func<GameObject, GameObject> instantiateFunc;

			public Pool(GameObject prefab, Func<GameObject, GameObject> instantiateFunc)
			{
			}

			public GameObject Get([Optional] Transform parentTransform)
			{
				return null;
			}

			public void PreLoad(int amount, Transform parentTransform)
			{
			}

			public bool Add(GameObject go, int limitNumber, Transform parentTransform)
			{
				return default(bool);
			}

			public int GetListCount()
			{
				return default(int);
			}

			public void Subtract(GameObject obj)
			{
			}

			public GameObject GetIndexObject(int index)
			{
				return null;
			}

			public Func<GameObject, GameObject> GetInstantiateFunc()
			{
				return null;
			}
		}

		private static ObjectPool instance;

		private Dictionary<GameObject, Pool> dict;

		private Transform cachedTransform;

		public static ObjectPool Instance => null;

		public static bool HasInstance => default(bool);

		public GameObject GetInstance(GameObject prefab, [Optional] Func<GameObject, GameObject> instantiateFunc, bool setParent = false)
		{
			return null;
		}

		public void PreLoad(GameObject prefab, int amount, [Optional] Func<GameObject, GameObject> instantiateFunc)
		{
		}

		public int GetPoolCount(GameObject prefab)
		{
			return default(int);
		}

		public void Release(GameObject obj)
		{
		}

		public bool AssignObject(GameObject prefab, GameObject obj, int limitnum, Func<GameObject, GameObject> instantiateFunc)
		{
			return default(bool);
		}

		public List<GameObject> ReleaseObject(GameObject prefab, int count, Func<GameObject, GameObject> instantiateFunc)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
