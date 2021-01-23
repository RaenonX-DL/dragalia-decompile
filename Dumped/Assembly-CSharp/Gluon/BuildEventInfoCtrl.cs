/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BuildEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text[] materialTexts;
		[SerializeField]
		private Image[] materialIcons;
		[SerializeField]
		private UnityEngine.UI.Text buildLevel;
		[SerializeField]
		private UnityEngine.UI.Text facilityDescription;
		[SerializeField]
		private UnityEngine.UI.Text noFacilityDescription;
		[SerializeField]
		private UnityEngine.UI.Text facilityTitle;
		[SerializeField]
		private CommonIcon buildIcon;
		private int fortPlantId;
		private int fortPlantLevel;
	
		// Constructors
		public BuildEventInfoCtrl();
	
		// Methods
		public static BuildEventInfoCtrl Create(Transform parent);
		protected override void Start();
		public static BuildList GetBuildPlantData(int eventId);
		public override void SetEventInfo();
		public void OnButtonDetailTouched();
	}
}
