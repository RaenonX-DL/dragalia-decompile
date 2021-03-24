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
	[ExecuteAlways]
	public class FortRenderQueueSetter : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private RenderQueueType renderQueue;
		[SerializeField]
		private int additionalOrder;
		private Renderer[] myRenderers;
		[SerializeField]
		private bool isMaterialShared;
	
		// Nested types
		public enum RenderQueueType
		{
			Background = 1000,
			Geometry = 2000,
			AlphaTest = 2450,
			Transparent = 3000,
			Overlay = 4000
		}
	
		// Constructors
		public FortRenderQueueSetter();
	
		// Methods
		private void Start();
		private void OnValidate();
		public void SetRenderQueueToAllMaterials();
	}
}
