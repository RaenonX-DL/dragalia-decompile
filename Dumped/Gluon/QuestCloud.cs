using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestCloud : MonoBehaviour
	{
		public enum enumCloudDirection
		{
			left,
			right
		}

		[SerializeField]
		private RectTransform trans;

		[SerializeField]
		[Header("1Fã\u0081\u0082ã\u0081\u009fã\u0082\u008aã\u0081®ã\u0082¹ã\u0083\u0094ã\u0083¼ã\u0083\u0089")]
		private float speed;

		[SerializeField]
		[Header("æ\u0096¹å\u0090\u0091")]
		private enumCloudDirection direction;

		[SerializeField]
		[Header("é\u009b²ã\u0081\u00a8å½±ã\u0082\u0092å\u0090«ã\u0082\u0081ã\u0081\u009få\u008d\u008aå¾\u0084")]
		private float maxWidth;

		[SerializeField]
		[Header("é\u009b²ã\u0081\u00a8å½±ã\u0082\u0092å\u0090«ã\u0082\u0081ã\u0081\u009fç\u00b8¦å\u008d\u008aå¾\u0084")]
		private float _maxHeight;

		[SerializeField]
		private Image cloudImage;

		[SerializeField]
		private Image shadowImage;

		private bool _isFade;

		private Vector3 rightOutPosition;

		private Vector3 leftOutPosition;

		private bool isPlayFlag;

		private const float radius = 0.5f;

		public RectTransform Trans
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Speed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public enumCloudDirection Direction
		{
			get
			{
				return default(enumCloudDirection);
			}
			set
			{
			}
		}

		public float MaxWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float maxHeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Image CloudImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image ShadowImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isFade
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void PlayCloud(Vector2 mapSize)
		{
		}

		public void StopCloud()
		{
		}

		private void Update()
		{
		}

		public void FadeOut()
		{
		}

		public void Fadein()
		{
		}
	}
}
