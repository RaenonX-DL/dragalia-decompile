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
	public class FortAssetsManager
	{
		// Fields
		public Dictionary<string, UnityEngine.Object> assetPools;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public FortAssetsManager __4__this;
			public string path;
			public Action<T> OnCompleted;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _FetchAssetAsync_b__0(T prefab);
		}
	
		// Constructors
		public FortAssetsManager();
	
		// Methods
		public GameObject FetchAsset(string path);
		public UnityEngine.Object FetchAsset<T>(string path)
			where T : UnityEngine.Object;
		public void FetchAssetAsync<T>(string path, Action<T> OnCompleted)
			where T : UnityEngine.Object;
		public void Clear();
	}
}
