/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	public static class DefaultEncryption
	{
		// Fields
		public const string AssetBundleCryptKey = "AssetBundleCryptKey";
		public const string AssetBundleCryptIV = "AssetBundleCryptIV";
	
		// Methods
		public static byte[] Encrypt(byte[] src);
		public static byte[] Decrypt(byte[] src);
	}
}
