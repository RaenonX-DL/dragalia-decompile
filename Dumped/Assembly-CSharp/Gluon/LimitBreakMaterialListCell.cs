/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LimitBreakMaterialListCell : CommonIconListCell
	{
		// Fields
		[SerializeField]
		private GameObject itemCountBaseObject;
		[SerializeField]
		private UnityEngine.UI.Text countText;
	
		// Constructors
		public LimitBreakMaterialListCell();
	
		// Methods
		public override void UpdateContent(CommonIconListCellData data);
		public void SetDragonSphereCountText(int useCount, int needCount);
	}
}
