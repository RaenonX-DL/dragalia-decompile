/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public static class AssetLoaderExtensions
	{
		// Nested types
		private struct VoidTaskResult
		{
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public TaskCompletionSource<T> promise;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _LoadTaskAsync_b__0(T x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public TaskCompletionSource<VoidTaskResult> promise;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _LoadSceneTaskAsync_b__0(bool _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public TaskCompletionSource<T> promise;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _LoadAssetWithNameTaskAsync_b__0(T x);
		}
	
		// Extension methods
		public static Task<T> LoadTaskAsync<T>(this ILocalAssetLoader loader, string path, int generation)
			where T : UnityEngine.Object;
		public static Task LoadSceneTaskAsync(this ILocalAssetLoader loader, string path, int generation);
		[Obsolete]
		public static Task<T> LoadAssetWithNameTaskAsync<T>(this ILocalAssetLoader loader, string path, string name)
			where T : UnityEngine.Object;
	}
}
