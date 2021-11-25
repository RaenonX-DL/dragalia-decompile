using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cute.AssetBundle
{
	public class AssetBundleManifest
	{
		private class Asset
		{
			public string assetBundleName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string hash
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] dependencies
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool encrypted
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int size
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string category
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int group
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private Dictionary<string, Asset> assets;

		private Dictionary<string, Asset> hashKeyAssets;

		private Dictionary<string, List<string>> categories;

		private Dictionary<string, (string, string)> assetNameCaches;

		public AssetBundleManifest()
		{
		}

		public AssetBundleManifest(AssetBundleManifest srcManifest)
		{
		}

		public AssetBundleManifest(ScriptableObjectManifest srcManifest)
		{
		}

		public void MergeManifest(ScriptableObjectManifest srcManifest)
		{
		}

		public IEnumerable<string> GetAllHashes()
		{
			return null;
		}

		public IEnumerable<string> GetAllAssetBundleNames()
		{
			return null;
		}

		public HashSet<string> GetCategoryHashes(string category)
		{
			return null;
		}

		public HashSet<string> GetGroupHashes(int[] groups, bool dependency = true)
		{
			return null;
		}

		public HashSet<string> GetMatchHashes(Func<string, bool> match)
		{
			return null;
		}

		public HashSet<string> GetHashes(IEnumerable<string> pathList, bool dependency = true)
		{
			return null;
		}

		public string GetHash(string assetBundleName)
		{
			return null;
		}

		public (string, string) GetAssetBundleNameAndLoadName(string assetName)
		{
			return default((string, string));
		}

		public bool Exists(string assetName)
		{
			return default(bool);
		}

		public int GetSize(string assetBundleName)
		{
			return default(int);
		}

		public int GetSizeFromHash(string hash)
		{
			return default(int);
		}

		public string GetAssetBundleNameFromHash(string hash)
		{
			return null;
		}

		public bool IsEncryptedFromHash(string hash)
		{
			return default(bool);
		}

		private void AddCategory(string category, string hash)
		{
		}

		private string[] GetDependenciesAtPath(string assetBundleName)
		{
			return null;
		}

		public void GetDependenciesHash(string assetBundleName, HashSet<string> hashSet)
		{
		}

		private void GetDependencies(string assetBundleName, List<string> list)
		{
		}

		public List<string> GetDependencies(string assetBundleName)
		{
			return null;
		}
	}
}
