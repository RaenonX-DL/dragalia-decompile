/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopDrawMaterialSummonOddsPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text detailText;
		public ShopDrawMaterialSummonOddsTableViewController tableView;
		private List<ShopDrawMaterialSummonOddsTableViewData> dataList;
	
		// Constructors
		public ShopDrawMaterialSummonOddsPopup();
	
		// Methods
		public static ShopDrawMaterialSummonOddsPopup Create(List<ShopDrawMaterialSummonOddsTableViewData> dataList);
		protected override void Start();
	}
}
