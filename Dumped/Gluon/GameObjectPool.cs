using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class GameObjectPool
	{
		private static GameObjectPool _instance;

		private Dictionary<string, List<GameObject>> _poolDic;

		public static GameObjectPool instance => null;

		public void PreCreateObjects(string path, int count, [Optional] Transform parent)
		{
		}

		public GameObject FetchObject(string path, [Optional] Transform parent)
		{
			return null;
		}

		public void PreCreateCharacterObject(int characterId)
		{
		}

		public GameObject FetchCharacterObject(int characterId)
		{
			return null;
		}

		public void PreCreateDragonObjects(int dragonId)
		{
		}

		public GameObject FetchDragonObjects(int dragonId)
		{
			return null;
		}

		public void PreCreateEnemyObjects(int enemyParamId, int count)
		{
		}

		public GameObject FetchEnemyObjects(int enemyParamId)
		{
			return null;
		}

		public void RemoveObject(GameObject obj)
		{
		}

		public void ClearAll()
		{
		}

		public void ClearWithPath(string path)
		{
		}
	}
}
