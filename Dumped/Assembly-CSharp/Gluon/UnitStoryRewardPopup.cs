/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitStoryRewardPopup : CommonPopup
	{
		// Fields
		public List<AtgenBuildEventRewardEntityList> questStoryActiveRewardList;
		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> rewardItemList;
		private const float cellSpacing = 20f;
		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/UnitStoryRewardPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Action OnClosed;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public UnitStoryRewardPopup();
	
		// Methods
		public static UnitStoryRewardPopup Create(Transform parentTransform = null, Action OnClosed = null, bool isCastleReward = false);
		public void ReflectParam(QuestRewardTableViewController questRewardTableViewController);
	}
}
