/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AutoSellSelectDialog : AutoSelectDialogBase
	{
		// Fields
		public UnityAction okButtonCallBack;
		public const string configDragonRarityKey = "AutoSellSelectDragonRarity";
		public const string configWeaponRarityKey = "AutoSellSelectWeaponRarity";
		public const string configAmuletRarityKey = "AutoSellSelectAmuletRarity";
		public const string configDragonLevelKey = "AutoSellSelectDragonLevel";
		public const string configWeaponLevelKey = "AutoSellSelectWeaponLevel";
		public const string configAmuletLevelKey = "AutoSellSelectAmuletLevel";
		public const string configDragonPlusKey = "AutoSellSelectDragonPlus";
		public const string configWeaponPlusKey = "AutoSellSelectWeaponPlus";
		public const string configAmuletPlusKey = "AutoSellSelectAmuletPlus";
	
		// Constructors
		public AutoSellSelectDialog();
	
		// Methods
		public static AutoSellSelectDialog Create();
		public void SetupConfigDialog(SellListType type, int countMax, Func<int> getAutoSelectCount);
		protected override void OkButtonPressed();
		public static int[] GetAutoSelectConfigParam(SellListType listType);
	}
}
