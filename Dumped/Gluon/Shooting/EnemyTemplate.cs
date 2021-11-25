using System;
using UnityEngine;

namespace Gluon.Shooting
{
	public class EnemyTemplate : MonoBehaviour
	{
		[Serializable]
		public class LevelData
		{
			public Texture mainTex;

			public float hp;

			public int score;

			public int minPlayerLevel;

			public int maxPlayerLevel;

			public int takeStartS;

			public int takeStartM;

			public float bodyScale;

			[SerializeField]
			[Header("Flags")]
			public bool disableSmallBullet;

			public bool itemizeOnDeath;

			public bool fadeoutBulletInFadeOut;

			public bool spinSelf;

			public void ClearOtherData()
			{
			}
		}

		[SerializeField]
		[Header("Template")]
		public SpriteRenderer fadeOutImage;

		public Transform tf;

		public GameObject body;

		public Animator animator;

		public bool stableAngle;

		[SerializeField]
		[Header("Effect")]
		public SPFXAttacher kiraEffect;

		public SPFXAttacher bossCrushEffect;

		public SPFXAttacher bossDamageEffect;

		[SerializeField]
		[Header("FadeInAndOut")]
		public Sprite[] fadeOutSpriteList;

		public EnemyManager.TemplateType type;

		[SerializeField]
		[Header("Parameter")]
		public float w;

		public float h;

		public LevelData[] levelData;

		[SerializeField]
		[Header("Entity")]
		public Enemy enemy;

		public Transform eJaw;

		public Transform eWingCL;

		public Transform eWingCR;

		public Transform eTailF;

		public Transform eChest;

		[SerializeField]
		[Header("MovingAnimator")]
		public Animator movingAnimator;

		[NonSerialized]
		public Renderer[] renderers;
	}
}
