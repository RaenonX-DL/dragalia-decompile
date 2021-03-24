/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterAnimationEvent : FastUpdateMonoBehaviour
	{
		// Fields
		private CharacterBase owner;
		private int baseId;
		private int variationId;
		private GameObject bossApeearOwner;
		private List<EffectObject> bossAppearEffects;
	
		// Nested types
		private enum CategoryIndex
		{
			None = 0,
			Player = 1,
			Enemy = 2,
			Both = 3
		}
	
		// Constructors
		public CharacterAnimationEvent();
	
		// Methods
		public void SetOwner(CharacterBase owner);
		public void SetBossApeearOwner(GameObject owner);
		public void SetupCharacter(CharacterBase owner, int charaId);
		public void SetupDragon(CharacterBase owner, int dragonId);
		public void SetupEnemy(EnemyCharacter owner);
		private string GetVoiceNameFormat(ModelLoadHelper.EnemyCategory category);
		private string GetDragonPrefix();
		public void PlayWalkFootsteps(int value);
		public void PlayDashFootsteps(int value);
		public void PlaySE(string s);
		public void PlaySE3D(string s);
		public void PlaySEMatchCharaId(int charaId);
		public void PlayEffect(string effectName);
		public void PlayEffectForBossAppear(string effectName);
		public void PlayAttachEffectForBossAppear(string param);
		public void StopBossAppearEffect();
		public void SetFaceType(int type);
		public void OnEvent();
		public void AttachWeaponForBossAppear(int hand);
		public void ChangeWeaponMeshVisibility(string meshName);
		public void ChangeBossWeaponMeshVisibility(string meshName);
		public void SetWeaponForWinningProduction(int weaponId);
		public void ChangePartsAMesh(int partsNo);
		public void ChangeBossPartsMesh(string partsName);
		public void ExecAnimEvent(AnimationEvent animEvent);
		private bool IsMatchCondition(int value);
		public void CatchBallForWalker();
		public void ReleaseBallForWalker();
		public void SetFacialEye(int index);
		public void SetFacialMouth(int index);
	}
}
