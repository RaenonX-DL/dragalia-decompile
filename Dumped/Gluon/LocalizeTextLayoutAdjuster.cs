using UnityEngine;

namespace Gluon
{
	public class LocalizeTextLayoutAdjuster : MonoBehaviour
	{
		[Header("ä½\u008dç½®èª¿æ\u0095\u00b4è¿½å\u008a\u00a0å\u0088\u0086")]
		public float en_us_add_X;

		public float en_us_add_Y;

		public float zh_cn_add_X;

		public float zh_cn_add_Y;

		public float zh_tw_add_X;

		public float zh_tw_add_Y;

		[Header("ã\u0083\u009eã\u0083\u008bã\u0083¥ã\u0082¢ã\u0083«è¡\u008cé\u0096\u0093èª¿æ\u0095\u00b4ã\u0081\u0099ã\u0082\u008b")]
		public bool manualSpacing;

		[Header("ã\u0083\u009eã\u0083\u008bã\u0083¥ã\u0082¢ã\u0083«è¡\u008cé\u0096\u0093")]
		public float ja_jp_manual_lineSpacing;

		public float en_us_manual_lineSpacing;

		public float zh_cn_manual_lineSpacing;

		public float zh_tw_manual_lineSpacing;

		public const float ja_jp_lineSpacing = 0.6f;

		public const float en_us_lineSpacing = 1.05f;

		public const float zh_cn_lineSpacing = 1.05f;

		public const float zh_tw_lineSpacing = 1.25f;

		private const float en_us_default_X = 0f;

		private const float en_us_default_Y = -2f;

		private const float zh_cn_default_X = 0f;

		private const float zh_cn_default_Y = 0f;

		private const float zh_tw_default_X = 0f;

		private const float zh_tw_default_Y = 0f;

		private void Awake()
		{
		}
	}
}
