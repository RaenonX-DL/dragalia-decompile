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
	public class ShopQuestBonusButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text remainText;
		[SerializeField]
		private GameObject badge;
		[SerializeField]
		private Button bonusButton;
		private bool preOrderable;
		private QuestBonusData data;
		private const int preOrderableCountDownDay = 3;
		private PointerEventHandler bonusButtonPeh;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__12_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateClaimedPopup_b__12_0();
		}
	
		// Constructors
		public ShopQuestBonusButton();
	
		// Methods
		private void Start();
		private void SetupByRemainings();
		private void Update();
		private void SetAsInactive();
		public void OnButtonPressed();
		private void CreateClaimedPopup(bool isChargeDone);
		public string CreateRenewalRemainDaysComment(int remainDays, long endUnixTime);
	}
}
