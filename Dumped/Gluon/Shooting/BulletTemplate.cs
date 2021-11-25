using UnityEngine;

namespace Gluon.Shooting
{
	public class BulletTemplate : MonoBehaviour
	{
		[SerializeField]
		[Header("Template")]
		public SpriteRenderer image;

		public Transform tf;

		[SerializeField]
		[Header("FadeInAndOut")]
		public Sprite fadeOutSprite;

		[SerializeField]
		[Header("Sprites")]
		public Sprite[] spriteAnims;

		[SerializeField]
		[Header("Parameter")]
		public float rMain;

		public float rSub;

		public int renderDepth;

		public BulletManager.TemplateType type;

		public BaseObject.CollisionType collisionType;
	}
}
