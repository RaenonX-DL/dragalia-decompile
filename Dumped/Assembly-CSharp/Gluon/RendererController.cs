/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[ExecuteAlways]
	[RequireComponent]
	public class RendererController : MonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		private int _minorSortingOrder;
		private Renderer _renderer;
		private int _majorSortingOrder;
		private int _sortingScale;
		private int _sortingOtherOffset;
	
		// Constructors
		public RendererController();
	
		// Methods
		private void UpdateRenderer();
		public void SetSortingOrder(int sortingOrder, int sortingScale, int sortingOtherOffset, bool isSetFinal);
		public void SetMinorSortingOrder(int sortingOrder);
		private void Start();
	}
}
