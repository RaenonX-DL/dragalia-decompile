﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitExAbilityPage : MonoBehaviour
	{
		// Fields
		public List<UnitDetailAbilityInfoCell> exAbilityCell;
		[HideInInspector]
		public UnitDetailCanvas parentCanvas;
	
		// Constructors
		public UnitExAbilityPage();
	
		// Methods
		public void SetupExAbilityPage(UnitDetailModel.UnitDetailType type);
		private void SetExAbilityInfo();
	}
}
