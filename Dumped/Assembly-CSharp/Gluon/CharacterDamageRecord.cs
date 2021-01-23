/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterDamageRecord
	{
		// Fields
		[CompilerGenerated]
		private int _totalDamage_k__BackingField;
		[CompilerGenerated]
		private int _skillDamage_k__BackingField;
		[CompilerGenerated]
		private int _dotDamage_k__BackingField;
		[CompilerGenerated]
		private int _ciriticalDamage_k__BackingField;
		[CompilerGenerated]
		private int _enchantDamage_k__BackingField;
	
		// Properties
		public int totalDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int skillDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int dotDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int ciriticalDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int enchantDamage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharacterDamageRecord();
	
		// Methods
		public void Record(int damage, bool isSkill, bool isDot, bool isCritical, bool isEnchant);
	}
}
