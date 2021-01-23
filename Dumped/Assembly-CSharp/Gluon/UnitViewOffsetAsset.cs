/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitViewOffsetAsset : ScriptableObject
	{
		// Fields
		public const string assetBasicPath = "UnitViewOffset/Setting";
		public const string assetPrefix = "unitviewoffset_";
		[SerializeField]
		public Vector2 viewOffset;
		[SerializeField]
		public Dragon2DOffset dragonStrokeViewOffset;
		[SerializeField]
		public Vector2 eyelineOffset;
		[SerializeField]
		public float eyelineScale;
		[SerializeField]
		public Vector2 summonEyelineOffset;
		[SerializeField]
		public Dragon3DOffset dragon3DOffset;
	
		// Nested types
		[Serializable]
		public class Dragon3DOffset
		{
			// Fields
			public Vector3 posOffset;
			public Vector3 rotOffset;
			public float scale;
	
			// Constructors
			public Dragon3DOffset();
		}
	
		[Serializable]
		public class Dragon2DOffset
		{
			// Fields
			public Vector2 posOffset;
			public float scale;
	
			// Constructors
			public Dragon2DOffset();
		}
	
		// Constructors
		public UnitViewOffsetAsset();
	
		// Methods
		public static UnitViewOffsetAsset GetViewOffset(int baseId, int varId);
	}
}
