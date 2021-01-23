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
	public class UnitSkillPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnitDetailSkillInfoCell[] skillCellList;
		[HideInInspector]
		public UnitDetailCanvas parentCanvas;
		private UnitDetailModel.UnitDetailType unitType;
	
		// Constructors
		public UnitSkillPage();
	
		// Methods
		public void SetupSkillPage(UnitDetailModel.UnitDetailType type);
		private void SetSkillInfo();
	}
}
