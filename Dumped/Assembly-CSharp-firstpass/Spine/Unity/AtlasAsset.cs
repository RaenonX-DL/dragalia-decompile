/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class AtlasAsset : ScriptableObject
	{
		// Fields
		public TextAsset atlasFile;
		public Material[] materials;
		protected Atlas atlas;
	
		// Properties
		public bool IsLoaded { get; }
	
		// Constructors
		public AtlasAsset();
	
		// Methods
		public static AtlasAsset CreateRuntimeInstance(TextAsset atlasText, Material[] materials, bool initialize);
		public static AtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Material materialPropertySource, bool initialize);
		public static AtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Shader shader, bool initialize);
		private void Reset();
		public virtual void Clear();
		public virtual Atlas GetAtlas();
		public Mesh GenerateMesh(string name, Mesh mesh, out Material material, float scale = 0.01f);
	}
}
