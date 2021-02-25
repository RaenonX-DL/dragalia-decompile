/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class DefaultAssetBundleLoader : ILocalAssetLoader
	{
		// Constructors
		public DefaultAssetBundleLoader();
	
		// Methods
		public T Load<T>(string assetName, int generation)
			where T : UnityEngine.Object;
		public UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation);
		public void LoadScene(string assetName, int generation);
		public void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation)
			where T : UnityEngine.Object;
		public void LoadAsync<T>(string assetName, Action<bool, T> onFinished, int generation)
			where T : UnityEngine.Object;
		public void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation);
		public IEnumerator UnloadAllAssets(int generation);
		public void Unload(string assetName);
		public string GetRawAssetPath(string filename, out bool isPrein);
		public bool Exists(string assetName);
	}
}
