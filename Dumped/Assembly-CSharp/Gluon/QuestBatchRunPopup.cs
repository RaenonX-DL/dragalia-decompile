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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestBatchRunPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform cellParent;
		[SerializeField]
		private UnityEngine.UI.Text emptyQuestText;
		[SerializeField]
		private Button okButton;
		private List<QuestBatchRunSettingCell> cells;
		private UnityEvent okButtonPressedCallback;
		private UnityEvent closePopupCallback;
		private static readonly string cellPrefabPath;
		private static readonly string popupPrefabPath;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _AddClosePopupCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _AddOkButtonPressedCallback_b__0();
		}
	
		// Constructors
		public QuestBatchRunPopup();
		static QuestBatchRunPopup();
	
		// Methods
		public static QuestBatchRunPopup Create(List<int> targetEventIdList);
		private void Initialize(List<int> targetEventIdList);
		public List<int> TakeTargetQuestIdList();
		public void AddClosePopupCallback(UnityAction callback);
		public void OnCloseButtonPressed();
		public void AddOkButtonPressedCallback(UnityAction callback);
		public void OnOkButtonPressed();
		private bool CalculateIsRecievedDailyBonus(int eventId);
		private List<QuestMultipleSkipElement> CreateSkipableQuestDataList(int eventId);
		public void UpdateOkButtonState();
		[CompilerGenerated]
		private void _Initialize_b__9_0();
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__12_0();
		[CompilerGenerated]
		private void _OnOkButtonPressed_b__14_0();
	}
}
