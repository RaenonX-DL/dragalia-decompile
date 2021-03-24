/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalRecordListPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public RectTransform layoutParent;
		public GameObject noItemComment;
		public BattleRoyalRecordListCell templateCell;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<BattleRoyalGetBattleRoyalHistoryResponse> __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Create_b__3_0(BattleRoyalGetBattleRoyalHistoryResponse response);
		}
	
		// Constructors
		public BattleRoyalRecordListPopup();
	
		// Methods
		public static void Create();
		protected override void Start();
	}
}
