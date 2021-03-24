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
	[CreateAssetMenu]
	public class BackgroundImageLayerObject : ScriptableObject
	{
		// Fields
		public BackgroundImageLayer[] layerData;
	
		// Nested types
		[Serializable]
		public class BackgroundImageLayer
		{
			// Fields
			public Material material;
			public Vector2 scrollSpeed;
			public float trancateTop;
			public float trancateBottom;
			public Vector2 offsetUV;
	
			// Constructors
			public BackgroundImageLayer();
		}
	
		// Constructors
		public BackgroundImageLayerObject();
	}
}
