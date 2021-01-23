/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeaponSkinSelectPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image nowEquipIcon;
		[SerializeField]
		private WeaponSkinSelectListController skinListController;
		[SerializeField]
		private GameObject emptyTextObj;
		private int equipWeaponId;
		private CommonIconListCellData nowSelectData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadSkinList_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WeaponSkinSelectPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSkinList_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public WeaponSkinSelectPopup();
	
		// Methods
		public static WeaponSkinSelectPopup Create(bool showBlackLayer = true);
		public void InitPopup(int nowEquipWeaponId);
		[IteratorStateMachine]
		private IEnumerator LoadSkinList();
		private int[] CreateDataIdList();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		public int GetSelectWeaponSkinId();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void OutButtonPressed();
	}
}
