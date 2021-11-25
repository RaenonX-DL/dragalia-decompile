using UnityEngine;

namespace Gluon
{
	public class BaseCanvasParticleSettings : MonoBehaviour
	{
		[SerializeField]
		[Header("æ\u009c\u0080å¤§ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«æ\u0095°")]
		public int particleNum;

		[SerializeField]
		[Header("X ã\u0081®ç\u00af\u0084å\u009b²ã\u0081\u00a8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float rangeX;

		public float offsetX;

		[SerializeField]
		[Header("Y ã\u0081®ç\u00af\u0084å\u009b²ã\u0081\u00a8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float rangeY;

		public float offsetY;

		[SerializeField]
		[Header("X ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081®ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ç\u00af\u0084å\u009b²")]
		public float moveSpeedRangeX;

		[SerializeField]
		[Header("X ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹")]
		public float moveSpeedBaseX;

		[SerializeField]
		[Header("Y ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081®ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ç\u00af\u0084å\u009b²")]
		public float moveSpeedRangeY;

		[SerializeField]
		[Header("Y ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹")]
		public float moveSpeedBaseY;

		[SerializeField]
		[Header("å\u00af¿å\u0091½ã\u0081®ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ç\u00af\u0084å\u009b²")]
		public int lifeRange;

		[SerializeField]
		[Header("å\u00af¿å\u0091½ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹")]
		public int lifeBase;

		[SerializeField]
		[Header("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089é\u0080\u009fåº¦")]
		public float fadeSpeed;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®ç\u0094\u009fæ\u0088\u0090é\u00a0»åº¦")]
		public int emissionIntervalMyPage;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®å\u0088\u009dæ\u009c\u009fç\u0094\u009fæ\u0088\u0090æ\u0095°")]
		public int initialNumberMyPage;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®è\u0089²")]
		public Color particleColorMyPage;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡")]
		public float alphaMyPage;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®å\u008d\u008aå¾\u0084ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ç\u00af\u0084å\u009b²")]
		public float radiusRangeMyPage;

		[SerializeField]
		[Header("2D ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081®å\u008d\u008aå¾\u0084ã\u0083\u0099ã\u0083¼ã\u0082¹")]
		public float radiusBaseMyPage;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®ç\u0094\u009fæ\u0088\u0090é\u00a0»åº¦")]
		public int emissionIntervalCommon;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®å\u0088\u009dæ\u009c\u009fç\u0094\u009fæ\u0088\u0090æ\u0095°")]
		public int initialNumberCommon;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®è\u0089²")]
		public Color particleColorCommon;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡")]
		public float alphaCommon;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®å\u008d\u008aå¾\u0084ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ç\u00af\u0084å\u009b²")]
		public float radiusRangeCommon;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aç\u0094»é\u009d¢ã\u0081®å\u008d\u008aå¾\u0084ã\u0083\u0099ã\u0083¼ã\u0082¹")]
		public float radiusBaseCommon;
	}
}
