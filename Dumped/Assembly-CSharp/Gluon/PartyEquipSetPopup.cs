/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipSetPopup : CommonPopup
	{
		// Fields
		public Image[] charaIcons;
		public GameObject[] selectedIcons;
		public Transform listParentTransform;
		public GameObject originCell;
		public Action<int, int> selectEquipSetCallBack;
		private PartyEquipSetPopupCell[] cells;
		private int selectCharaIndex;
		private int[] partyCharaIds;
		public const int maxSetCount = 3;
	
		// Nested types
		[CompilerGenerated]
		private struct _SendRegistData_d__13 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public PartyEquipSetPopup __4__this;
			public int dataIndex;
			public string setName;
			private TaskAwaiter<CharaSetCharaUnitSetResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyEquipSetPopup();
	
		// Methods
		public static PartyEquipSetPopup Create();
		public void InitPopup(int defaultSelectIndex);
		public void UpdateCellList();
		public void OnCharaIconPressed(int index);
		private async void SendRegistData(int dataIndex, string setName);
		private AtgenRequestCharaUnitSetData CreateRegistData(bool isNameEditOnly, int dataIndex);
		private void SelectCrestSet(int setIndex);
	}
}
