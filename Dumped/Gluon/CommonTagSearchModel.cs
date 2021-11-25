using System;
using System.Collections.Generic;

namespace Gluon
{
	public class CommonTagSearchModel
	{
		public class TagRecord
		{
			private List<string> tags;

			public void ClearTags()
			{
			}

			public void Add(string s)
			{
			}

			public bool IsMatch(string[] input)
			{
				return default(bool);
			}

			private bool IsMatch(string input)
			{
				return default(bool);
			}
		}

		public enum InfoScale
		{
			Full,
			Basic
		}

		public Action<List<int>> onFilterChanged;

		public Dictionary<int, TagRecord> tagRecords;

		public InfoScale infoScale;

		public static string UnifyString(string s)
		{
			return null;
		}

		private void AddSkillToRecord(TagRecord record, int[] ids)
		{
		}

		private void AddAbilityToRecord(TagRecord record, int[] ids)
		{
		}

		private void AddExAbilityToRecord(TagRecord record, int[] ids)
		{
		}

		private void AddEmblemToRecord(TagRecord record, int emblemId)
		{
		}

		public void AddMasterUnitRecord(GiftType giftType, int id)
		{
		}

		public void OnInputTextChanged(string s)
		{
		}
	}
}
