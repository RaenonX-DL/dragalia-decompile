/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.UI;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameAtlasManager : MonoBehaviour
	{
		// Fields
		private static OutGameAtlasManager _instance;
		private Dictionary<string, Atlas> spriteCacheOld;
		private Dictionary<string, AtlasReference> spriteCache;
	
		// Properties
		public static OutGameAtlasManager instance { get; }
		public static bool hasInstance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public string spriteName;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal bool _GetSpriteOld_b__0(Sprite item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public string spriteName;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _GetSprite_b__0(Sprite item);
		}
	
		// Constructors
		public OutGameAtlasManager();
		static OutGameAtlasManager();
	
		// Methods
		public Sprite GetSpriteOld(string atlasPath, string spriteName);
		public Sprite GetSprite(string atlasPath, string spriteName);
		public Material GetMaterial(string atlasPath);
		public void Clear();
		private void OnDestroy();
	}
}
