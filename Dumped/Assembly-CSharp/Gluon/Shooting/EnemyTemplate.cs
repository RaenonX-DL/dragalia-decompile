/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class EnemyTemplate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public SpriteRenderer fadeOutImage;
		public Transform tf;
		public GameObject body;
		public Animator animator;
		public bool stableAngle;
		[Header]
		[SerializeField]
		public SPFXAttacher kiraEffect;
		public SPFXAttacher bossCrushEffect;
		public SPFXAttacher bossDamageEffect;
		[Header]
		[SerializeField]
		public Sprite[] fadeOutSpriteList;
		public EnemyManager.TemplateType type;
		[Header]
		[SerializeField]
		public float w;
		public float h;
		public LevelData[] levelData;
		[Header]
		[SerializeField]
		public Enemy enemy;
		public Transform eJaw;
		public Transform eWingCL;
		public Transform eWingCR;
		public Transform eTailF;
		public Transform eChest;
		[Header]
		[SerializeField]
		public Animator movingAnimator;
		[NonSerialized]
		public Renderer[] renderers;
	
		// Nested types
		[Serializable]
		public class LevelData
		{
			// Fields
			public Texture mainTex;
			public float hp;
			public int score;
			public int minPlayerLevel;
			public int maxPlayerLevel;
			public int takeStartS;
			public int takeStartM;
			public float bodyScale;
			[Header]
			[SerializeField]
			public bool disableSmallBullet;
			public bool itemizeOnDeath;
			public bool fadeoutBulletInFadeOut;
			public bool spinSelf;
	
			// Constructors
			public LevelData();
	
			// Methods
			public void ClearOtherData();
		}
	
		// Constructors
		public EnemyTemplate();
	}
}
