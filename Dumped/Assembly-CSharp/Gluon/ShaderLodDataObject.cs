/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class ShaderLodDataObject : ScriptableObject
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private ShaderLevelData[] _shaderLevelDataList;
		[SerializeField]
		[Tooltip]
		private Shader[] _shaderIgnoreList;
		[SerializeField]
		[Tooltip]
		private SwitchShaderData[] switchShaderDataArray;
	
		// Nested types
		[Serializable]
		public class SwitchShaderData
		{
			// Fields
			[Tooltip]
			public string name;
			[Tooltip]
			public Shader defaultShader;
			[Tooltip]
			public Shader silhouetteShader;
			[Tooltip]
			public Shader richShader;
			[Tooltip]
			public Shader silhouetteRichShader;
	
			// Constructors
			public SwitchShaderData();
		}
	
		// Constructors
		public ShaderLodDataObject();
	
		// Methods
		public Shader GetSilhouetteSwitchShader(Shader shader, bool isDefault);
		public SwitchShaderData GetSwitchShaderData(Shader shader);
		public ShaderLevelLodData GetLodShader(Shader originalShader, LodLevel level);
	}
}
