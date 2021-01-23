/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestRankingButtonCtrl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private PageBase currentPage;
		[SerializeField]
		private Button rewardButton;
		[SerializeField]
		private Badge rewardButtonBadge;
		[SerializeField]
		private Button rankingButton;
		[SerializeField]
		private Badge rankingButtonBadge;
		private bool isInited;
	
		// Constructors
		public EventQuestRankingButtonCtrl();
	
		// Methods
		private void OnEnable();
		private void Start();
		private void OnDestroy();
		private void CheckBadge();
		public void OnRewardButtonTouched();
		public void OnRankingButtonTouched();
		[CompilerGenerated]
		private void _OnRewardButtonTouched_b__10_0();
	}
}
