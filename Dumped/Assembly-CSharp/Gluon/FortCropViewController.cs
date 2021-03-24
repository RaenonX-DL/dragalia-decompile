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
	public class FortCropViewController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject cropRoot;
		[SerializeField]
		private bool isSwitchDisp;
		[Header]
		[SerializeField]
		private GameObject cropDispOn;
		[SerializeField]
		private GameObject cropDispOff;
		private Renderer[] _renderers;
		private FortSortingOrderSetter[] _sortingOrderSetters;
	
		// Properties
		public Renderer[] renderers { get; }
		public FortSortingOrderSetter[] sortingOrderSetters { get; }
	
		// Constructors
		public FortCropViewController();
	
		// Methods
		public void Disp(bool value);
		public void SetCropDispActive(bool value);
	}
}
