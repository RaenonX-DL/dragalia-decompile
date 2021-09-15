/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class AttackHit : EventBase<AttackHit>
	{
		// Fields
		[Key]
		public CharacterId from;
		[Key]
		public int damage;
		[Key]
		public int breakDamage;
		[Key]
		[Required]
		public CharacterId to;
		[Key]
		public Vector3 hitPos;
		[Key]
		public int bulletId;
		[Key]
		public float elementRate;
		[Key]
		public int applyAbnormalStatusResult;
		[Key]
		public bool isCritical;
		[Key]
		public float rotation;
		[Key]
		public int reaction;
		[Key]
		public KnockBack knockBack;
		[Key]
		public Absorption absorption;
		[Key]
		public BlastUp blastUp;
		[Key]
		public BlastDown blastDown;
		[Key]
		public BlastSp blastSp;
		[ActionId]
		[Key]
		public int actionId;
		[Key]
		[SkillIdOrZero]
		public int skillId;
		[Key]
		public int hitProduction;
		[Key]
		public CharacterId additionalAttackFrom;
		[Key]
		public byte flags;
		[Key]
		public int moveEventTimestamp;
		[Key]
		public float dragonTimerDamage;
		[Key]
		public float skillDamageUpBuffRate;
		[Key]
		public byte characterType;
		[Key]
		public short elementIndex;
		[Key]
		public int productId;
		[Key]
		public float burstDamageUpBuffRate;
		[Key]
		public long designatedHitEffectResourceId;
		[Key]
		public uint hitAttrLabelCrc32;
		[Key]
		public int buffCount;
		[Key]
		public byte flags2;
	
		// Constructors
		public AttackHit();
	
		// Methods
		public void Clear();
	}
}
