using UnityEngine;

namespace Gluon
{
	public class UVMovieController : MonoBehaviour
	{
		private Texture2D _mainTexture;

		private Vector2 _mainTextureOffset;

		private Vector2 _mainTextureScale;

		[SerializeField]
		private UVMovieData _UVMovieData;

		private bool _isInitlize;

		private Vector2 _frameOffset;

		private Vector2 _frameScale;

		private Vector2 _texturePixelOffset;

		private Vector2 _texturePixelScale;

		private float _moviePlayFrameSec;

		private float _playTime;

		private float _endLoopSec;

		private float _totalLoopSec;

		private float _playStartSec;

		private int _fremePerImage;

		public Texture2D mainTexture
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Vector2 mainTextureOffset
		{
			get
			{
				return default(Vector2);
			}
			protected set
			{
			}
		}

		public Vector2 mainTextureScale
		{
			get
			{
				return default(Vector2);
			}
			protected set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Initialize()
		{
		}

		public bool IsPlaying(float time)
		{
			return default(bool);
		}

		private void CalcProperty(float settime, bool isReversePlay)
		{
		}

		public void UpdateAddTime(float addtime, bool isReversePlay)
		{
		}

		public void UpdateSetTime(float settime, bool isReversePlay)
		{
		}

		public void SetPlayStartSec(int startOffsetFrame)
		{
		}
	}
}
