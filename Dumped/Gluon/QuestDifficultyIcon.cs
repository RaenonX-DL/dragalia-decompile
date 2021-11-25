using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestDifficultyIcon : MonoBehaviour
	{
		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Sprite[] difficultySprites;

		[SerializeField]
		private Material[] difficultyMaterials;

		[SerializeField]
		private float[] difficultySpriteScales;

		private Vector3 tempScale;

		public void SetupDifficultyIcon(QuestSelectScene.Difficulty difficulty)
		{
		}
	}
}
