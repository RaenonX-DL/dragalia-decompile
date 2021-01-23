/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityStoreHouseCtrl : FacilityContentBase
	{
		// Fields
		[Header]
		[SerializeField]
		public FortMenuGroupType facilityGroup;
		[SerializeField]
		protected RectTransform prefab;
		[SerializeField]
		protected GameObject dialogObj;
		[SerializeField]
		protected UnityEngine.UI.Text noItemText;
		protected List<Facility> list;
	
		// Constructors
		public FacilityStoreHouseCtrl();
	
		// Methods
		private void Start();
		public override void SetNewFlagToFalse();
		[CompilerGenerated]
		private void _SetNewFlagToFalse_b__6_0(UpdateResetNewResponse response);
	}
}
