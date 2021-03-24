/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ShaderParam
{
	public class ShaderParamController : MonoBehaviour
	{
		// Fields
		public bool m_IsEditorOnlyUpdate;
		public ShaderParamVector4[] m_ShaderParamVector;
		public ShaderParamColor[] m_ShaderParamColor;
		public ShaderParamFloat[] m_ShaderParamFloat;
		public ShaderParamInt[] m_ShaderParamInt;
		public ShaderParamFloatArray[] m_ShaderParamFloatArray;
		public ShaderParamVectorArray[] m_ShaderParamVectorArray;
		public ShaderParamTexture[] m_ShaderParamTextureArray;
		public ShaderKeyword[] m_ShaderKeywords;
		private ShaderParamObject[][] m_ShaderParamObjectArrays;
	
		// Constructors
		public ShaderParamController();
	
		// Methods
		private void SetShaderParamObjectArrays();
		private void SetShaderKeywords();
		private void Start();
		private void Update();
		public void FindShaderParam(out ShaderParamVector4 param, string name);
		public void FindShaderParam(out ShaderParamFloat param, string name);
		public void AddShaderParam(ShaderParamFloat param);
		public void AddShaderParam(ShaderParamVector4 param);
	}
}
