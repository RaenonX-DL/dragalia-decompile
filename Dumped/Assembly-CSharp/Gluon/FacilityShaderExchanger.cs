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
	public class FacilityShaderExchanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected GameObject targetObj;
		[SerializeField]
		private TargetInfo[] targetInfoArray;
		[SerializeField]
		private bool exchangeOnStart;
		[SerializeField]
		private bool exchangeAllChildren;
	
		// Nested types
		[Serializable]
		private struct TargetInfo
		{
			// Fields
			public string targetShaderName;
			public Shader exchangeShader;
			public string[] transferTextureParamNameArray;
			public bool createNewMaterial;
		}
	
		// Constructors
		public FacilityShaderExchanger();
	
		// Methods
		private void Start();
		public void SetShader();
		public void SetMaterialShader(Renderer targetRenderer);
	}
}
