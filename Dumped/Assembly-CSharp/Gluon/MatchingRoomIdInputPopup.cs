/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomIdInputPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private InputFrame inputFrame;
		[SerializeField]
		private UnityEngine.UI.Text searchButtonText;
		[SerializeField]
		private Button searchButton;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private const int MaxRommInputCount = 7;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _PopupNothingRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public MatchingRoomIdInputPopup __4__this;
			public MatchingGetRoomNameResponse res;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnMatchingGetRoomNameRequestSuccess_b__0(bool isRecoveredStamina);
			internal void _OnMatchingGetRoomNameRequestSuccess_b__1();
		}
	
		// Constructors
		public MatchingRoomIdInputPopup();
	
		// Methods
		public void Initialize(QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation);
		protected override void Start();
		public void OnClearButtonPressed();
		public void OnDeleteButtonPressed();
		public void OnSearchButtonPressed();
		public void OnCancelButtonPressed();
		private void OnNumberButtonPressed(List<string> num);
		private void ServerRoomNameGat(int roomId);
		private void OnMatchingGetRoomNameRequestError(ErrorType errorType, int resultCode);
		public static void PopupNothingRoom();
		private void OnMatchingGetRoomNameRequestSuccess(MatchingGetRoomNameResponse res);
		public static void CheckJoinConditions(GameObject gameObject, int questId, Action<bool> onSuccess);
	}
}
