/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AmuletData
	{
		// Fields
		[CompilerGenerated]
		private AbilityCrestElement _masterData_k__BackingField;
		[CompilerGenerated]
		private int _level_k__BackingField;
		[CompilerGenerated]
		private int _hp_k__BackingField;
		[CompilerGenerated]
		private int _attack_k__BackingField;
		public AbilityDataElement[] abilityData;
		public int[] abilityLv;
	
		// Properties
		public AbilityCrestElement masterData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int level { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int hp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int attack { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public AmuletData(int amuletId);
	
		// Methods
		public bool Setup(int amuletLv, int plusHp, int plusAttack);
		public void SetupAbility(int ability1Lv, int ability2Lv);
	}
}
