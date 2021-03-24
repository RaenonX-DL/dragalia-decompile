/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMeshInfoParameterGroup
	{
		// Fields
		[NonSerialized]
		private FlMeshParameter _meshParameter;
		public string _textureSetName;
		public Vector2 _textureSetSize;
		public Texture _textureSetColor;
		public Texture _textureSetAlpha;
		public FlColorTextureFormatTypes _textureSetColorFormat;
		public FlAlphaTextureFormatTypes _textureSetAlphaFormat;
		public List<FlMeshInfoParameter> _meshInfoParameterList;
		private Hashtable _meshInfoParameterTable;
		private Hashtable _materialTable;
	
		// Properties
		public FlMeshParameter MeshParameter { get; set; }
		public string TextureSetName { get; set; }
		public Texture TextureSetColor { get; set; }
		public Texture TextureSetAlpha { get; set; }
		public Vector2 TextureSetSize { get; set; }
		public FlColorTextureFormatTypes TextureSetColorFormat { get; set; }
		public FlAlphaTextureFormatTypes TextureSetAlphaFormat { get; set; }
		public List<FlMeshInfoParameter> MeshInfoParameterList { get; set; }
	
		// Constructors
		public FlMeshInfoParameterGroup();
	
		// Methods
		public void _Initialize();
		public bool _CreateMesh(string textureName, List<Mesh> meshList, bool useCustomMesh, ref FlMeshInfoParameter meshInfo, ref Mesh mesh);
		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material);
		private void _CreateMaterial(FlShaderTypes shaderType, int stencilRef, ref Material material);
		private void _CreateCustomMeshMaterial(Texture colorTexture, Texture alphaTexture, FlShaderTypes shaderType, int stencilRef, ref Material material);
		public void _Destroy();
		public bool _SearchMesh(string textureName, ref FlMeshInfoParameter meshInfoParam);
	}
}
