/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[ExecuteInEditMode]
	[HelpURL]
	public class SkeletonRenderSeparator : MonoBehaviour
	{
		// Fields
		public const int DefaultSortingOrderIncrement = 5;
		[SerializeField]
		protected SkeletonRenderer skeletonRenderer;
		private MeshRenderer mainMeshRenderer;
		public bool copyPropertyBlock;
		[Tooltip]
		public bool copyMeshRendererFlags;
		public List<SkeletonPartsRenderer> partsRenderers;
		private MaterialPropertyBlock copiedBlock;
	
		// Properties
		public SkeletonRenderer SkeletonRenderer { get; set; }
	
		// Constructors
		public SkeletonRenderSeparator();
	
		// Methods
		public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = true);
		public void AddPartsRenderer(int sortingOrderIncrement = 5);
		private void OnEnable();
		private void OnDisable();
		private void HandleRender(SkeletonRendererInstruction instruction);
	}
}
