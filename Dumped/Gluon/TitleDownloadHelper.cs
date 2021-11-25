using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cute.AssetBundle;
using UnityEngine.Events;

namespace Gluon
{
	public class TitleDownloadHelper : SingletonMonoBehaviour<TitleDownloadHelper>
	{
		public string manifestPath;

		public string manifestVersion;

		public bool exceptVoiceOnFullDownload;

		public const string UseAssetBundlePrefs = "UseAssetBundle";

		public const string UseLocalAssetBundlePrefs = "UseLocalAssetBundle";

		private DownloadOperation manifestDownloadOperation;

		private Action<DownloadOperation, DownloadOperation, DownloadOperation, bool> onCheckCompleted;

		private Action onManifestDownloadedCallback;

		private const string developBranch = "develop";

		protected override void Awake()
		{
		}

		public void ReadyDownload(Action<DownloadOperation, DownloadOperation, DownloadOperation, bool> onCompleted, [Optional] Action<long> deletedSizeCallback)
		{
		}

		public void InitAssetBundleConfig()
		{
		}

		private void SetProductSettings(out string assetbundlePath)
		{
		}

		public void CheckDownload([Optional] Action onManifestDownloadedCallback, bool fullDownload = false, [Optional] Action<long> deletedSizeCallback)
		{
		}

		public void DownloadManifest(Action onManifestDownloaded, [Optional] Action<long> deletedSizeCallback)
		{
		}

		private void OnManifestDownloaded()
		{
		}

		private IEnumerator OnManifestDownloadedCoroutine()
		{
			return null;
		}

		private void CheckUnlockedFortAssets()
		{
		}

		private void CheckAfterPrologueAssets()
		{
		}

		private void CheckBeforeProloguelAssets()
		{
		}

		private void CreateDownloadErrorPopup(DownloadErrorType type, UnityAction onDownloadFailed)
		{
		}

		private void InvokeOnCheckCompleted(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool isBeforePrologure)
		{
		}
	}
}
