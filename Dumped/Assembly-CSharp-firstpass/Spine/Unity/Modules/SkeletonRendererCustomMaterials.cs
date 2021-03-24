/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[ExecuteInEditMode]
	public class SkeletonRendererCustomMaterials : MonoBehaviour
	{
		// Fields
		public SkeletonRenderer skeletonRenderer;
		[SerializeField]
		protected List<SlotMaterialOverride> customSlotMaterials;
		[SerializeField]
		protected List<AtlasMaterialOverride> customMaterialOverrides;
	
		// Nested types
		[Serializable]
		public struct SlotMaterialOverride : IEquatable<SlotMaterialOverride>
		{
			// Fields
			public bool overrideDisabled;
			[SpineSlot]
			public string slotName;
			public Material material;
	
			// Methods
			public bool Equals(SlotMaterialOverride other);
		}
	
		[Serializable]
		public struct AtlasMaterialOverride : IEquatable<AtlasMaterialOverride>
		{
			// Fields
			public bool overrideDisabled;
			public Material originalMaterial;
			public Material replacementMaterial;
	
			// Methods
			public bool Equals(AtlasMaterialOverride other);
		}
	
		// Constructors
		public SkeletonRendererCustomMaterials();
	
		// Methods
		private void SetCustomSlotMaterials();
		private void RemoveCustomSlotMaterials();
		private void SetCustomMaterialOverrides();
		private void RemoveCustomMaterialOverrides();
		private void OnEnable();
		private void OnDisable();
	}
}
