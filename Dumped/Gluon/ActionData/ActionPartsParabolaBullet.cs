using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-ActionPartsParabolaBullet")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/ã\u0083\u0090ã\u0083¬ã\u0083\u0083ã\u0083\u0088/æ\u0094¾ç\u0089©å¼¾ç\u0094\u009fæ\u0088\u0090", 0)]
	public class ActionPartsParabolaBullet : ActionPartsBulletWithMarkerBase
	{
		[SerializeField]
		private ParabolaBulletData _data;

		public const float MAX_DURATION_AFTER_RUSH = 100f;

		public const float MAX_DROP_TIME = 100f;

		public override PartsData data => null;
	}
}
