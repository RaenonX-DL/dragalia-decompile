/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultTimeAttackRanking : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private AnimationUIAutoPublisher enterAnimationUIPublish;
		[SerializeField]
		private AnimationUIAutoPublisher exitAnimationUIPublish;
		[SerializeField]
		private QuestResultTimeAttackRankingCell[] cell;
		private int newIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public QuestResultTimeAttackRanking __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _PlayEnterAnimation_b__0();
		}
	
		// Constructors
		public QuestResultTimeAttackRanking();
	
		// Methods
		public static QuestResultTimeAttackRanking Create(Transform parent);
		public void InitSetting();
		public void PlayEnterAnimation(Action callback);
		public void PlayEnterAnimationComplete();
		public void PlayExitAnimation(Action callback);
		public void PlayExitAnimationComplete();
	}
}
