/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class ScrollContentMoveAutoDisabler : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public bool isContentSizeStable;
		private ScrollRect scrollRect;
		private Vector3[] contentWorldCorners;
		private Vector3[] viewportWorldCorners;
	
		// Nested types
		public enum WorldCornerIndex
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}
	
		// Constructors
		public ScrollContentMoveAutoDisabler();
	
		// Methods
		private void Awake();
		private void Update();
		private void AdjustByContentAndViewport();
	}
}
