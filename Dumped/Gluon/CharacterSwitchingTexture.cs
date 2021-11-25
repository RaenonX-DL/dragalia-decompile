using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class CharacterSwitchingTexture : MonoBehaviour
	{
		[Serializable]
		public class SwitchData
		{
			[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£")]
			public Texture2D texture;

			[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0083\u009eã\u0083\u0083ã\u0083\u0094ã\u0083³ã\u0082°ã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
			public Vector2 scale;

			[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0083\u009eã\u0083\u0083ã\u0083\u0094ã\u0083³ã\u0082°ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
			public Vector2 offset;
		}

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bå\u00af¾è±¡ã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ã\u0081®ç\u00a8®é¡\u009e")]
		private string[] _switchPartsNames;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bå\u00af¾è±¡ã\u0081®ã\u0083¡ã\u0082¤ã\u0083³ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
		private string _propertyMainTexName;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bå\u00af¾è±¡ã\u0081®ã\u0082µã\u0083\u0096ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
		private string _propertySubTexName;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u008bã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private SwitchData[] _switchData;

		private int _propertyMainTexID;

		private int _propertyMainTexSTID;

		private int _propertySubTexID;

		private float _fadeRatio;

		private int _fadeStartIndex;

		private int _fadeEndIndex;

		private CharacterBase _owner;

		private float _duration;

		private float _time;

		private IEnumerator coSwitingTexture;

		public SwitchData[] switchData => null;

		private void Start()
		{
		}

		public void Play(int start_idx, int end_idx, float duration)
		{
		}

		private IEnumerator CoSwitingTexture()
		{
			return null;
		}

		public void Stop()
		{
		}

		private void Finish()
		{
		}
	}
}
