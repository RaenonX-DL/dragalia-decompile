/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemySearchLink
	{
		// Fields
		private List<EnemyCtrl> _operators;
		private List<CharacterBase> _inSightHostiles;
		public bool disableAwake;
	
		// Properties
		public List<CharacterBase> inSightHostiles { get; }
	
		// Constructors
		public EnemySearchLink();
	
		// Methods
		public void AddOperator(EnemyCtrl enemy);
		public void ResponseDiscoverTarget(CharacterBase target);
		public void DiscoverTarget(CharacterBase target, bool isEmotion);
		public void ResponseAwakeAll(CollisionHitAttribute hitAttr, int damage);
		public void AwakeAll(bool isEmotion);
		public CharacterBase GetNearTarget(Vector3 basePos);
	}
}
