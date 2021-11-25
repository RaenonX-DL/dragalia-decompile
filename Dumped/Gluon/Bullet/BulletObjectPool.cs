using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BulletObjectPool : SingletonMonoBehaviour<BulletObjectPool>
	{
		private const string prefabPath_BulletObject = "Prefabs/InGame/Bullet/BulletObject";

		private const string prefabPath_BulletObjectWithMarker = "Prefabs/InGame/Bullet/BulletObjectWithMarker";

		private const string prefabPath_DropBulletObject = "Prefabs/InGame/Bullet/DropBulletObject";

		private const string prefabPath_BombBulletObject = "Prefabs/InGame/Bullet/BombBulletObject";

		private const string prefabPath_ParabolaBulletObject = "Prefabs/InGame/Bullet/ParabolaBulletObject";

		private const string prefabPath_BlastBulletObject = "Prefabs/InGame/Bullet/BlastBulletObject";

		private const string prefabPath_PivotBulletObject = "Prefabs/InGame/Bullet/PivotBulletObject";

		private const string prefabPath_StockBulletObject = "Prefabs/InGame/Bullet/StockBulletObject";

		private const string prefabPath_SettingHitObject = "Prefabs/InGame/Bullet/SettingHitObject";

		private const string prefabPath_CondensBulletObject = "Prefabs/InGame/Bullet/CondensBulletObject";

		private const string prefabPath_ThunderballObject = "Prefabs/InGame/Bullet/ThunderballObject";

		private const string prefabPath_BindBulletObject = "Prefabs/InGame/Bullet/BindBulletObject";

		private const string prefabPath_FormationBulletObject = "Prefabs/InGame/Bullet/FormationBulletObject";

		private const string prefabPath_ButterflyBulletObject = "Prefabs/InGame/Bullet/ButterflyBulletObject";

		private const string prefabPath_SeiunhaBulletObject = "Prefabs/InGame/Bullet/SeiunhaBulletObject";

		private const string prefabPath_ShikigamiBulletObject = "Prefabs/InGame/Bullet/ShikigamiBulletObject";

		private const string prefabPath_RoseTokenBulletObject = "Prefabs/InGame/Bullet/RoseTokenBulletObject";

		private Dictionary<Type, GameObject> prefabs;

		public void LoadPrefabs()
		{
		}

		public GameObject GetBulletInstance<Type>(bool setPoolParent = false)
		{
			return null;
		}

		public GameObject GetBulletInstance(GameObject obj)
		{
			return null;
		}

		public void ReleaseBullet(GameObject obj)
		{
		}

		public void AddPool<Type>(int ct)
		{
		}

		public void AddPool(GameObject obj, int ct)
		{
		}
	}
}
