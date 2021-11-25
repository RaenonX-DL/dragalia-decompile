using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class GluonObjectPool : MonoBehaviour
	{
		private class GluonPool
		{
			private GameObject prefab;

			private List<GameObject> lists;

			private Func<GameObject, GameObject> instantiateFunc;

			public GluonPool(GameObject prefab, Func<GameObject, GameObject> instantiateFunc)
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

			public void Release()
			{
			}

			public int GetListCount()
			{
				return default(int);
			}

			public Func<GameObject, GameObject> GetInstantiateFunc()
			{
				return null;
			}

			public GameObject GetContentInstance(int index)
			{
				return null;
			}

			public void ClearList()
			{
			}
		}

		private static GluonObjectPool instance;

		private Dictionary<GameObject, GluonPool> dict;

		private Dictionary<GameObject, int> assignCountDic;

		private HashSet<string> residentLoadEffectGroupNameList;

		public Transform cachedTransform;

		public static GluonObjectPool Instance => null;

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

		public void AssignListToCutePoolObject()
		{
		}

		public void WithdrawListFromCutePoolObject()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateResidentialEffectGroupNameList()
		{
		}

		public void LoadResidentialObjectForDungeon()
		{
		}

		public void UnLoadResidentialObjectForDungeon()
		{
		}

		public string[] GetResidentialEffectGroupNameList()
		{
			return null;
		}
	}
}
