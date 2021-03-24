/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExRushTopCharaButton : MonoBehaviour, ICustomMessage
	{
		// Fields
		[Header]
		[SerializeField]
		public Type type;
		[Header]
		[SerializeField]
		public QuestStateIcon stateIcon;
		[Header]
		[SerializeField]
		public ButtonWithSelectedImage buttonWithSelectedImage;
		public GameObject eyeDirection;
		public Button button;
		public GameObject iconGO;
		public Transform[] scaleTransforms;
		[Header]
		[SerializeField]
		public GameObject rushParentGO;
		public GameObject wParentGO;
		public GameObject[] subFaces;
		[Header]
		[SerializeField]
		public Badge mainBadge;
		public GameObject pickupMissionBadge;
		[Header]
		[SerializeField]
		public RawImage wMovieImage;
		public int wMovieRow;
		public int wMovieColumn;
		public int wMovieSize;
		public float beforeWMovieWait;
		private const string prefUnlockW = "ExRushUnlockW";
		private Coroutine unlockCoroutine;
	
		// Properties
		private bool isEventEnded { get; }
	
		// Nested types
		public enum Type
		{
			Fire = 0,
			Wind = 1,
			Dark = 2,
			Water = 3,
			Rush = 4,
			Light = 5,
			Story = 6,
			Trade = 7,
			Mission = 8
		}
	
		[CompilerGenerated]
		private sealed class _RunUnlock_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ExRushTopCharaButton __4__this;
			private TouchGuardObject _touchGuardObj_5__2;
			private float _w_5__3;
			private float _h_5__4;
			private int _i_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RunUnlock_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<QuestEventMenuElement, int> __9__26_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetQuestList_b__26_0(QuestEventMenuElement x);
		}
	
		// Constructors
		public ExRushTopCharaButton();
	
		// Methods
		public void OnPageBecomeActive();
		private void DisableButton(bool withIcon = true);
		private void UpdateRush(List<QuestEventMenuElement> menuDataList);
		[IteratorStateMachine]
		private IEnumerator RunUnlock();
		private List<QuestEventMenuElement> GetQuestList(bool onlyAvailable, bool excludeQuestAfterEnd);
		private void LateUpdate();
		private void UpdateBadge();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void OnPressed();
		[CompilerGenerated]
		private void _OnPressed_b__30_1();
		[CompilerGenerated]
		private void _OnPressed_b__30_0(MissionSelectPopup popup);
		[CompilerGenerated]
		private void _OnPressed_b__30_2();
	}
}
