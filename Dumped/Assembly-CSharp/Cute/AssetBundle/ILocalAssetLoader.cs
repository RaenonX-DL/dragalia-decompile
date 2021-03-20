/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public interface ILocalAssetLoader
	{
		// Methods
		UnityEngine.Object Load(string path);
		T Load<T>(string path)
			where T : UnityEngine.Object;
		T LoadAssetWithName<T>(string path, string name)
			where T : UnityEngine.Object;
		UnityEngine.Object[] LoadAssetWithSubAssets(string path);
		void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);
		void LoadAsync<T>(string path, Action<T> onLoaded)
			where T : UnityEngine.Object;
		void LoadAssetWithNameAsync<T>(string path, string name, Action<T> onLoaded)
			where T : UnityEngine.Object;
		void LoadAsync(string path, Action<bool, UnityEngine.Object> onLoaded);
		void LoadAsync<T>(string path, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
		void LoadAssetWithNameAsync<T>(string path, string name, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
	}
}
