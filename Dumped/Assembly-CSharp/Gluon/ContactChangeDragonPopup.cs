/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactChangeDragonPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private CommonIcon extraCharaIcon;
		[SerializeField]
		private Transform extraCharaDecoNode;
		[SerializeField]
		public CommonIcon[] recentPettedDragonIcons;
		public Transform[] recentSortDecoNodes;
		public GameObject[] favorIcons;
		public ContactChangeDragonListController listController;
		public ContactChangeDragonListBase listBase;
		public UnityEngine.UI.Text emptyPettedDragonText;
		private List<int> recentMasterIdList;
		private int selectedId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public UnityAction<int> onClose;
			public ContactChangeDragonPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public ContactChangeDragonPopup __4__this;
			public int extraCharaId;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _SetupExtraChara_b__0();
		}
	
		// Constructors
		public ContactChangeDragonPopup();
	
		// Methods
		public static ContactChangeDragonPopup Create(UnityAction<int> onClose);
		public void Setup();
		private void SetupExtraChara();
		private void IconButtonPressed(CommonIconListCellData dataCommon, TableViewCell<CommonIconListCellData> cellCommon);
		public void LoadListData();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList();
		public void OnCloseButtonPressed();
		public void OnSelect(int masterId);
		private bool IsFavor(int dragonId);
		[CompilerGenerated]
		private void _Setup_b__11_0();
		[CompilerGenerated]
		private void _Setup_b__11_1();
		[CompilerGenerated]
		private void _Setup_b__11_2();
		[CompilerGenerated]
		private void _Setup_b__11_3();
		[CompilerGenerated]
		private void _Setup_b__11_4();
	}
}
