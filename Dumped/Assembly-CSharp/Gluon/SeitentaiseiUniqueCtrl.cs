/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SeitentaiseiUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private int _checkEnemyId;
		private string _hitAttributeLabel;
		private float _healIntervalSec;
		private float _healElapseSec;
		private string _auraEffectName;
		private EffectObject _effectObject;
		private HitException _hitException;
		private int _oldLiveCnt;
		private int _healHitAttributeElementIndex;
	
		// Constructors
		public SeitentaiseiUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void InitHeal(int checkEnemyId, string auraEffectName, string hitAttrLabel, float healInterSec);
		public void CheckHeal(int liveCnt);
		public override void FastUpdate();
		public void OnDamaged(CollisionHitAttribute hitAttr);
	}
}
