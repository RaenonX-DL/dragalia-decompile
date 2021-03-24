/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BulletManager
	{
		// Fields
		[CompilerGenerated]
		private static readonly Dictionary<int, BulletBase> _AllBullets_k__BackingField;
		private Dictionary<int, BulletBase> bullets;
		private List<FireSpecialBullet> _formationBulletFireQueue;
		private List<BulletEvent> _bulletEventQueue;
		private List<int> butterflyBullets;
		private List<int> shikigamiBullets;
	
		// Properties
		public static Dictionary<int, BulletBase> AllBullets { [CompilerGenerated] get; }
		public int butterflyNum { get; }
		public int shikigamiNum { get; }
	
		// Constructors
		public BulletManager();
		static BulletManager();
	
		// Methods
		public void AddBullet(int bulletId, BulletBase bullet);
		public void DeleteBullet(int bulletId, CharacterBase owner);
		public void OnBulletHit(int bulletId, GameObject target);
		public void AllDelete();
		public void DeleteByTag(string targetTag);
		public bool CheckAliveBullet(int skillId, int actionId, int actionProductId);
		public void StopEffect();
		public void PauseEffect(bool isPause);
		public void RestoreEffect();
		public bool FireFormationBullet(FormationBulletData.FireTrigger trigger);
		public void ReleaseFormationBullet(bool onlyFormationState = true);
		public void HideFormationBullet(bool onlyFormationState = true);
		public void RestartFormationBullet(bool onlyFormationState = true);
		public bool HasFormationBullet(bool onlyFormationState = true);
		public void CheckFormationBulletFireQueue(FormationBulletObject bullet);
		public void CheckBulletEventQueue(BulletObject bullet);
		public BulletBase FindBullet(int bulletId);
		public BulletBase FindBulletContainsTag(string tag);
		public void OnReceiveFireBulletEvent(FireSpecialBullet recv);
		public void OnReceiveBulletEvent(BulletEvent recvEvent);
		public void AddDeleteCounterForButterflyBullet(int count = 1);
		public void CheckLimitForButterflyBullet();
		public void AllDeleteForButterflyBullet(bool isForce);
		public List<Vector3> GetButterflyBulletPositions();
		public int GetShikigamiBulletMinCpCostOnAttack();
		public static BulletBase FindBulletFromAllBullet(int uniqueBulletId);
	}
}
