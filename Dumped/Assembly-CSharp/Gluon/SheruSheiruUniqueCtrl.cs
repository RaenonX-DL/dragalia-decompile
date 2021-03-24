/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SheruSheiruUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		public EnemyCharacter owner;
		private bool isChildCollisionOff;
		[CompilerGenerated]
		private List<EnemyCharacter> _HitList_k__BackingField;
	
		// Properties
		public List<EnemyCharacter> HitList { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SheruSheiruUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void HitEnemy(EnemyCharacter subEnemy, int actionID);
		public bool AlreadyHit(EnemyCharacter subEnemy);
		public void ResetHitList();
		public override void FastUpdate();
	}
}
