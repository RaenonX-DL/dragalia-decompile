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
	public class GameObjectPool
	{
		// Fields
		private static GameObjectPool _instance;
		private Dictionary<string, List<GameObject>> _poolDic;
	
		// Properties
		public static GameObjectPool instance { get; }
	
		// Constructors
		public GameObjectPool();
		static GameObjectPool();
	
		// Methods
		public void PreCreateObjects(string path, int count, Transform parent = null);
		public GameObject FetchObject(string path, Transform parent = null);
		public void PreCreateCharacterObject(int characterId);
		public GameObject FetchCharacterObject(int characterId);
		public void PreCreateDragonObjects(int dragonId);
		public GameObject FetchDragonObjects(int dragonId);
		public void PreCreateEnemyObjects(int enemyParamId, int count);
		public GameObject FetchEnemyObjects(int enemyParamId);
		public void RemoveObject(GameObject obj);
		public void ClearAll();
		public void ClearWithPath(string path);
	}
}
