/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyPager : CommonPager
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Party/Party/PartyPager";
		[SerializeField]
		private Toggle toggle;
		[SerializeField]
		private Image onElementalImage;
		[SerializeField]
		private Image offElementalImage;
		[SerializeField]
		private Image onNoLeaderImage;
		[SerializeField]
		private Image offNoLeaderImage;
		[SerializeField]
		private UnityEngine.UI.Text noLeaderPageText;
		[SerializeField]
		private Image onCheckImage;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public UnityAction<int> onPagerPressed;
			public Action<int> __9__0;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _CreatePager_b__0(int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public UnityAction onSuccess;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _ChangeParty_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__16_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ChangeParty_b__16_1(ErrorType error, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public int oldCurrentPartyIndex;
	
			// Constructors
			public __c__DisplayClass17_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public CommonPopup errorPopup;
			public __c__DisplayClass17_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _CheckTemporaryCharaInParty_b__0();
			internal void _CheckTemporaryCharaInParty_b__1();
		}
	
		// Constructors
		public PartyPager();
	
		// Methods
		public static GameObject GetPrefab();
		public override void SetOn(bool on);
		public void SetElementalImage(ElementalType type);
		public override void SetIndex(int pageIndex);
		public void SetToggleInteractable(bool isEnable);
		public static void CreatePager(GameObject pagerParent, List<PartyPager> pagers, int pageCount, float pagerWidth, UnityAction<int> onPagerPressed, int startPartyIndex = -1);
		public static void UpdatePagerElementImage(List<PartyPager> pagers, int pageIndex, int startPartyIndex);
		public static void UpdatePager(GameObject pagerParent, List<PartyPager> pagers, int selectIndex);
		public static void ChangeParty(int index, UnityAction onSuccess);
		private static void CheckTemporaryCharaInParty(int oldCurrentPartyIndex);
	}
}
