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
	public class AssetBundleCreater
	{
		// Fields
		private static Func<byte[], byte[]> decryptMethod;
	
		// Properties
		public static Func<byte[], byte[]> DecryptMethod { get; set; }
	
		// Constructors
		public AssetBundleCreater();
		static AssetBundleCreater();
	
		// Methods
		public static global::UnityEngine.AssetBundle LoadManifest(string path);
		public static global::UnityEngine.AssetBundle LoadManifest(byte[] src);
		public static void SaveManifestWithHash(byte[] bytes, string outputManifestPath);
		public static global::UnityEngine.AssetBundle LoadAssetBundle(string path, bool isEncrypted);
		public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, bool isEncrypted);
		private static bool Equal(byte[] left, byte[] right);
	}
}
