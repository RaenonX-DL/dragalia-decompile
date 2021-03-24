/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DontSlipField : GimmickBase
	{
		// Fields
		public Action<DontSlipField, Collider> onExitAction;
		public Action<DontSlipField, Collider> onStayAction;
	
		// Constructors
		public DontSlipField();
	
		// Methods
		private void OnTriggerExit(Collider other);
		private void OnTriggerStay(Collider other);
	}
}
