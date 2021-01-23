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
	public class MissionWidgetDetail : MonoBehaviour
	{
		// Fields
		private string missionName;
		private string spanDesc;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text textMissionName;
		[Header]
		[SerializeField]
		public bool useTimeSpan;
		public MissionWidgetTimeSpan timeSpan;
		[Header]
		[SerializeField]
		public MissionWidgetDetailReward detailReward;
		public UnityEngine.UI.Text duplicateText;
	
		// Constructors
		public MissionWidgetDetail();
	
		// Methods
		private void Start();
		public void SetTimeSpan(MissionWidgetTimeSpan.Type type, DateTime start, DateTime end);
	}
}
