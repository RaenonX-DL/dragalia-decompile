/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListCell : QuestCommonTableViewCell<Gluon.EventRankingListCellData>
	{
		// Fields
		[SerializeField]
		private EventRankingListPartyMemberCell[] partyMemberCellArray;
		[SerializeField]
		private UiImageExchanger rankTitleImageExchanger;
		[SerializeField]
		private UnityEngine.UI.Text rankText;
		[SerializeField]
		public CommonIconButtonEvent buttonPressed;
		private const int specialImageLowestRank = 3;
		private const int mileStoneRankImageIndex = 3;
		private const int defaultRankImageIndex = 4;
		private const int mileStoneNumberUnit = 10;
		private bool _isNeedToUpdateLoadContent;
	
		// Properties
		public bool isNeedToUpdateLoadContent { get; set; }
	
		// Constructors
		public EventRankingListCell();
	
		// Methods
		public override void UpdateContent(EventRankingListCellData data);
		public void UpdateLoadContent(EventRankingListCellData data);
		private bool IsSpecialImageRank(int rank);
		private int GetRankTitleImageIndex(int rank);
	}
}
