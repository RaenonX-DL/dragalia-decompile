using System;
using UnityEngine;

namespace Gluon.Shooting
{
	public class PlayerBulletManager : STGSingletonMonoBehaviour<PlayerBulletManager>
	{
		[SerializeField]
		[Header("Pool")]
		public GameObject poolTemplate;

		public Transform bulletParent;

		[NonSerialized]
		public Camera bulletCamera;

		[SerializeField]
		[Header("Template")]
		public PlayerBulletTemplate template;

		public PlayerBulletTemplate subTemplate;

		public const int bulletPoolSize = 384;

		private int zOrder;

		private Pool bu;

		public PlayerBulletTemplate OverrideByTemplate(PlayerBullet bullet, PlayerBulletTemplate templ)
		{
			return null;
		}

		public void Init()
		{
		}

		public void BuildShoot(int usingTime, int level)
		{
		}

		private int GetShootLevelSETypeOffset(int level)
		{
			return default(int);
		}

		public int Build(PlayerBulletTemplate.PlayerBulletData data, PlayerBulletTemplate template)
		{
			return default(int);
		}

		public void Action()
		{
		}

		public void Render()
		{
		}

		public void Clear()
		{
		}

		public bool CheckShoot(Enemy en, float aimx, float aimy, float aimw, float aimh)
		{
			return default(bool);
		}
	}
}
