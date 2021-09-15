/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcTriadMasks : EnemyAbilityProcBase
	{
		// Fields
		private EnemyAbilityProcTriadMasks _mask0;
		private EnemyAbilityProcTriadMasks _mask1;
		private EnemyAbilityProcTriadMasks _mask2;
		private const string HEARTLESS_MASK_MESH_NAME = "mFace_01";
		private const string DISTRESS_MASK_MESH_NAME = "mFace_02";
		private const string WRATH_MASK_MESH_NAME = "mFace_03";
		private float _timer;
	
		// Nested types
		private enum MaskType
		{
			Heartless = 0,
			Distress = 1,
			Wrath = 2
		}
	
		// Constructors
		public EnemyAbilityProcTriadMasks(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void OnEntry();
		public override void OnActionParts(bool onoff);
		public override void OnUpdate();
		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
		private void SwitchMaskMesh(bool onoff);
	}
}
