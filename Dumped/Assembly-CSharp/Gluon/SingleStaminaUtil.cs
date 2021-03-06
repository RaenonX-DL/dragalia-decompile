﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SingleStaminaUtil : StaminaUtilBase
	{
		// Fields
		private static SingleStaminaUtil instance;
		private StoneRecoverValue _stoneRecoverValue;
		private StoneRecoverValue _stoneRecoverValueForSpecialPack;
	
		// Properties
		public static SingleStaminaUtil Instance { get; }
		public override StoneRecoverValue stoneRecoverValue { get; }
		public override StoneRecoverValue stoneRecoverValueForSpecialPack { get; }
		public override int autoRecoveryStaminaMax { get; }
		public override int absoluteStaminaMax { get; }
		public override int autoRecoveryTimeInMinute { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<UseItemElement, int> __9__21_0;
			public static Func<UseItemElement, int> __9__21_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetUsableItemList_b__21_0(UseItemElement x);
			internal int _GetUsableItemList_b__21_1(UseItemElement x);
		}
	
		// Constructors
		private SingleStaminaUtil();
		static SingleStaminaUtil();
	
		// Methods
		public static void DeleteInstance();
		public override void ReloadCampaignData();
		public override void ClearStoneRecoverValue();
		public override string GetStaminaText();
		public override List<UseItemElement> GetUsableItemList();
	}
}
