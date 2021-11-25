using System;
using UnityEngine;

namespace Gluon
{
	public class StorySettings : MonoBehaviour
	{
		public enum SettingPattern
		{
			None = -1,
			DoubleByteCharacter,
			SingleByteCharacter,
			Max
		}

		[Serializable]
		public class Setting
		{
			[SerializeField]
			[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aå\u009fºæº\u0096é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4")]
			public float messageAdjustBaseHeight;

			[SerializeField]
			[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aè¡\u008cæ\u0095°")]
			public int messageLineMax;

			[SerializeField]
			[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aè¡\u008cæ\u0095°æ\u00af\u008eã\u0081®é«\u0098ã\u0081\u0095å·®å\u0088\u0086")]
			public float messageLineHeightDiff;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aå\u009fºæº\u0096é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4")]
			public float monologueAdjustBaseHeight;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aè¡\u008cæ\u0095°")]
			public int monologueLineMax;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aè¡\u008cæ\u0095°æ\u00af\u008eã\u0081®é«\u0098ã\u0081\u0095å·®å\u0088\u0086")]
			public float monologueLineHeightDiff;

			[SerializeField]
			[Header("ã\u0081\u0082ã\u0082\u0089ã\u0081\u0099ã\u0081\u0098ï¼\u009aå\u009fºæº\u0096é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4")]
			public float outlineAdjustBaseHeight;

			[SerializeField]
			[Header("ã\u0081\u0082ã\u0082\u0089ã\u0081\u0099ã\u0081\u0098ï¼\u009aè¡\u008cæ\u0095°")]
			public int outlineLineMax;

			[SerializeField]
			[Header("ã\u0081\u0082ã\u0082\u0089ã\u0081\u0099ã\u0081\u0098ï¼\u009aè¡\u008cæ\u0095°æ\u00af\u008eã\u0081®é«\u0098ã\u0081\u0095å·®å\u0088\u0086")]
			public float outlineLineHeightDiff;

			[SerializeField]
			[Header("ã\u0083\u009aã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºï¼\u009aå\u009fºæº\u0096é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4")]
			public float bookTextAdjustBaseHeight;

			[SerializeField]
			[Header("ã\u0083\u009aã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºï¼\u009aè¡\u008cæ\u0095°")]
			public int bookTextLineMax;

			[SerializeField]
			[Header("ã\u0083\u009aã\u0083¼ã\u0082\u00b8æ¼\u0094å\u0087ºï¼\u009aè¡\u008cæ\u0095°æ\u00af\u008eã\u0081®é«\u0098ã\u0081\u0095å·®å\u0088\u0086")]
			public float bookTextLineHeightDiff;

			[SerializeField]
			[Header("è©±è\u0080\u0085å\u0090\u008dï¼\u009aæ\u0096\u0087å­\u0097æ\u0095°ä\u00b8\u008aé\u0099\u0090")]
			public int nameLineLetterMax;

			[SerializeField]
			[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aæ\u0096\u0087å­\u0097æ\u0095°ä\u00b8\u008aé\u0099\u0090")]
			public int messageLineLetterMax;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aæ\u0096\u0087å­\u0097æ\u0095°ä\u00b8\u008aé\u0099\u0090")]
			public int monologueLineLetterMax;

			[SerializeField]
			[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aç«\u00a0å°\u008eå\u0085¥æ¼\u0094å\u0087ºæ\u0099\u0082ã\u0081®å\u009fºæº\u0096ä½\u008dç½®")]
			public Vector2[] chapterIntroductionTextsParentsBasePos;

			public void ReflectionSetting()
			{
			}
		}

		[Header("ã\u0083\u0091ã\u0082¿ã\u0083¼ã\u0083³å\u0088¥è\u00a8­å®\u009a")]
		public Setting[] settings;

		[SerializeField]
		[Header("å\u0085±é\u0080\u009aè\u00a8­å®\u009a")]
		[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aä\u00b8\u0080æ\u0096\u0087å­\u0097ã\u0081\u0082ã\u0081\u009fã\u0082\u008aã\u0081®è¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093")]
		public float showOneLetterInterval;

		[SerializeField]
		[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aä\u00b8\u0080è¡\u008cã\u0081\u0082ã\u0081\u009fã\u0082\u008aã\u0081®è¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093")]
		public float showMonologueOneLineInterval;

		[SerializeField]
		[Header("ã\u0083¢ã\u0083\u008eã\u0083­ã\u0083¼ã\u0082°ï¼\u009aé\u009d\u009eè¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093")]
		public float hideMonologueSeconds;

		[SerializeField]
		[Header("ã\u0083«ã\u0083\u0093ï¼\u009aã\u0083«ã\u0083\u0093ã\u0081®é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4ä¿\u0082æ\u0095°")]
		public float rubyUpCoefficient;

		[SerializeField]
		[Header("ã\u0083«ã\u0083\u0093ï¼\u009aã\u0083«ã\u0083\u0093ã\u0082µã\u0082¤ã\u0082ºèª¿æ\u0095\u00b4ä¿\u0082æ\u0095°")]
		public float rubySizeCoefficient;

		[SerializeField]
		[Header("ã\u0083«ã\u0083\u0093ï¼\u009aã\u0081\u0082ã\u0082\u0089ã\u0081\u0099ã\u0081\u0098ã\u0083«ã\u0083\u0093ã\u0081®é«\u0098ã\u0081\u0095èª¿æ\u0095\u00b4ä¿\u0082æ\u0095°")]
		public float outlineRubyUpCoefficient;

		[SerializeField]
		[Header("ã\u0083«ã\u0083\u0093ï¼\u009aã\u0081\u0082ã\u0082\u0089ã\u0081\u0099ã\u0081\u0098ã\u0083«ã\u0083\u0093ã\u0082µã\u0082¤ã\u0082ºèª¿æ\u0095\u00b4ä¿\u0082æ\u0095°")]
		public float outlineRubySizeCoefficient;

		[SerializeField]
		[Header("ã\u0082ªã\u0083¼ã\u0083\u0088ï¼\u009aã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088è¡\u00a8ç¤ºå¾\u008cå¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		public float autoWaitTime;

		[SerializeField]
		[Header("ã\u0082ªã\u0083¼ã\u0083\u0088ï¼\u009aã\u0083\u009cã\u0082¤ã\u0082¹å\u0086\u008dç\u0094\u009få¾\u008cå¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		public float autoWaitTimeForVoice;

		[SerializeField]
		[Header("ã\u0082ªã\u0083¼ã\u0083\u0088ï¼\u009aã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0082\u0081ã\u0081\u008fã\u0082\u008aå¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		public float autoWaitTimeForNextPage;

		[SerializeField]
		[Header("ã\u0082ªã\u0083¼ã\u0083\u0088ï¼\u009aè¡\u008cæ\u0095°ã\u0081«ã\u0082\u0088ã\u0082\u008bå¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093å\u008a\u00a0ç®\u0097")]
		public float[] addAutoWaitTimeByLineCount;

		[SerializeField]
		[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aprintã\u0082³ã\u0083\u009eã\u0083³ã\u0083\u0089ã\u0081§ã\u0081®ã\u0082¦ã\u0082£ã\u0083³ã\u0083\u0089ã\u0082¦ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089æ\u0099\u0082é\u0096\u0093")]
		public float windowFadeinTimeForPrintCommand;

		[SerializeField]
		[Header("ã\u0083¡ã\u0083\u0083ã\u0082»ã\u0083¼ã\u0082\u00b8ï¼\u009aã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ä»\u0098ã\u0081\u008dã\u0082¦ã\u0082£ã\u0083³ã\u0083\u0089ã\u0082¦ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089æ\u0099\u0082é\u0096\u0093")]
		public float windowFadeTimeWithAnimation;

		public static SettingPattern GetSettingPattern()
		{
			return default(SettingPattern);
		}

		public void ReflectionSetting()
		{
		}
	}
}
