using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CaptalGetPopupViewCotroller : MonoBehaviour
	{
		[SerializeField]
		private Image iconFruits;

		[SerializeField]
		private Image iconCoin;

		[SerializeField]
		private Text text;

		private const int SPACE = 120;

		private const int CHAR_SIZE = 45;

		private const int OFFSET_Y = -105;

		[SerializeField]
		[Header("Tween Param")]
		private float _moveDistanceY;

		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _waitDuration;

		public AnimationUIGroup groupAnimation;

		public float moveDistanceY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float waitDuration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float delay
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Start()
		{
		}

		public void SetIcon(string path, bool isFruits)
		{
		}

		public void UnDispIcon()
		{
		}

		public void SetText(string str)
		{
		}

		public void SetTextSize(int size)
		{
		}

		public float GetPopupAnimTotalDuration()
		{
			return default(float);
		}

		public void PlayPopupAnim()
		{
		}

		private void OnPopupAnimFinish()
		{
		}
	}
}
