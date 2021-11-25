using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharacterAnimationEvent : FastUpdateMonoBehaviour
	{
		private enum CategoryIndex
		{
			None,
			Player,
			Enemy,
			Both
		}

		private CharacterBase owner;

		private int baseId;

		private int variationId;

		private GameObject bossApeearOwner;

		private List<EffectObject> bossAppearEffects;

		public void SetOwner(CharacterBase owner)
		{
		}

		public void SetBossApeearOwner(GameObject owner)
		{
		}

		public void SetupCharacter(CharacterBase owner, int charaId)
		{
		}

		public void SetupDragon(CharacterBase owner, int dragonId)
		{
		}

		public void SetupEnemy(EnemyCharacter owner)
		{
		}

		private string GetVoiceNameFormat(ModelLoadHelper.EnemyCategory category)
		{
			return null;
		}

		private string GetDragonPrefix()
		{
			return null;
		}

		public void PlayWalkFootsteps(int value)
		{
		}

		public void PlayDashFootsteps(int value)
		{
		}

		public void PlaySE(string s)
		{
		}

		public void PlaySE3D(string s)
		{
		}

		public void PlaySEMatchCharaId(int charaId)
		{
		}

		public void PlayEffect(string effectName)
		{
		}

		public void PlayEffectForBossAppear(string effectName)
		{
		}

		public void PlayAttachEffectForBossAppear(string param)
		{
		}

		public void StopBossAppearEffect()
		{
		}

		public void SetFaceType(int type)
		{
		}

		public void OnEvent()
		{
		}

		public void AttachWeaponForBossAppear(int hand)
		{
		}

		public void ChangeWeaponMeshVisibility(string meshName)
		{
		}

		public void ChangeBossWeaponMeshVisibility(string meshName)
		{
		}

		public void SetWeaponForWinningProduction(int weaponId)
		{
		}

		public void ChangePartsAMesh(int partsNo)
		{
		}

		public void ChangeBossPartsMesh(string partsName)
		{
		}

		public void ExecAnimEvent(AnimationEvent animEvent)
		{
		}

		private bool IsMatchCondition(int value)
		{
			return default(bool);
		}

		public void CatchBallForWalker()
		{
		}

		public void ReleaseBallForWalker()
		{
		}

		public void SetFacialEye(int index)
		{
		}

		public void SetFacialMouth(int index)
		{
		}

		public void SetWeaponVisibility(int visible)
		{
		}

		public void ChangePartsAMeshForAO(int partsNo)
		{
		}

		public void SwitchingTextureForAO(string index)
		{
		}
	}
}
