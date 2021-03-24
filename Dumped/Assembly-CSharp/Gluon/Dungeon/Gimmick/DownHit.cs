/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DownHit : GimmickBase
	{
		// Fields
		private GimmickDownElement variation;
		private CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private Down downObj;
		private DownBody downBody;
	
		// Constructors
		public DownHit();
	
		// Methods
		public void Initialize(GimmickDownElement elem, Down downObj, DownBody downBody);
		private void OnTriggerEnter(Collider other);
	}
}
