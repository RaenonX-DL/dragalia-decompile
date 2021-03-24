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
	public class WeaponCommonListCell : CommonIconListCell
	{
		// Fields
		[SerializeField]
		private Image image;
		[SerializeField]
		private UnityEngine.UI.Text weaponName;
		[SerializeField]
		private UnityEngine.UI.Text weaponHp;
		[SerializeField]
		private UnityEngine.UI.Text weaponAtk;
		[SerializeField]
		private UnityEngine.UI.Text hasCount;
		[SerializeField]
		private UnityEngine.UI.Text releaseCount;
		[SerializeField]
		private GameObject selectedEquippedCountGO;
		[SerializeField]
		private UnityEngine.UI.Text selectedEquippedCountText;
		[SerializeField]
		private Transform iconParentTransform;
	
		// Constructors
		public WeaponCommonListCell();
	
		// Methods
		protected override void Start();
		public override void UpdateContent(CommonIconListCellData data);
		public void SetEquipRemainingCount(bool selected, int equippedCount, int equippableCount, bool isSupportFriend);
		public override void LoadUnitIcon();
	}
}
