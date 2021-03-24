/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class AssetBundleManifest
	{
		// Fields
		private Dictionary<string, Asset> assets;
		private Dictionary<string, Asset> hashKeyAssets;
		private Dictionary<string, List<string>> categories;
		private Dictionary<string, ValueTuple<string, string>> assetNameCaches;
	
		// Nested types
		private class Asset
		{
			// Fields
			[CompilerGenerated]
			private string _assetBundleName_k__BackingField;
			[CompilerGenerated]
			private string _hash_k__BackingField;
			[CompilerGenerated]
			private string[] _dependencies_k__BackingField;
			[CompilerGenerated]
			private bool _encrypted_k__BackingField;
			[CompilerGenerated]
			private int _size_k__BackingField;
			[CompilerGenerated]
			private string _category_k__BackingField;
			[CompilerGenerated]
			private int _group_k__BackingField;
	
			// Properties
			public string assetBundleName { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string hash { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string[] dependencies { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool encrypted { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int size { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string category { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int group { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public Asset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<string, string> __9__8_0;
			public static Func<string, string> __9__8_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _MergeManifest_b__8_0(string d);
			internal string _MergeManifest_b__8_1(string d);
		}
	
		// Constructors
		public AssetBundleManifest();
		public AssetBundleManifest(AssetBundleManifest srcManifest);
		public AssetBundleManifest(ScriptableObjectManifest srcManifest);
	
		// Methods
		public void MergeManifest(ScriptableObjectManifest srcManifest);
		public IEnumerable<string> GetAllHashes();
		public IEnumerable<string> GetAllAssetBundleNames();
		public HashSet<string> GetCategoryHashes(string category);
		public HashSet<string> GetGroupHashes(int[] groups, bool dependency = true);
		public HashSet<string> GetMatchHashes(Func<string, bool> match);
		public HashSet<string> GetHashes(IEnumerable<string> pathList, bool dependency = true);
		public string GetHash(string assetBundleName);
		public ValueTuple<string, string> GetAssetBundleNameAndLoadName(string assetName);
		public bool Exists(string assetName);
		public int GetSize(string assetBundleName);
		public int GetSizeFromHash(string hash);
		public string GetAssetBundleNameFromHash(string hash);
		public bool IsEncryptedFromHash(string hash);
		private void AddCategory(string category, string hash);
		private string[] GetDependenciesAtPath(string assetBundleName);
		public void GetDependenciesHash(string assetBundleName, HashSet<string> hashSet);
		private void GetDependencies(string assetBundleName, List<string> list);
		public List<string> GetDependencies(string assetBundleName);
	}
}
