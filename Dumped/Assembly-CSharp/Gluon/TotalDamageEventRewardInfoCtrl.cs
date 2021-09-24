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
	public class TotalDamageEventRewardInfoCtrl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text totalDamageValueText;
		[SerializeField]
		private UnityEngine.UI.Text nextRewardText;
		[SerializeField]
		private Gauge needDamageGetNextRewardGauge;
		[SerializeField]
		private Image totalDamageIcon;
	
		// Constructors
		public TotalDamageEventRewardInfoCtrl();
	
		// Methods
		public void SetEventRewardInfo();
		private void SetEventRewardInfo(long currentTotalDamage, bool hasNextReward, long prevRewardDamageValue, long nextRewardDamgeValue);
	}
}
