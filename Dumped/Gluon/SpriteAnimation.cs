using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SpriteAnimation : MonoBehaviour
	{
		public Image image;

		public Sprite[] clip;

		[SerializeField]
		[Header("é\u0096\u0093é\u009a\u0094")]
		public float interval;

		private int currentClipIndex;

		private int maxIndex;

		private float currentTime;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
