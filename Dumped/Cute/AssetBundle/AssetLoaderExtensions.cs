using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Cute.AssetBundle
{
	public static class AssetLoaderExtensions
	{
		private struct VoidTaskResult
		{
		}

		public static Task<T> LoadTaskAsync<T>(this ILocalAssetLoader loader, string path, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		public static Task LoadSceneTaskAsync(this ILocalAssetLoader loader, string path, int generation)
		{
			return null;
		}

		[Obsolete]
		public static Task<T> LoadAssetWithNameTaskAsync<T>(this ILocalAssetLoader loader, string path, string name) where T : UnityEngine.Object
		{
			return null;
		}
	}
}
