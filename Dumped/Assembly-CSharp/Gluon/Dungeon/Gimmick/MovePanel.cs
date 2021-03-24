/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class MovePanel : GimmickBase
	{
		// Fields
		public GimmickMovePanelObj type;
		public Vector3 moveVec;
		private GimmickMovePanelObjElement variation;
	
		// Constructors
		public MovePanel();
	
		// Methods
		protected override void Awake();
		private void OnTriggerStay(Collider other);
		private void OnTriggerExit(Collider other);
	}
}
