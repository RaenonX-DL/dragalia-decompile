﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampCellListIngame : PageScrollCell<Gluon.StampPageData>
	{
		// Fields
		[SerializeField]
		private StampCellIngame[] stamps;
		public UnityAction<int> onIconPressed;
	
		// Constructors
		public StampCellListIngame();
	
		// Methods
		public override void UpdateContent(StampPageData data);
		public void OnIconPressed(int iconIndex);
	}
}
