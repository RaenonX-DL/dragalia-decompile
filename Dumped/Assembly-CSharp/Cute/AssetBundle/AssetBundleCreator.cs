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
	public static class AssetBundleCreator
	{
		// Fields
		[CompilerGenerated]
		private static Func<byte[], byte[]> _DecryptMethod_k__BackingField;
	
		// Properties
		public static Func<byte[], byte[]> DecryptMethod { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		static AssetBundleCreator();
	
		// Methods
		public static global::UnityEngine.AssetBundle LoadManifest(string path, bool isPrein = false);
		public static global::UnityEngine.AssetBundle LoadManifest(byte[] src);
		public static void SaveManifestWithHash(byte[] bytes, string outputManifestPath);
		public static global::UnityEngine.AssetBundle LoadAssetBundle(string path, bool isEncrypted, bool isPrein = false);
		public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, bool isEncrypted, bool isPrein = false);
		public static byte[] ReadFileData(string path, bool isPrein);
		private static bool Equal(byte[] left, byte[] right);
	}
}
