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
	public class SummonSwitchPopup : PopupBase
	{
		// Fields
		public CSSummonTableViewController tableView;
		public GameObject singleViewOffObject;
		public Transform singleViewContentOffsetTransform;
		private SummonTopItemView itemView;
		private const float singleViewContentOffsetY = -109f;
	
		// Constructors
		public SummonSwitchPopup();
	
		// Methods
		public static SummonSwitchPopup Create(SummonTopItemView itemView);
		public void OnItemPressed(SummonTopData.SwitchableSummonInfo info);
	}
}
