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
	public class AutoSelectDialogBase : CommonPopup
	{
		// Fields
		public GameObject selectRarity;
		public GameObject selectLevel;
		public GameObject selectPlus;
		public const int defaultConfigDragonRarity = 3;
		public const int defaultConfigWeaponRarity = 2;
		public const int defaultConfigAmuletRarity = 2;
		public const int defaultConfigLevel = 1;
		public const int defaultConfigPlus = 1;
		private int configRarity;
		private int configLevel;
		private int configPlus;
		protected string rarityKey;
		protected string levelKey;
		protected string plusKey;
		protected ConfigTragetType targetType;
		[SerializeField]
		protected UnityEngine.UI.Text dialogMessageText;
		[SerializeField]
		private UnityEngine.UI.Text[] subTitleText;
		[SerializeField]
		private UnityEngine.UI.Text[] rarityText;
		[SerializeField]
		private UnityEngine.UI.Text[] levelText;
		[SerializeField]
		private UnityEngine.UI.Text[] plusText;
		[Header]
		[SerializeField]
		protected UnityEngine.UI.Text countText;
		[SerializeField]
		protected UnityEngine.UI.Text preCountText;
		private Func<int> getAutoSelectCount;
		private int countMax;
	
		// Nested types
		protected enum ConfigTragetType
		{
			None = 0,
			Weapon = 1,
			Dragon = 2,
			Amulet = 3
		}
	
		public enum ConfigLevelType
		{
			None = 0,
			OneOnly = 1,
			All = 2
		}
	
		public enum ConfigPlusType
		{
			None = 0,
			ZeroOnly = 1,
			PlusOnly = 2,
			NoSelect = 3
		}
	
		public enum ConfigType
		{
			Rarity = 0,
			Level = 1,
			Plus = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public int buttonTag;
			public AutoSelectDialogBase __4__this;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _SetupConfigDialog_b__0(bool flg);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_1
		{
			// Fields
			public int buttonTag;
			public AutoSelectDialogBase __4__this;
	
			// Constructors
			public __c__DisplayClass29_1();
	
			// Methods
			internal void _SetupConfigDialog_b__1(bool flg);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_2
		{
			// Fields
			public int buttonTag;
			public AutoSelectDialogBase __4__this;
	
			// Constructors
			public __c__DisplayClass29_2();
	
			// Methods
			internal void _SetupConfigDialog_b__2(bool flg);
		}
	
		// Constructors
		public AutoSelectDialogBase();
	
		// Methods
		public static T Create<T>(bool showBlackLayer = true)
			where T : AutoSelectDialogBase;
		protected void SetupConfigDialog(int countMax, Func<int> getAutoSelectCount);
		private void SetPlayerPrefs();
		public void SetCountText(int countNow);
		protected virtual void OkButtonPressed();
		public void OnToggleChanged(bool isOn);
		public static int[] GetAutoSelectConfigParam(string rarityKey, string levelKey, string plusKey, int defaultConfig);
	}
}
