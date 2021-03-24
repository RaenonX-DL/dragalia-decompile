/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsBulletHitAttribute
	{
		// Fields
		[CompilerGenerated]
		private CollisionHitAttribute _hitAttr_k__BackingField;
	
		// Properties
		public CollisionHitAttribute hitAttr { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ActionPartsBulletHitAttribute();
	
		// Methods
		public void Initialize(InGameDef.CharacterType charaType, int actionid, string label);
		private void InitializeForPlayer(int actionid, string label);
		private void InitializeForEnemy(int actionid, string label);
	}
}
