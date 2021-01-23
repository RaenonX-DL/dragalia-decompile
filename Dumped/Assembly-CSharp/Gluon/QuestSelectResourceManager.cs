/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectResourceManager : SingletonMonoBehaviour<Gluon.QuestSelectResourceManager>
	{
		// Fields
		public Dictionary<QuestResource, string> questSelectResourceDicPath;
		public Dictionary<QuestResource, GameObject> questSelectResourceDic;
	
		// Nested types
		public enum QuestResource
		{
			landMark = 0,
			questNewIcon = 1,
			newBannerGlow = 2,
			twinkleNhaam = 3,
			moveNhaam = 4,
			storyMissionUnlock = 5
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public QuestSelectResourceManager __4__this;
			public QuestResource path;
	
			// Constructors
			public __c__DisplayClass4_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_1
		{
			// Fields
			public bool isLoaded;
			public __c__DisplayClass4_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass4_1();
	
			// Methods
			internal void _LoadAsync_b__0(GameObject result);
			internal bool _LoadAsync_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsync_d__4 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectResourceManager __4__this;
			public QuestResource path;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsync_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectResourceManager();
	
		// Methods
		public GameObject Load(QuestResource path);
		[IteratorStateMachine]
		public IEnumerator LoadAsync(QuestResource path);
		public void ReleaseResources();
	}
}
