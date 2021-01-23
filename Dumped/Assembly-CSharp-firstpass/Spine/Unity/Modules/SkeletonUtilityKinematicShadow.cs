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
	public class SkeletonUtilityKinematicShadow : MonoBehaviour
	{
		// Fields
		[Tooltip]
		public bool detachedShadow;
		public Transform parent;
		public bool hideShadow;
		private GameObject shadowRoot;
		private readonly List<TransformPair> shadowTable;
	
		// Nested types
		private struct TransformPair
		{
			// Fields
			public Transform dest;
			public Transform src;
		}
	
		// Constructors
		public SkeletonUtilityKinematicShadow();
	
		// Methods
		private void Start();
		private static void DestroyComponents(Component[] components);
		private void FixedUpdate();
	}
}
