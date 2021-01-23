/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactReliabilityRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform iconParent;
		private List<CommonIcon> iconList;
		[SerializeField]
		private UnityEngine.UI.Text commentText;
		[SerializeField]
		private GameObject overText;
		private static List<RewardDisplayInfo> sortedRewardList;
		private const int multipleLevelRewardNum = -1;
	
		// Nested types
		private class RewardDisplayInfo
		{
			// Fields
			public int level;
			public List<EntityData> rewardItems;
			public bool sentToPresentBoxFlag;
	
			// Constructors
			public RewardDisplayInfo();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public UnityAction onClose;
			public bool isWalker;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _RunModelOneByOne_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public UnityAction onModelDone;
			public bool isWalker;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnSinglePopupDone_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public UnityAction onClose;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1
		{
			// Fields
			public CommonPopup storyPopupWindow;
			public __c__DisplayClass10_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass10_1();
	
			// Methods
			internal void _Create_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__10_3;
			public static UnityAction __9__10_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Create_b__10_1();
			internal void _Create_b__10_3();
		}
	
		// Constructors
		public ContactReliabilityRewardPopup();
	
		// Methods
		public static void RunModelOneByOne(UnityAction onClose, bool isWalker);
		private static void OnSinglePopupDone(UnityAction onModelDone, bool isWalker);
		private static UnitStoryElement GetReriabilityStory(int dragonId);
		private static void Create(UnityAction onClose, bool isWalker);
		public void Setup(bool isWalker);
		private CommonIcon CreateIcon(EntityData reward);
		protected override void OnDestroy();
	}
}
