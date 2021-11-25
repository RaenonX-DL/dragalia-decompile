using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMeshInfoParameterGroup
	{
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

		public FlMeshParameter MeshParameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TextureSetName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture TextureSetColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture TextureSetAlpha
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 TextureSetSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public FlColorTextureFormatTypes TextureSetColorFormat
		{
			get
			{
				return default(FlColorTextureFormatTypes);
			}
			set
			{
			}
		}

		public FlAlphaTextureFormatTypes TextureSetAlphaFormat
		{
			get
			{
				return default(FlAlphaTextureFormatTypes);
			}
			set
			{
			}
		}

		public List<FlMeshInfoParameter> MeshInfoParameterList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void _Initialize()
		{
		}

		public bool _CreateMesh(string textureName, List<Mesh> meshList, bool useCustomMesh, ref FlMeshInfoParameter meshInfo, ref Mesh mesh)
		{
			return default(bool);
		}

		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material)
		{
			return default(bool);
		}

		private void _CreateMaterial(FlShaderTypes shaderType, int stencilRef, ref Material material)
		{
		}

		private void _CreateCustomMeshMaterial(Texture colorTexture, Texture alphaTexture, FlShaderTypes shaderType, int stencilRef, ref Material material)
		{
		}

		public void _Destroy()
		{
		}

		public bool _SearchMesh(string textureName, ref FlMeshInfoParameter meshInfoParam)
		{
			return default(bool);
		}
	}
}
