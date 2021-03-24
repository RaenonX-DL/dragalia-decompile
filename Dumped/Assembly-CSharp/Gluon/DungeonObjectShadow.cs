/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonObjectShadow
	{
		// Fields
		private static readonly string[] shadowPrefabAssetsNames;
		private GameObject[] _objectShadowTable;
	
		// Nested types
		public enum BrightnessType
		{
			None = -1,
			Hard = 0,
			Middle = 1,
			Soft = 2
		}
	
		[Serializable]
		public class ShadowData
		{
			// Fields
			public BrightnessType brightness;
			[Range]
			public float witdh;
			[Range]
			public float depth;
			[Range]
			public float rotate;
			[Range]
			public float orthographicSize;
	
			// Constructors
			public ShadowData();
		}
	
		// Constructors
		public DungeonObjectShadow();
		static DungeonObjectShadow();
	
		// Methods
		public void Initialize();
		public GameObject GetShadowObject(BrightnessType brightness);
	}
}
