using UnityEngine;

namespace Gluon
{
	public class UVMoviePlayer : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("å\u00af¾è±¡ã\u0081\u00a8ã\u0081ªã\u0082\u008bã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©ã\u0083¼\nä½\u0095ã\u0082\u0082è\u00a8­å®\u009aã\u0081\u0097ã\u0081¦ã\u0081\u0084ã\u0081ªã\u0081\u0084å\u00a0\u00b4å\u0090\u0088ã\u0081\u00afè\u0087ªå\u008b\u0095ã\u0081§å\u008f\u0096å¾\u0097")]
		private Renderer _renderer;

		[SerializeField]
		[Tooltip("ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bUVMovieã\u0081®ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083­ã\u0083¼ã\u0083©ã\u0083¼")]
		private UVMovieController _uvMovieController;

		[SerializeField]
		[Tooltip("å\u0086\u008dç\u0094\u009fã\u0081\u0099ã\u0082\u008bæ\u0099\u0082é\u0096\u0093ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private float _playOffsetTime;

		[SerializeField]
		[Tooltip("é\u0096\u008bå§\u008bæ\u0099\u0082ã\u0081«æ\u0099\u0082é\u0096\u0093ã\u0082\u0092å\u008f\u0096å¾\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		private bool _isStartPlay;

		[SerializeField]
		[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
		private string _texturePropertyName;

		private int _texturePropertyID;

		private int _textureSTPropertyID;

		private MaterialPropertyBlock _materialPropertyBlock;

		private float _startTime;

		private float GetNowTime()
		{
			return default(float);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
