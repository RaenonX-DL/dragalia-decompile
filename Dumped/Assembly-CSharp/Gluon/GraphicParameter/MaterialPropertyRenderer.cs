/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class MaterialPropertyRenderer : MaterialPropertyData
	{
		// Fields
		public List<RendererData> rendererDataList;
	
		// Nested types
		[Serializable]
		public class RendererData
		{
			// Fields
			public Renderer renderer;
			public int materialIndex;
	
			// Constructors
			public RendererData(Renderer r = null, int index = -1);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Renderer renderer;
			public int index;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal bool _AddRenderer_b__0(RendererData x);
		}
	
		// Constructors
		public MaterialPropertyRenderer(string name);
	
		// Methods
		public void AddRenderer(Renderer[] renderers, int index = -1);
		public void AddRenderer(List<Renderer> renderers, int index = -1);
		public void AddRenderer(Renderer renderer, int index = -1);
		public void SetPropertyBlockAll();
	}
}
