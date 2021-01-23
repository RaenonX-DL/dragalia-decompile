/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionWidgetAchievement : MonoBehaviour
	{
		// Fields
		public int numCleared;
		public int numQuota;
		[Header]
		[SerializeField]
		public Slider gauge;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text textRate;
	
		// Constructors
		public MissionWidgetAchievement();
	
		// Methods
		private void UpdateRateText();
		private void UpdateGauge();
		public void SetClearedValue(int numCleared);
		public void Set(int numCleared, int numQuota);
	}
}
