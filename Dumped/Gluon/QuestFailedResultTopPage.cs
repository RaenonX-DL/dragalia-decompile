using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestFailedResultTopPage : MonoBehaviour
	{
		[SerializeField]
		private QuestFailedResultMultiRebattlePage multiRebattlePage;

		private int questId;

		private bool rebattleCanFlag;

		private bool isOnPressNext;

		private DateTime rebattleStartTime;

		public const float animationWaitTime = 71f / (678f * (float)Math.PI);

		private UnityEvent backKeyEvent;

		public QuestFailedResultScene sceneObj
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void OnPressNext()
		{
		}

		private void OnRebattlePageDone()
		{
		}

		public void InitByData()
		{
		}

		private void SetBackKey(UnityAction action)
		{
		}

		private void Disconnect()
		{
		}

		private IEnumerator UpdateReBattleCountDown()
		{
			return null;
		}
	}
}
