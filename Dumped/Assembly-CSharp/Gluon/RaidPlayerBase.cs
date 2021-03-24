/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RaidPlayerBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform[] ofs;
		public const int numUI = 7;
		private const float waitSec = 1f;
		[HideInInspector]
		public RaidPlayerUI[] raidPlayer;
		private CharacterManager.PartyInfo partyInfo;
		private Coroutine coroutine;
		private RectTransform rectTrnasform;
		[CompilerGenerated]
		private int _ActiveUINum_k__BackingField;
	
		// Properties
		public int ActiveUINum { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateInfo_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public RaidPlayerBase __4__this;
			private CharacterManager _charaMng_5__2;
			private int _ownerIndex_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateInfo_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RaidPlayerBase();
	
		// Methods
		public static RaidPlayerBase Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
		public void Active(bool b);
		[IteratorStateMachine]
		private IEnumerator UpdateInfo();
		private void Update();
		public void CreateSandTimerUI();
		public void ShowSandTimerUI();
		public void ShowSandTimerUI(int actorId);
		public void HideSandTimerUI();
		public void HideSandTimerUI(int actorId);
		public void SetSandTimerUICount(int actorId, int count);
		public void SetSandTimerUICountColor(int actorId, SandTimerUI.CountColorType type);
		public int GetActorSlot(int actorId);
	}
}
