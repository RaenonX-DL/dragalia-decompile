/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildTopPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public RawImage emblemImage;
		public UnityEngine.UI.Text guildNameText;
		public UnityEngine.UI.Text mottoText;
		public Badge memberListBadge;
		public Transform[] chatNodes;
		public GuildChatView chatViews;
		[SerializeField]
		private GameObject inviteBadge;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildTopPage __4__this;
			private TouchGuardObject _obj_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GuildTopPage();
	
		// Methods
		public static GuildTopPage Create(Transform parent);
		[IteratorStateMachine]
		private IEnumerator Start();
		private void UpdateBadge();
		private void CheckLoginFlow();
		private void CheckOccupationUpdate();
		private bool CheckOcupationUpdateAndReloadScene();
		private void RefreshInfo();
		private void StopPolling();
		private void LoadChatView();
		public void OnMultiButtonPressed();
		public void OnMemberListButtonPressed();
		public void OnOptionButtonPressed();
	}
}
