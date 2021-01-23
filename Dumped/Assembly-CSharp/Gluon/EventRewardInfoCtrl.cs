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
	public class EventRewardInfoCtrl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text totalMetalNumberText;
		[SerializeField]
		private UnityEngine.UI.Text tillNextMetalNumberTextFont16;
		[SerializeField]
		private UnityEngine.UI.Text tillNextMetalNumberTextFont14;
		[SerializeField]
		private CommonIcon nextRewardIcon;
		[SerializeField]
		private Gauge gauge;
		[SerializeField]
		private GameObject randomIconObject;
		[SerializeField]
		private Image buildIconImage;
	
		// Constructors
		public EventRewardInfoCtrl();
	
		// Methods
		private void Start();
		public void SetEventRewardInfo();
		private void SetEventRewardInfo(int currentMetalValue, bool hasPrevReward, bool hasNextReward, int prevItemQuantity = 0, int nextItemQuantity = 0, GiftType nextRewardEntityType = GiftType.NONE, int nextRewardEntityId = 0);
	}
}
