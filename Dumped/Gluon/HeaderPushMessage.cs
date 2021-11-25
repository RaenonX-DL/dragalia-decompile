namespace Gluon
{
	public class HeaderPushMessage : HeaderMessageBase<PushNoticeData>
	{
		public bool isStopPushAnim;

		private void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override bool isShowOtherNotice()
		{
			return default(bool);
		}

		protected override bool IsWaitNeeded()
		{
			return default(bool);
		}
	}
}
