/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WeaponBodyList
	{
		// Fields
		private int _skill_no;
		private int _skill_level;
		private int _ability_1_level;
		private int _ability_2_level;
		public int weapon_body_id;
		public int buildup_count;
		public int limit_break_count;
		public int limit_over_count;
		public int equipable_count;
		public int additional_crest_slot_type_1_count;
		public int additional_crest_slot_type_2_count;
		public int additional_effect_count;
		public int[] unlock_weapon_passive_ability_no_list;
		public int fort_passive_chara_weapon_buildup_count;
		public int is_new;
		public int gettime;
	
		// Properties
		public int skill_no { get; set; }
		public int skill_level { get; set; }
		public int ability_1_level { get; set; }
		public int ability_2_levell { get; set; }
	
		// Constructors
		public WeaponBodyList();
	
		// Methods
		public void ClearCache();
		private void SetupSkillAndAbility();
		private int GetSkillNo();
		private int GetSkillLevel();
		private int GetAbility1Level();
		private int GetAbility2Level();
	}
}
