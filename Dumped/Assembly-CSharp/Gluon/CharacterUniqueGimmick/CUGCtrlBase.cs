/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CUGCtrlBase
	{
		// Fields
		[CompilerGenerated]
		private CUGCtrl.Type _type_k__BackingField;
		protected CharacterBase _owner;
		protected CharacterSelector _ownerSelector;
	
		// Properties
		public CUGCtrl.Type type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public virtual bool active { get; }
	
		// Constructors
		public CUGCtrlBase(CUGCtrl.Type type_);
	
		// Methods
		public virtual void ResetState();
		public virtual void Abort();
		public virtual void Update();
		public virtual void FixedUpdate();
		public virtual void OnDead();
		public virtual void OnShapeShift();
		public virtual void OnCollided(CollisionHitAttribute hitAttr);
		public virtual bool IsRestoreEffect();
		public virtual void PlayEffect();
		public virtual void StopEffect();
	}
}
