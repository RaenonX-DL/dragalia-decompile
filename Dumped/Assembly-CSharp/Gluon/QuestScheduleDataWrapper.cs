/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestScheduleDataWrapper
	{
		// Fields
		[CompilerGenerated]
		private int _QuestId_k__BackingField;
		[CompilerGenerated]
		private DateTime _StartDate_k__BackingField;
		[CompilerGenerated]
		private DateTime _EndDate_k__BackingField;
		[CompilerGenerated]
		private int _IntervalType_k__BackingField;
		[CompilerGenerated]
		private bool _IsGeneratedByLegacyData_k__BackingField;
		private int campaignPercent;
	
		// Properties
		public int QuestId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DateTime StartDate { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DateTime EndDate { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int IntervalType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsGeneratedByLegacyData { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public QuestScheduleDetailList questScheduleDetail;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal bool _Convert_b__0(QuestDataElement e);
			internal QuestScheduleDataWrapper _Convert_b__1(QuestDataElement e);
		}
	
		// Constructors
		public QuestScheduleDataWrapper(int questId, QuestScheduleDetailList questScheduleDetail);
	
		// Methods
		public static List<QuestScheduleDataWrapper> Convert(QuestScheduleDetailList questScheduleDetail);
		public int GetDropUpCampaignPercent();
	}
}
