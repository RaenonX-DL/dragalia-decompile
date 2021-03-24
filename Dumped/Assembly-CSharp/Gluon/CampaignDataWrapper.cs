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
	public class CampaignDataWrapper
	{
		// Fields
		private const int dropUpCampaignInformationId = 19999;
		[CompilerGenerated]
		private int _CampaignDataId_k__BackingField;
		[CompilerGenerated]
		private CampaignType _CampaignType_k__BackingField;
		[CompilerGenerated]
		private string _EndDate_k__BackingField;
		[CompilerGenerated]
		private string _CampaignName_k__BackingField;
		[CompilerGenerated]
		private int _InformationId_k__BackingField;
		[CompilerGenerated]
		private int _SortId_k__BackingField;
		[CompilerGenerated]
		private int _CampaignPercent_k__BackingField;
	
		// Properties
		public int CampaignDataId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CampaignType CampaignType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string EndDate { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string CampaignName { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int InformationId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int SortId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int CampaignPercent { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CampaignDataWrapper(CampaignDataElement campaignData);
		public CampaignDataWrapper(QuestScheduleDataWrapper questEventSchedule);
	}
}
