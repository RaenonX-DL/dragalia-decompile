/*
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
	public class ShishimaiBoxUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private bool isValid;
		private List<EnemyCharacter> _boxes;
		private int _opendNum;
		private Vector3 BOX_CENTER;
	
		// Properties
		public int opendNum { get; }
	
		// Constructors
		public ShishimaiBoxUniqueCtrl();
	
		// Methods
		public override void Initialize();
		private void LateUpdate();
		public void OpenBox();
		public void ReCloseBox(string motionState);
	}
}
