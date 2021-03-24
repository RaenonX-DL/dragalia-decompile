/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeaponData
	{
		// Fields
		[CompilerGenerated]
		private WeaponBodyElement _masterData_k__BackingField;
		[CompilerGenerated]
		private WeaponTypeElement _typeData_k__BackingField;
		[CompilerGenerated]
		private int _level_k__BackingField;
		[CompilerGenerated]
		private int _hp_k__BackingField;
		[CompilerGenerated]
		private int _attack_k__BackingField;
		[CompilerGenerated]
		private int _defense_k__BackingField;
		public AbilityDataElement[] abilityData;
	
		// Properties
		public WeaponBodyElement masterData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public WeaponTypeElement typeData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int level { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int hp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int attack { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int defense { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public WeaponData(int weaponId);
	
		// Methods
		public bool Setup(int weaponLv, ElementalType charaElement);
		public void SetAbility(int ability1Lv, int ability2Lv);
	}
}
