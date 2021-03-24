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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonContentListDialog : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text summonRemainText;
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
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AtgenBoxSummonDetail> __9__11_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetupContents_b__11_0(AtgenBoxSummonDetail a, AtgenBoxSummonDetail b);
		}
	
		// Constructors
		public BoxSummonContentListDialog();
	
		// Methods
		private void OnEnable();
		protected override void OnDestroy();
		public void SetCurrentPage(EventQuestPageBase page, bool bOpenFromResultPage);
		private void SetupContents(bool bOpenFromResultPage);
		private void TeardownContents();
		public void OnCloseButton();
	}
}
