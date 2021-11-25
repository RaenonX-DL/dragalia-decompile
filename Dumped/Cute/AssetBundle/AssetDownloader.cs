using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cute.Core;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class AssetDownloader : MonoBehaviour
	{
		private enum NetworkLevel
		{
			VeryBad,
			Bad,
			Normal,
			High
		}

		public class CpOperation
		{
			private List<string> assets;

			private Action onSuccess;

			private Action onFailed;

			private bool paused;

			public float Progress
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool IsDone
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

			public CpOperation(IEnumerable<string> assets, Action onSuccess, Action onFailed)
			{
			}

			public void Restart()
			{
			}

			private IEnumerator CopyStreamingAssetsForAndroid()
			{
				return null;
			}
		}

		internal struct VoidTaskResult
		{
		}

		public class Operation
		{
			private long totalSize;

			private long downloadedSize;

			private Action onSuccess;

			private Action<DownloadErrorType, string> onFailed;

			private Queue<string> queue;

			private HashSet<string> downloaded;

			public bool DebugOperationFailure
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long TotalSize => default(long);

			public long DownloadedSize => default(long);

			public bool IsDone => default(bool);

			public float Progress => default(float);

			public Operation(IEnumerable<string> assets, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart)
			{
			}

			public void Start()
			{
			}

			public void Start(Action onSuccess, Action<DownloadErrorType, string> onFailed)
			{
			}

			public Task StartAsync()
			{
				return null;
			}

			private void OnFileDownloaded(string hash)
			{
			}
		}

		public const string ManifestName = "assetbundle";

		public const string ManifestExtension = ".manifest";

		public const string DefaultManifestVersion = "0";

		private int retryCount;

		private float manifestDownloadSpeed;

		private NetworkLevel networkLevel;

		private static AssetDownloader instance;

		private const int DOWNLOAD_PROCESS_COUNT_MAX = 32;

		private int downloadProcessCount;

		private string assetsDirectory;

		private string serverPath;

		private Action<string> manipulateDetectedCallback;

		private static HashSet<string> downloadedFiles;

		private static HashSet<string> preinFiles;

		private bool downloadLock;

		private int currentProcessCount;

		private AssetBundleManifest preinManifest;

		private Dictionary<string, AssetBundleManifest> manifests;

		private int variantsHash;

		public static AssetDownloader Instance => null;

		public static bool HasInstance => default(bool);

		public AssetBundleManifest Manifest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ManifestVersion
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string[] ManifestVersions => null;

		public Dictionary<string, string> Header
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsDownloading => default(bool);

		public bool IsReadyForUsePreinAssetBundle
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

		public int DownloadProcessCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool HasPreinManifest
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

		public string AssetsDirectory => null;

		public string ManifestBaseDirectory => null;

		public string AdditionalManifestBaseDirectory => null;

		public bool IsReadyForDownload => default(bool);

		public bool IsDownloadFileExists => default(bool);

		public void Initialize(string serverPath, [Optional] Action<string> manipulateDetectedCallback)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void CheckDownloadedFiles()
		{
		}

		public void LoadPreinManifest(string[] variants)
		{
		}

		public bool ChangeManifestVersion(string version)
		{
			return default(bool);
		}

		public CopyOperation CopyStreamingAssetsForAndroid(Action onSuccess, Action onError)
		{
			return null;
		}

		public Task DownloadManifest(string manifestBaseUrl, string[] variants, string version = "0")
		{
			return null;
		}

		public void DownloadManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version = "0", [Optional] Action<long> deletedSizeCallback)
		{
		}

		public void DownloadAdditionalManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version = "0", [Optional] Action<long> deletedSizeCallback)
		{
		}

		public void DownloadManifests(string[] manifestBaseUrls, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string[] versions, [Optional] Action<long> deletedSizeCallback)
		{
		}

		private void DownloadManifests(string[] manifestBaseUrls, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string[] versions, string manifestBaseDirectory, Action<long> deletedSizeCallback)
		{
		}

		private void DownloadManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version, string manifestBaseDirectory)
		{
		}

		private void DownloadVariantManifest(AssetBundleManifest manifest, string manifestBaseUrl, string manifestDirectory, Queue<string> downloadQueue, Action onSuccess, Action<DownloadErrorType, string> onFailed)
		{
		}

		private void DownloadManifest(string manifestUrl, string manifestDirectory, Action<ScriptableObjectManifest> onSuccess, Action<DownloadErrorType, string> onFailed)
		{
		}

		private void InitializeNetworkLevelWithManifestDownloadSpeed()
		{
		}

		private IEnumerator PostprocessForDownloadManifest(Action onEnd, Action<long> deletedSizeCallback)
		{
			return null;
		}

		private void DeleteUnusedFiles(Action<long> deletedSizeCallback)
		{
		}

		public DownloadOperation DownloadAssets(Func<string, bool> match, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAssets(IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAssets(Func<string, bool> match, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAssets(string category, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAssets(int[] groups, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAssets(int[] groups, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public DownloadOperation DownloadAllAssets(Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		private void DownloadAssetsImpl(DownloadOperation op, Queue<string> queue, Action onSuccess, Action<DownloadErrorType, string> onFailed, Action<string> onFileDownloaded, bool debugDownloadFailure)
		{
		}

		private IEnumerator DownloadAssetsImpl(DownloadOperation downloadOperation, Queue<string> downloadQueue, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed, Action<string> onInvalidFileDetected, bool debugDownloadFailure)
		{
			return null;
		}

		private void ConfigDownloadParameters()
		{
		}

		private IEnumerator DownloadAssetsFromQueue(DownloadOperation downloadOperation, Queue<string> downloadQueue, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed, bool debugDownloadFailure)
		{
			return null;
		}

		private void DownloadAsset(DownloadOperation downloadOperation, string serverPath, string path, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed)
		{
		}

		public void CancelDownload()
		{
		}

		public void DeleteAllFiles(Action onEnd)
		{
		}

		private IEnumerator DeleteAllFilesImpl(Action onEnd)
		{
			return null;
		}

		public void DeleteFiles(IEnumerable<string> paths)
		{
		}

		public void DeleteGroupFiles(int[] groups)
		{
		}

		public void DeleteMatchFiles(Func<string, bool> matchFunc)
		{
		}

		private void DeleteFilesByHash(HashSet<string> deleteFiles)
		{
		}

		private string GetAssetBundleNameFromHash(string hash)
		{
			return null;
		}

		public long GetDownloadedFileSize(IEnumerable<string> assetNames)
		{
			return default(long);
		}

		public bool IsDownloaded(string assetName)
		{
			return default(bool);
		}

		public ParallelJob PostprocessOnLoadAsset(string path)
		{
			return null;
		}

		public string GetAssetsPath(string hash, out bool isPrein)
		{
			return null;
		}

		public string GetDownloadedAssetsPath(string hash)
		{
			return null;
		}

		public static string GetPreinAssetsPath(string hash)
		{
			return null;
		}

		public static string GetSubDirectoryPath(string filename)
		{
			return null;
		}

		private static bool IsValidAssetPath(string[] paths)
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		private static int GetVariantsHash(string[] variants)
		{
			return default(int);
		}

		private static void SetException(TaskCompletionSource<VoidTaskResult> promise, DownloadErrorType e, string s)
		{
		}
	}
}
