using UnityEngine;

namespace Gluon
{
	public class LongTapParameter : MonoBehaviour
	{
		[Header("æ\u009c\u0089å\u008a¹ã\u0081«ã\u0081\u0099ã\u0082\u008b")]
		public bool isEnabled;

		[Header("å\u0085\u0088é\u00a0­ã\u0081®å\u0086\u0086ã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
		public float topCircleSize;

		[Header("è»\u008cè·¡ã\u0081®å¹\u0085")]
		public float trailHeight;

		[Header("è»\u008cè·¡ã\u0081®é\u0095·ã\u0081\u0095")]
		public int trailNum;

		[Header("è»\u008cè·¡ã\u0081®å\u0088\u0086å\u0089²æ\u0095°")]
		public int trailDivide;

		[Header("è»\u008cè·¡ã\u0081®è£\u009cæ­£å\u0080¤")]
		public float trailAdjustRate;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®æ\u009c\u0080å¤§ç·\u008fæ\u0095°")]
		public int maxParticleTotalNum;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®æ\u009c\u0080å°\u008fã\u0082µã\u0082¤ã\u0082º")]
		public float minParticleSize;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®æ\u009c\u0080å¤§ã\u0082µã\u0082¤ã\u0082º")]
		public float maxParticleSize;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ç\u0094\u009fæ\u0088\u0090å¾\u008cæ\u008b¡å¤§Scale")]
		public float particleScale1;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«æ¶\u0088æ»\u0085å\u0089\u008dç\u00b8®å°\u008fScale")]
		public float particleScale2;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ç\u0094\u009fæ\u0088\u0090å¾\u008cæ\u008b¡å¤§æ\u0099\u0082é\u0096\u0093")]
		public float particleScale1Time;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®ç\u0094\u009fæ\u0088\u0090ä½\u008dç½®ã\u0081®æ\u009c\u0080å°\u008få\u0080¤")]
		public Vector2 minParticlePos;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®ç\u0094\u009fæ\u0088\u0090ä½\u008dç½®ã\u0081®æ\u009c\u0080å¤§å\u0080¤")]
		public Vector2 maxParticlePos;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®ç\u0094\u009fæ\u0088\u0090æ\u0095°ã\u0081®æ\u009c\u0080å°\u008få\u0080¤")]
		public int minPariticleGen;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®ç\u0094\u009fæ\u0088\u0090æ\u0095°ã\u0081®æ\u009c\u0080å¤§å\u0080¤")]
		public int maxParticleGen;

		[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082\u00afã\u0083«ã\u0081®å\u00af¿å\u0091½")]
		public float particleLifeTime;
	}
}
