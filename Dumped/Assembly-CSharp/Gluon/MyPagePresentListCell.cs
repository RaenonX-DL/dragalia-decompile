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
	public class MyPagePresentListCell : TableViewCell<Gluon.MyPagePresentListCellData>
	{
		// Fields
		[SerializeField]
		private CommonIcon itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[SerializeField]
		private UnityEngine.UI.Text discriptionText;
		[SerializeField]
		private Button listOnButton;
		[SerializeField]
		private UnityEngine.UI.Text listOnButtonText;
		[SerializeField]
		private UnityEngine.UI.Text dateAreaText;
		private bool isInitialized;
		private PreferredSizeFitter itemNameTextFitter;
		private Vector2 itemNameTextBaseSizeDelta;
		private MyPagePresentListCellData cellData;
	
		// Constructors
		public MyPagePresentListCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(MyPagePresentListCellData data);
		public void OnItemIconLongPressed();
		public void OnListOnButtonPressed();
	}
}
