using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-ActionPartsPivotBullet")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/å\u009bºæ\u009c\u0089ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³/ã\u0082¿ã\u0083\u008aã\u0083\u0088ã\u0082¹/æ\u0097\u008bå\u009b\u009eå¼¾ç\u0094\u009fæ\u0088\u0090_ã\u0082«ã\u0082¦ã\u0083³ã\u0082¿æ\u00b8\u009bå°\u0091ä»\u0098ã\u0081\u008dHit", 0)]
	public class ActionPartsTanatosHitPivotBullet : ActionPartsPivotBullet
	{
		[SerializeField]
		private TanatosHitPivotBulletData _customData;

		public override PartsData data => null;
	}
}
