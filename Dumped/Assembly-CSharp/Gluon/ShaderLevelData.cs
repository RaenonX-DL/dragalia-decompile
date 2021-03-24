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
	[Serializable]
	public class ShaderLevelData
	{
		// Fields
		public bool enable;
		public ShaderLevelLodData high2;
		public ShaderLevelLodData high1;
		public Shader[] originals;
		public ShaderLevelLodData low1;
		public ShaderLevelLodData low2;
		public ShaderLevelLodData low3;
	
		// Constructors
		public ShaderLevelData();
	
		// Methods
		public ShaderLevelLodData GetLodShader(Shader originalShader, LodLevel level);
	}
}
