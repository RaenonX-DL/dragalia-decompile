/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonResultPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private GameObject pickupItemsObj;
		[SerializeField]
		private UnityEngine.UI.Text summonObtainedText;
		[SerializeField]
		private GameObject rewardListContent;
		[SerializeField]
		private GameObject mainRewardBase;
		[SerializeField]
		private GameObject mainRewardItemTemplate;
		[SerializeField]
		private GameObject rewardLineTemplate;
		private List<GameObject> rewardIconInstances;
		private EventQuestPageBase currentPage;
	
		// Nested types
		public class BoxSummonResultData
		{
			// Fields
			public int entityId;
			public GiftType entityType;
			public int quantity;
			public int count;
	
			// Constructors
			public BoxSummonResultData(int entity_id, int entity_type, int entity_quantity, int count);
		}
	
		public class BoxSummonResultPickUpData
		{
			// Fields
			public int entityId;
			public GiftType entityType;
			public int quantity;
			public int count;
			public int pickupItemState;
			public int twoStepId;
	
			// Constructors
			public BoxSummonResultPickUpData(int entity_id, int entity_type, int entity_quantity, int count, int pick, int two);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public BoxSummonResultData itemData;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _SetupContents_b__1(AtgenBoxSummonDetail a);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<BoxSummonResultPickUpData> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetupContents_b__14_0(BoxSummonResultPickUpData a, BoxSummonResultPickUpData b);
		}
	
		// Constructors
		public BoxSummonResultPopup();
	
		// Methods
		public static BoxSummonResultPopup Create();
		private void OnEnable();
		protected override void OnDestroy();
		public void SetCurrentPage(EventQuestPageBase page);
		private void SetupContents();
		private void TeardownContents();
		public void OnCloseButton();
	}
}
