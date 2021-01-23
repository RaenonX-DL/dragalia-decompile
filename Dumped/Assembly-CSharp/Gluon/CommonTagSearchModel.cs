/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonTagSearchModel
	{
		// Fields
		public Action<List<int>> onFilterChanged;
		public Dictionary<int, TagRecord> tagRecords;
		public InfoScale infoScale;
	
		// Nested types
		public class TagRecord
		{
			// Fields
			private List<string> tags;
	
			// Constructors
			public TagRecord();
	
			// Methods
			public void ClearTags();
			public void Add(string s);
			public bool IsMatch(string[] input);
			private bool IsMatch(string input);
		}
	
		public enum InfoScale
		{
			Full = 0,
			Basic = 1
		}
	
		// Constructors
		public CommonTagSearchModel();
	
		// Methods
		public static string UnifyString(string s);
		private void AddSkillToRecord(TagRecord record, params int[] ids);
		private void AddAbilityToRecord(TagRecord record, params int[] ids);
		private void AddExAbilityToRecord(TagRecord record, params int[] ids);
		private void AddEmblemToRecord(TagRecord record, int emblemId);
		public void AddMasterUnitRecord(GiftType giftType, int id);
		public void OnInputTextChanged(string s);
	}
}
