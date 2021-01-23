/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class AbilityCrestList
	{
		// Fields
		private int _ability_1_level;
		private int _ability_2_level;
		public int ability_crest_id;
		public int buildup_count;
		public int limit_break_count;
		public int equipable_count;
		public int hp_plus_count;
		public int attack_plus_count;
		public int is_new;
		public int gettime;
	
		// Properties
		public int ability_1_level { get; set; }
		public int ability_2_level { get; set; }
	
		// Constructors
		public AbilityCrestList();
	
		// Methods
		public void ClearCache();
		private void SetupAbility();
		private int GetAbility1Level();
		private int GetAbility2Level();
	}
}
