using UnityEngine;

namespace Gluon
{
	public class TextureScroll : MaterialControlComponent
	{
		[SerializeField]
		private TextureScrollData[] _textureScrollData;

		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083³ã\u0082²ã\u0083¼ã\u0083\u00a0æ\u0099\u0082é\u0096\u0093å\u0081\u009cæ­¢æ¼\u0094å\u0087ºã\u0081®å½±é\u009f¿ã\u0082\u0092å\u008f\u0097ã\u0081\u0091ã\u0082\u008b")]
		private bool enableStopProduction;

		public TextureScrollData[] textureScrollData => null;

		protected override void Awake()
		{
		}

		protected void Reset()
		{
		}

		private void Update()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
