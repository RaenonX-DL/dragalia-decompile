/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbilityCollisionManager
	{
		// Fields
		private List<CollisionHitAttribute> newAttributes;
		private List<CollisionHitAttribute> attributes;
	
		// Constructors
		public AbilityCollisionManager();
	
		// Methods
		public bool Regist(CharacterBase owner, string label, int actionId = 0, int skillId = 0, int bulletId = 0, int productId = 0, CollisionHitAttribute originHitAttribute = null, bool isLink = false);
		public void Update();
	}
}
