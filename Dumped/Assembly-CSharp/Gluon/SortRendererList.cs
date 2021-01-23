/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SortRendererList : List<Renderer>
	{
		// Fields
		[CompilerGenerated]
		private int _sortingOrder_k__BackingField;
		[CompilerGenerated]
		private int _sortingOrderOffset_k__BackingField;
		[CompilerGenerated]
		private bool _isEntryMaterial_k__BackingField;
		[CompilerGenerated]
		private bool _isManagerDestroy_k__BackingField;
		[CompilerGenerated]
		private Dictionary<Material, Material> _instanceMaterialsDictionary_k__BackingField;
	
		// Properties
		public int sortingOrder { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int sortingOrderOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEntryMaterial { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isManagerDestroy { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<Material, Material> instanceMaterialsDictionary { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SortRendererList();
	
		// Methods
		public void CreateInstanceMatearial(int setRenderQueue, bool isEntry, bool isDestroy);
		public void Destroy();
		public void SetVisible(bool enable);
		public void SetShader(Shader shader);
		public bool RemoveRenderer(Renderer r);
	}
}
