/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRankingPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		private AnimationUIAutoPublisher enterAnimationUIPublish;
		[SerializeField]
		private AnimationUIAutoPublisher exitAnimationUIPublish;
		[Header]
		[SerializeField]
		private QuestResultRankingCell[] cell;
		private int newIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public QuestResultRankingPage __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _PlayEnterAnimation_b__0();
		}
	
		// Constructors
		public QuestResultRankingPage();
	
		// Methods
		public static QuestResultRankingPage Create(Transform parent);
		public void InitSetting(TimeAttackRanking.RankingInfo[] timeAttackRankingInfo);
		public void InitSetting(TotalDamageEventRankingData.RankingInfo[] totalDamageEventRankingInfo);
		public void PlayEnterAnimation(Action callback);
		public void PlayEnterAnimationComplete();
		public void PlayExitAnimation(Action callback);
		public void PlayExitAnimationComplete();
	}
}
