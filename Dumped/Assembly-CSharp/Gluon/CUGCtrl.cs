/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.CharacterUniqueGimmick;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CUGCtrl
	{
		// Fields
		private List<CUGCtrlBase> _listCtrl;
	
		// Nested types
		public enum Type
		{
			None = 0,
			Electrified = 1,
			Grudge = 2,
			Virus = 3,
			Thrown = 4,
			Doll = 5,
			HealBlock = 6,
			HolyLight = 7,
			YinYang = 8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0<T>
			where T : CUGCtrlBase
		{
			// Fields
			public T ctrl_;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal bool _Set_b__0(CUGCtrlBase s);
		}
	
		// Constructors
		public CUGCtrl();
	
		// Methods
		public void Set<T>(T ctrl_)
			where T : CUGCtrlBase;
		public T Get<T>()
			where T : CUGCtrlBase;
		public bool IsActive(Type type_);
		public void Clear();
		public void Reset(Type type_ = Type.None);
		public void Abort(Type type_ = Type.None);
		public void Update(Type type_ = Type.None);
		public void FixedUpdate(Type type_ = Type.None);
		public void OnDead(Type type_ = Type.None);
		public void OnShapeShift(Type type_ = Type.None);
		public void OnCollided(CollisionHitAttribute hitAttr, Type type_ = Type.None);
		public bool IsRestoreEffect(Type type_ = Type.None);
		public void PlayEffect(Type type_ = Type.None);
		public void StopEffect(Type type_ = Type.None);
		public bool InhibitTransform();
		public bool InhibitUniqueTransform();
	}
}
