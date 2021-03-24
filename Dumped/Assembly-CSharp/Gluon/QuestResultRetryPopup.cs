/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
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
	public class QuestResultRetryPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEvent ticketRetryButtonPressed;
		[SerializeField]
		private Button ticketRetryButton;
		[SerializeField]
		public UnityEvent bgButtonPressed;
		[SerializeField]
		public UnityEvent retryButtonPressed;
		[SerializeField]
		private Button staminaRetryButton;
		[SerializeField]
		private Button itemRetryButton;
		[SerializeField]
		private Image questSkipDisabledImage;
		[SerializeField]
		private Image questSkipNotSatisfyConditionsImage;
		[SerializeField]
		private UnityEngine.UI.Text questSkipTicketNumText;
		[SerializeField]
		private UnityEngine.UI.Text questStaminaNumText;
		[SerializeField]
		private GameObject questStaminaButtonObjext;
		[SerializeField]
		private GameObject questItemButtonObjext;
		[SerializeField]
		private Image questItemButtonItemImage;
		[SerializeField]
		private UnityEngine.UI.Text[] questUseSkipTicketNumText;
		[SerializeField]
		private UnityEngine.UI.Text[] questUseStaminaNumText;
		[SerializeField]
		private UnityEngine.UI.Text[] questUseItemNumText;
		[SerializeField]
		private GameObject staminaGuageParent;
		[SerializeField]
		private Gauge staminaGuage;
		[SerializeField]
		private float intervalTime;
		private int givenQuestId;
		private DateTime prevUpdateTime;
		private const float updateInterval = 1f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _OnTicketRetryButtonPressedCorutine_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultRetryPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnTicketRetryButtonPressedCorutine_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnRetryButtonPressedCorutine_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestResultRetryPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnRetryButtonPressedCorutine_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestResultRetryPopup();
	
		// Methods
		public static QuestResultRetryPopup Create(Transform parentTransform = null);
		public void Init(int questId);
		public void Update();
		private void SetStamina();
		public void SetUseStaminaText(int questStaminaUse, bool isStaminaCampaign);
		private void SetRetryButton(int questStaminaUse, QuestDataElement qde);
		public void SetUseTicketText(int questSkipTicketUse, bool isLackOfTicket);
		public void OnSkipDisabledButton();
		public void OnSkipNotSatisfyConditions();
		public void OnTicketRetryButtonPressed();
		[IteratorStateMachine]
		private IEnumerator OnTicketRetryButtonPressedCorutine();
		public void OnRetryButtonPressed();
		[IteratorStateMachine]
		private IEnumerator OnRetryButtonPressedCorutine();
		public void OnBgButtonPressed();
	}
}
