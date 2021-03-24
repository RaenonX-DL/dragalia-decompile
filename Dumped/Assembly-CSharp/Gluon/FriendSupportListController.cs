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
	public class FriendSupportListController : CommonDualListTableViewController
	{
		// Fields
		[SerializeField]
		private Vector2 weaponListCellSize;
		private WeaponListCellData outButtonData;
		[SerializeField]
		private FriendSupportSettingView settingView;
	
		// Constructors
		public FriendSupportListController();
	
		// Methods
		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateDragonCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateWeaponCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override CommonIconListCellData CreateAmuletCellData(ulong keyIdOrInvalidId, int decoNum);
		protected override void SetupOutButton(CommonIconListType listType);
		public CommonIconListCellData GetCellDataByKeyId(ulong keyId);
		public void SetupWeaponOutButtonData(WeaponType defaultWeaponType);
		public void SetOutButtonState(bool isSelected);
		public void SetLock(CommonEquipIconCellData data, bool isLock);
		public void SetSelectLock(FriendSupportListCellData data, bool isSelect);
	}
}
