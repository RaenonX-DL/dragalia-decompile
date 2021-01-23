/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSortFilterUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GiftType[] disableTargetSortTypes;
		[Header]
		[SerializeField]
		private CommonSortModel.Preset[] disableTargetSortPresets;
		[HideInInspector]
		public GiftType targetSortType;
		[HideInInspector]
		public CommonSortModel.Preset targetSortPreset;
		private bool isForceSetActive;
		private bool isFilterActive;
		private bool isStartTaskEnded;
	
		// Constructors
		public CommonSortFilterUI();
	
		// Methods
		private void Start();
		public void SetActive(bool isActive);
	}
}
