/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class MaterialPropertyData
	{
		// Fields
		[CompilerGenerated]
		private MaterialPropertyBlock _materialPropertyBlock_k__BackingField;
	
		// Properties
		public bool isEnable { get; }
		public MaterialPropertyBlock materialPropertyBlock { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public MaterialPropertyData(string name);
	
		// Methods
		public void SetPropertyBlock(Renderer renderer, int materialIndex = -1);
	}
}
