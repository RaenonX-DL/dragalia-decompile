using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BulletManager
	{
		private Dictionary<int, BulletBase> bullets;

		private List<FireSpecialBullet> _formationBulletFireQueue;

		private List<BulletEvent> _bulletEventQueue;

		private List<int> butterflyBullets;

		private List<int> shikigamiBullets;

		public static Dictionary<int, BulletBase> AllBullets
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int butterflyNum => default(int);

		public int shikigamiNum => default(int);

		public void AddBullet(int bulletId, BulletBase bullet)
		{
		}

		public void DeleteBullet(int bulletId, CharacterBase owner)
		{
		}

		public void OnBulletHit(int bulletId, GameObject target)
		{
		}

		public void AllDelete()
		{
		}

		public void OnAreaChange()
		{
		}

		private void DeleteIf(Func<BulletBase, bool> callback)
		{
		}

		public void DeleteByTag(string targetTag)
		{
		}

		public bool CheckAliveBullet(int skillId, int actionId, int actionProductId)
		{
			return default(bool);
		}

		public void StopEffect()
		{
		}

		public void PauseEffect(bool isPause)
		{
		}

		public void RestoreEffect()
		{
		}

		public bool FireFormationBullet(FormationBulletData.FireTrigger trigger)
		{
			return default(bool);
		}

		public void ReleaseFormationBullet(bool onlyFormationState = true)
		{
		}

		public void HideFormationBullet(bool onlyFormationState = true)
		{
		}

		public void RestartFormationBullet(bool onlyFormationState = true)
		{
		}

		public bool HasFormationBullet(bool onlyFormationState = true)
		{
			return default(bool);
		}

		public void CheckFormationBulletFireQueue(FormationBulletObject bullet)
		{
		}

		public void CheckBulletEventQueue(BulletObject bullet)
		{
		}

		public BulletBase FindBullet(int bulletId)
		{
			return null;
		}

		public BulletBase FindBulletContainsTag(string tag)
		{
			return null;
		}

		public List<BulletBase> FindBulletsContainsTag(string tag)
		{
			return null;
		}

		public void OnReceiveFireBulletEvent(FireSpecialBullet recv)
		{
		}

		public void OnReceiveBulletEvent(BulletEvent recvEvent)
		{
		}

		public void AddDeleteCounterForButterflyBullet(int count = 1)
		{
		}

		public void CheckLimitForButterflyBullet()
		{
		}

		public void AllDeleteForButterflyBullet(bool isForce)
		{
		}

		public List<Vector3> GetButterflyBulletPositions()
		{
			return null;
		}

		public int GetShikigamiBulletMinCpCostOnAttack()
		{
			return default(int);
		}

		public int GetRoseTokenNum()
		{
			return default(int);
		}

		public void ReleaseRoseToken()
		{
		}

		public int GetReactionBulletNum(int actionId = 0)
		{
			return default(int);
		}

		public BlastBulletObject GetReactionBullet(int index, int actionId = 0)
		{
			return null;
		}

		public BlastBulletObject GetOldestReactionBullet(int actionId = 0)
		{
			return null;
		}

		public void DeleteOldestReactionBullet(int actionId)
		{
		}

		public static BulletBase FindBulletFromAllBullet(int uniqueBulletId)
		{
			return null;
		}
	}
}
