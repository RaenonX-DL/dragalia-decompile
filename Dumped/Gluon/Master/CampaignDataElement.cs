using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CampaignDataElement : IMasterElement
	{
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

		public int Id => default(int);

		public string CampaignName => null;

		public CampaignType CampaignType => default(CampaignType);

		public int SortId => default(int);

		public string StartDate => null;

		public string EndDate => null;

		public int InformationId => default(int);

		public int DropUpImageId => default(int);

		public int CampaignPercent => default(int);

		public int CampainTargetGroupId => default(int);

		public int CampaignOptionValue1 => default(int);

		public int CampaignOptionValue2 => default(int);
	}
}
