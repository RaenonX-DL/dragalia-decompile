/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class PlayerBulletManager : STGSingletonMonoBehaviour<Gluon.Shooting.PlayerBulletManager>
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject poolTemplate;
		public Transform bulletParent;
		[NonSerialized]
		public Camera bulletCamera;
		[Header]
		[SerializeField]
		public PlayerBulletTemplate template;
		public PlayerBulletTemplate subTemplate;
		public const int bulletPoolSize = 384;
		private int zOrder;
		private Pool bu;
	
		// Constructors
		public PlayerBulletManager();
	
		// Methods
		public PlayerBulletTemplate OverrideByTemplate(PlayerBullet bullet, PlayerBulletTemplate templ);
		public void Init();
		public void BuildShoot(int usingTime, int level);
		private int GetShootLevelSETypeOffset(int level);
		public int Build(PlayerBulletTemplate.PlayerBulletData data, PlayerBulletTemplate template);
		public void Action();
		public void Render();
		public void Clear();
		public bool CheckShoot(Enemy en, float aimx, float aimy, float aimw, float aimh);
	}
}
