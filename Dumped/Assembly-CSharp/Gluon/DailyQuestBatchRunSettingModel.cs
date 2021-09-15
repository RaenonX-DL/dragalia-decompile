/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DailyQuestBatchRunSettingModel
	{
		// Fields
		private static DailyQuestBatchRunSettingModel instance;
		[CompilerGenerated]
		private List<int> _TargetQuestList_k__BackingField;
	
		// Properties
		public static DailyQuestBatchRunSettingModel Instance { get; }
		public static bool HasInstance { get; }
		public List<int> TargetQuestList { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		private DailyQuestBatchRunSettingModel();
		static DailyQuestBatchRunSettingModel();
	
		// Methods
		public void AddTargetQuest(int questId);
		public void Clear();
		public bool IsDailyQuestBatchRun();
		public static List<int> GetDailyQuestEventIdList();
	}
}
