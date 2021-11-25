using UnityEngine;

namespace Gluon
{
	public class EnemyRareTimerCtrl : MonoBehaviour
	{
		private enum SpriteIndex
		{
			SpriteIcon1,
			SpriteIcon2,
			SpriteIcon3,
			Max
		}

		[SerializeField]
		private SpriteRenderer[] timerIcons;

		[SerializeField]
		private SpriteRenderer timerIconEffect;

		[SerializeField]
		private float[] iconChangeTimes;

		[SerializeField]
		private float timeSpeedMin;

		[SerializeField]
		private float timeSpeedMax;

		[SerializeField]
		private float colorModulusPower;

		[SerializeField]
		private float iconScaleAdd;

		[SerializeField]
		private float effectScaleMin;

		[SerializeField]
		private float effectScaleMax;

		private MaterialPropertyBlock[] propertyBlocks;

		private EnemyCharacter enemy;

		private float timeSeed;

		private int currentIconIndex;

		public void Initialize(CharacterBase c)
		{
		}

		private void Update()
		{
		}

		public void Visible(bool b)
		{
		}

		private void VisibleControl()
		{
		}
	}
}
