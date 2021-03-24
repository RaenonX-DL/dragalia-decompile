/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class ScriptableObjectManifest : ScriptableObject
	{
		// Fields
		public Category[] categories;
		public RawAsset[] rawAssets;
	
		// Nested types
		[Serializable]
		public class Asset
		{
			// Fields
			public string name;
			public string hash;
			public string[] dependencies;
			public int size;
			public int group;
			public string[] assets;
	
			// Constructors
			public Asset();
		}
	
		[Serializable]
		public class RawAsset
		{
			// Fields
			public string name;
			public string hash;
			public int size;
			public int group;
	
			// Constructors
			public RawAsset();
		}
	
		[Serializable]
		public class Category
		{
			// Fields
			public string name;
			public Asset[] assets;
			public Asset[] encryptedAssets;
	
			// Constructors
			public Category();
		}
	
		// Constructors
		public ScriptableObjectManifest();
	
		// Methods
		public void CopyFrom(ScriptableObjectManifest src);
		public static ScriptableObjectManifest LoadManifest(string manifestSavePath, bool isPrein = false);
		public static ScriptableObjectManifest LoadManifest(byte[] bytes);
	}
}
