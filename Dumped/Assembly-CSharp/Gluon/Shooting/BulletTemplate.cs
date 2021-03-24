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
	public class BulletTemplate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public SpriteRenderer image;
		public Transform tf;
		[Header]
		[SerializeField]
		public Sprite fadeOutSprite;
		[Header]
		[SerializeField]
		public Sprite[] spriteAnims;
		[Header]
		[SerializeField]
		public float rMain;
		public float rSub;
		public int renderDepth;
		public BulletManager.TemplateType type;
		public BaseObject.CollisionType collisionType;
	
		// Constructors
		public BulletTemplate();
	}
}
