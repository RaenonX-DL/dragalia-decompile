/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AutoMaterialSelectDialog : AutoSelectDialogBase
	{
		// Fields
		public UnityAction autoSelectAction;
		public const string configDragonRarityKey = "AutoMaterialSelectDragonRarity";
		public const string configWeaponRarityKey = "AutoMaterialSelectWeaponRarity";
		public const string configAmuletRarityKey = "AutoMaterialSelectAmuletRarity";
		public const string configDragonLevelKey = "AutoMaterialSelectDragonLevel";
		public const string configWeaponLevelKey = "AutoMaterialSelectWeaponLevel";
		public const string configAmuletLevelKey = "AutoMaterialSelectAmuletLevel";
		public const string configDragonPlusKey = "AutoMaterialSelectDragonPlus";
		public const string configWeaponPlusKey = "AutoMaterialSelectWeaponPlus";
		public const string configAmuletPlusKey = "AutoMaterialSelectAmuletPlus";
	
		// Constructors
		public AutoMaterialSelectDialog();
	
		// Methods
		public static AutoMaterialSelectDialog Create();
		public void SetupConfigDialog(GrowthBaseType type, int countMax, Func<int> getAutoSelectCount);
		protected override void OkButtonPressed();
		public static int[] GetAutoSelectConfigParam(GrowthBaseType baseType);
	}
}
