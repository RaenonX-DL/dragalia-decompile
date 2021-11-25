using System.Runtime.CompilerServices;

namespace Gluon
{
	public class BackGroundDownloader : SingletonMonoBehaviour<BackGroundDownloader>
	{
		private int prevDownloadProcessCount;

		public bool isDownloading
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		public void DoBackgroundDownload()
		{
		}

		public void StopDownload()
		{
		}
	}
}
