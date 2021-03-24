/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CampaignDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _CampaignName;
		[SerializeField]
		private CampaignType _CampaignType;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
		[SerializeField]
		private int _InformationId;
		[SerializeField]
		private int _DropUpImageId;
		[SerializeField]
		private int _CampaignPercent;
		[SerializeField]
		private int _CampainTargetGroupId;
		[SerializeField]
		private int _CampaignOptionValue1;
		[SerializeField]
		private int _CampaignOptionValue2;
	
		// Properties
		public int Id { get; }
		public string CampaignName { get; }
		public CampaignType CampaignType { get; }
		public int SortId { get; }
		public string StartDate { get; }
		public string EndDate { get; }
		public int InformationId { get; }
		public int DropUpImageId { get; }
		public int CampaignPercent { get; }
		public int CampainTargetGroupId { get; }
		public int CampaignOptionValue1 { get; }
		public int CampaignOptionValue2 { get; }
	
		// Constructors
		public CampaignDataElement();
	}
}
