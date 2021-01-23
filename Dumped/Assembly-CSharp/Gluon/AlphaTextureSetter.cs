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
	public class AlphaTextureSetter : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private SpriteRenderer mainRenderer;
		[SerializeField]
		private Texture2D alphaTexture;
		[SerializeField]
		private SpriteRendererAlphaTexPair[] subRenderers;
		private MaterialPropertyBlock materialPropertyBlock;
		private int shaderAlphaTexID;
		private bool isSetAlphaTex;
	
		// Properties
		public Texture2D ExternalAlphaTexture { get; set; }
		public SpriteRendererAlphaTexPair[] subRenderArray { get; }
	
		// Nested types
		[Serializable]
		public struct SpriteRendererAlphaTexPair
		{
			// Fields
			public SpriteRenderer renderer;
			public Texture2D alphaTexture;
		}
	
		// Constructors
		public AlphaTextureSetter();
	
		// Methods
		private void Start();
	}
}
