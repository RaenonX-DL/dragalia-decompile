/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampCellList : PageScrollCell<Gluon.StampPageData>
	{
		// Fields
		[SerializeField]
		private StampCell[] stamps;
		public UnityAction<int> onIconPressed;
	
		// Constructors
		public StampCellList();
	
		// Methods
		public override void UpdateContent(StampPageData data);
		public void OnIconPressed(int iconIndex);
	}
}
