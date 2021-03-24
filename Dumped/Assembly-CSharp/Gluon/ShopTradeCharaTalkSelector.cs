/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeCharaTalkSelector : OutGameTopCharaTalkSelector
	{
		// Fields
		public static Queue<int> myLastPlayedQueue;
		private bool isInitialSelectDone;
		private TalkData specialPackTalkData;
		private TalkData dailyMaterialTalkData;
		private TalkData weeklyMaterialTalkData;
		private TalkData monthlyMaterialTalkData;
		private TalkData expendableTalkData;
		private TalkData tradeTalkData;
		[CompilerGenerated]
		private int _activeMenuGroupId_k__BackingField;
		[CompilerGenerated]
		private int _activeImageId_k__BackingField;
	
		// Properties
		public int activeMenuGroupId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int activeImageId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ShopTradeCharaTalkSelector();
		static ShopTradeCharaTalkSelector();
	
		// Methods
		public static void ClearLastPlayedQueue();
		public TalkData SelectTalk(ShopCommonPage.TalkTypeInfo info);
		public override void Awake();
		protected override TalkData SelectFromSpecialList();
	}
}
