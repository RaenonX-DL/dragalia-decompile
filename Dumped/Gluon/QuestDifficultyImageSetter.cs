using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestDifficultyImageSetter : MonoBehaviour
	{
		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Sprite[] difficultySprites;

		[SerializeField]
		private bool isUseOverrideSprite;

		[SerializeField]
		private Material[] difficultyMaterials;

		[SerializeField]
		private float[] difficultySpriteScales;

		private Vector3 tempScale;

		public void SetDifficultyImage(QuestSelectScene.Difficulty difficulty)
		{
		}
	}
}
