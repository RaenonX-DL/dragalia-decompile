using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlMeshParameter : FlScriptableObject
	{
		public List<FlCustomMeshInfoParameter> _customMeshInfoParameterList;

		public List<FlMeshInfoParameterGroup> _meshParameterGroupList;

		private Hashtable _customMeshInfoParameterTable;

		public List<FlMeshInfoParameterGroup> MeshParameterGroupList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlCustomMeshInfoParameter> CustomMeshInfoParameterList
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

		public FlCustomMeshInfoParameter _GetCustomMeshInfoParam(string textureName)
		{
			return null;
		}

		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material)
		{
			return default(bool);
		}

		public void _Destroy()
		{
		}

		public bool _SearchMesh(string textureName, ref FlMeshInfoParameterGroup meshInfoParamGroup, ref FlMeshInfoParameter meshInfoParam)
		{
			return default(bool);
		}
	}
}
