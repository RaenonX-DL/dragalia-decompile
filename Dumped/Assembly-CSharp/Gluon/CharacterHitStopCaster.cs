/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Dungeon;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterHitStopCaster
	{
		// Fields
		private bool isAccept;
		private bool isDefault;
		private float stopPosition;
		private float stopLength;
		private float stopMotionPlayScale;
		private bool isRepeat;
		private int hitCount;
		private int acceptIndex;
		private CharacterBase _owner;
	
		// Constructors
		public CharacterHitStopCaster(CharacterBase owner);
	
		// Methods
		public void Clear();
		public void Accept(HitStopData data);
		public void AcceptDefault();
		private void AcceptSub();
		public int getAcceptIndex();
		public void ProcOnHit(CharacterBase owner, CharacterBase target, DungeonObjectBase dunObj, CollisionHitAttribute hitAttr);
		public void OnLateUpdate();
	}
}
