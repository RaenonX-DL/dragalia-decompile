using UnityEngine;

namespace Gluon.Shooting
{
	public class ItemTemplate : MonoBehaviour
	{
		[SerializeField]
		[Header("Template")]
		public SpriteRenderer image;

		public Transform tf;

		[SerializeField]
		[Header("Parameter")]
		public Sprite[] animationSpriteList;

		public int addScore;

		public int addHardScore;

		public int addPower;

		public int drainR;

		[SerializeField]
		[Header("ToScore")]
		public Sprite[] toScoreSprites;

		public Sprite[] toHardScoreSprites;

		[SerializeField]
		[Header("EntryPhase")]
		public Item.Phase entryPhase;

		public ItemManager.TemplateType type;
	}
}
