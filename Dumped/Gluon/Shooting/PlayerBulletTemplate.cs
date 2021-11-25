using System;
using UnityEngine;

namespace Gluon.Shooting
{
	public class PlayerBulletTemplate : MonoBehaviour
	{
		[Serializable]
		public class PlayerBulletData
		{
			public int angle;

			public float speed;

			public float power;

			public int timeMod;

			public int timeModVal;

			public float xOffset;

			public float yOffset;

			public int delayIndex;

			public void CopyFrom(PlayerBulletData otherData)
			{
			}
		}

		[Serializable]
		public class LevelData
		{
			public PlayerBulletData[] data;

			public int seOffset;
		}

		[SerializeField]
		[Header("Template")]
		public SpriteRenderer image;

		public Transform tf;

		[SerializeField]
		[Header("FadeInAndOut")]
		public Sprite[] fadeOutSprites;

		public Sprite[] animationSprites;

		[SerializeField]
		[Header("Parameter")]
		public float r;

		public float ezR;

		[SerializeField]
		public LevelData[] levelData;

		public void Init()
		{
		}

		private void FillBuildData()
		{
		}

		private void AddCenter(int bunch)
		{
		}

		private void AddSide(int bunch, int beginIndex)
		{
		}

		public void AdjustLevelData(PlayerBulletData baseData, int[] centerCounts, int[] sideACounts, int[] sideBCounts, int[] timeModRanges, int[] timeModARanges, int[] timeModBRanges, int[] angleSet)
		{
		}
	}
}
