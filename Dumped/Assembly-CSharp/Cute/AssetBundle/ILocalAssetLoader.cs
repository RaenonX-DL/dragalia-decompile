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
	public interface ILocalAssetLoader
	{
		// Methods
		T Load<T>(string assetName, int generation)
			where T : UnityEngine.Object;
		UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation);
		void LoadScene(string assetName, int generation);
		void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation)
			where T : UnityEngine.Object;
		void LoadAsync<T>(string assetName, Action<bool, T> onLoaded, int generation)
			where T : UnityEngine.Object;
		void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation);
		IEnumerator UnloadAllAssets(int generation);
		void Unload(string assetName);
		string GetRawAssetPath(string filename, out bool isPrein);
		bool Exists(string assetName);
	}
}
