/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[DisallowMultipleComponent]
	public class SlotBlendModes : MonoBehaviour
	{
		// Fields
		private static Dictionary<MaterialTexturePair, Material> materialTable;
		public Material multiplyMaterialSource;
		public Material screenMaterialSource;
		private Texture2D texture;
		[CompilerGenerated]
		private bool _Applied_k__BackingField;
	
		// Properties
		internal static Dictionary<MaterialTexturePair, Material> MaterialTable { get; }
		public bool Applied { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public struct MaterialTexturePair
		{
			// Fields
			public Texture2D texture2D;
			public Material material;
		}
	
		// Constructors
		public SlotBlendModes();
	
		// Methods
		internal static Material GetMaterialFor(Material materialSource, Texture2D texture);
		private void Start();
		private void OnDestroy();
		public void Apply();
		public void Remove();
		public void GetTexture();
	}
}
