/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Core;
using UnityEngine;
using UnityEngine.Networking;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class AssetDownloader : MonoBehaviour
	{
		// Fields
		public const string ManifestName = "assetbundle";
		public const string ManifestExtension = ".manifest";
		public const string DefaultManifestVersion = "0";
		private int retryCount;
		private float manifestDownloadSpeed;
		private NetworkLevel networkLevel;
		private static AssetDownloader instance;
		[CompilerGenerated]
		private AssetBundleManifest _Manifest_k__BackingField;
		[CompilerGenerated]
		private string _ManifestVersion_k__BackingField;
		[CompilerGenerated]
		private Dictionary<string, string> _Header_k__BackingField;
		[CompilerGenerated]
		private bool _IsReadyForUsePreinAssetBundle_k__BackingField;
		[CompilerGenerated]
		private bool _HasPreinManifest_k__BackingField;
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
	
		// Properties
		public static AssetDownloader Instance { get; }
		public static bool HasInstance { get; }
		public AssetBundleManifest Manifest { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string ManifestVersion { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string[] ManifestVersions { get; }
		public Dictionary<string, string> Header { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsDownloading { get; }
		public bool IsReadyForUsePreinAssetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int DownloadProcessCount { get; set; }
		public bool HasPreinManifest { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string AssetsDirectory { get; }
		public string ManifestBaseDirectory { get; }
		public string AdditionalManifestBaseDirectory { get; }
		public bool IsReadyForDownload { get; }
		public bool IsDownloadFileExists { get; }
	
		// Nested types
		private enum NetworkLevel
		{
			VeryBad = 0,
			Bad = 1,
			Normal = 2,
			High = 3
		}
	
		public class CpOperation
		{
			// Fields
			[CompilerGenerated]
			private float _Progress_k__BackingField;
			[CompilerGenerated]
			private bool _IsDone_k__BackingField;
			private List<string> assets;
			private Action onSuccess;
			private Action onFailed;
			private bool paused;
	
			// Properties
			public float Progress { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsDone { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class _CopyStreamingAssetsForAndroid_d__14 : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public CpOperation __4__this;
				private string _dstDirectory_5__2;
				private int _i_5__3;
				private int _count_5__4;
				private string _outputPath_5__5;
				private UnityWebRequest _request_5__6;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _CopyStreamingAssetsForAndroid_d__14(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				private void __m__Finally1();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public CpOperation(IEnumerable<string> assets, Action onSuccess, Action onFailed);
	
			// Methods
			public void Restart();
			[IteratorStateMachine]
			private IEnumerator CopyStreamingAssetsForAndroid();
		}
	
		internal struct VoidTaskResult
		{
		}
	
		public class Operation
		{
			// Fields
			[CompilerGenerated]
			private bool _DebugOperationFailure_k__BackingField;
			private long totalSize;
			private long downloadedSize;
			private Action onSuccess;
			private Action<DownloadErrorType, string> onFailed;
			private Queue<string> queue;
			private HashSet<string> downloaded;
			[CompilerGenerated]
			private float _WaitTime_k__BackingField;
	
			// Properties
			public bool DebugOperationFailure { [CompilerGenerated] get; [CompilerGenerated] set; }
			public long TotalSize { get; }
			public long DownloadedSize { get; }
			public bool IsDone { get; }
			public float Progress { get; }
			public float WaitTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass25_0
			{
				// Fields
				public TaskCompletionSource<VoidTaskResult> promise;
	
				// Constructors
				public __c__DisplayClass25_0();
	
				// Methods
				internal void _StartAsync_b__0();
				internal void _StartAsync_b__1(DownloadErrorType e, string s);
			}
	
			// Constructors
			public Operation(IEnumerable<string> assets, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart);
	
			// Methods
			public void Start();
			public void Start(Action onSuccess, Action<DownloadErrorType, string> onFailed);
			public Task StartAsync();
			private void OnFileDownloaded(string hash);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public string directory;
			public string preinAssetDirectory;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _CheckDownloadedFiles_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public string dstDirectory;
			public string[] deleteFilePaths;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal string _CopyStreamingAssetsForAndroid_b__0(string path);
			internal void _CopyStreamingAssetsForAndroid_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public TaskCompletionSource<VoidTaskResult> promise;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _DownloadManifest_b__0();
			internal void _DownloadManifest_b__1(DownloadErrorType e, string s);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public Queue<Action> downloadQueue;
			public AssetDownloader __4__this;
			public Action onSuccess;
			public Action<long> deletedSizeCallback;
			public string[] variants;
			public Action onDownloadCompleted;
			public Action<DownloadErrorType, string> onFailed;
			public string manifestBaseDirectory;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _DownloadManifests_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_1
		{
			// Fields
			public string manifestBaseUrl;
			public string version;
			public __c__DisplayClass70_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass70_1();
	
			// Methods
			internal void _DownloadManifests_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0
		{
			// Fields
			public AssetDownloader __4__this;
			public string version;
			public string[] variants;
			public Action onSuccess;
			public string manifestBaseUrl;
			public string manifestDirectory;
			public Action<DownloadErrorType, string> onFailed;
	
			// Constructors
			public __c__DisplayClass71_0();
	
			// Methods
			internal void _DownloadManifest_b__0(ScriptableObjectManifest soManifest);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0
		{
			// Fields
			public AssetBundleManifest manifest;
			public Queue<string> downloadQueue;
			public Action onSuccess;
			public AssetDownloader __4__this;
			public string manifestBaseUrl;
			public string manifestDirectory;
			public Action<DownloadErrorType, string> onFailed;
	
			// Constructors
			public __c__DisplayClass72_0();
	
			// Methods
			internal void _DownloadVariantManifest_b__0(ScriptableObjectManifest soManifest);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public Stopwatch stopwatch;
			public string manifestFilePath;
			public AssetDownloader __4__this;
			public Action<ScriptableObjectManifest> onSuccess;
			public Action<DownloadErrorType, string> onFailed;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _DownloadManifest_b__0(string protocol);
			internal void _DownloadManifest_b__1(DownloadErrorType errorType, string errorMessage);
		}
	
		[CompilerGenerated]
		private sealed class _PostprocessForDownloadManifest_d__75 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetDownloader __4__this;
			public Action<long> deletedSizeCallback;
			public Action onEnd;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PostprocessForDownloadManifest_d__75(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public AssetDownloader __4__this;
			public string[] deleteFilePaths;
	
			// Constructors
			public __c__DisplayClass76_0();
	
			// Methods
			internal string _DeleteUnusedFiles_b__0(string path);
			internal void _DeleteUnusedFiles_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public DownloadOperation op;
			public Action<string> onFileDownloaded;
			public AssetDownloader __4__this;
			public Action onSuccess;
			public Action<DownloadErrorType, string> onFailed;
			public Queue<string> queue;
			public Action<string> downloaded;
			public Action<DownloadErrorType, string> failed;
			public bool debugDownloadFailure;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal void _DownloadAssetsImpl_b__0(string path);
			internal void _DownloadAssetsImpl_b__1(DownloadErrorType errorType, string message);
			internal void _DownloadAssetsImpl_b__2(string path);
		}
	
		[CompilerGenerated]
		private sealed class _DownloadAssetsImpl_d__85 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetDownloader __4__this;
			public DownloadOperation downloadOperation;
			public Queue<string> downloadQueue;
			public Action<string> onSuccess;
			public Action<DownloadErrorType, string> onFailed;
			public bool debugDownloadFailure;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DownloadAssetsImpl_d__85(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0
		{
			// Fields
			public Action<string> onSuccess;
			public AssetDownloader __4__this;
			public Queue<string> downloadQueue;
			public Action<DownloadErrorType, string> onFailed;
	
			// Constructors
			public __c__DisplayClass87_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_1
		{
			// Fields
			public string path;
			public __c__DisplayClass87_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass87_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_2
		{
			// Fields
			public bool isSuccess;
			public bool isError;
			public __c__DisplayClass87_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass87_2();
	
			// Methods
			internal void _DownloadAssetsFromQueue_b__0(string msg);
			internal void _DownloadAssetsFromQueue_b__1(DownloadErrorType type, string error);
		}
	
		[CompilerGenerated]
		private sealed class _DownloadAssetsFromQueue_d__87 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action<string> onSuccess;
			public AssetDownloader __4__this;
			public Queue<string> downloadQueue;
			public Action<DownloadErrorType, string> onFailed;
			private __c__DisplayClass87_0 __8__1;
			public bool debugDownloadFailure;
			public DownloadOperation downloadOperation;
			private __c__DisplayClass87_2 __8__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DownloadAssetsFromQueue_d__87(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass88_0
		{
			// Fields
			public Action<string> onSuccess;
			public string path;
			public Action<DownloadErrorType, string> onFailed;
	
			// Constructors
			public __c__DisplayClass88_0();
	
			// Methods
			internal void _DownloadAsset_b__0(string protocol);
			internal void _DownloadAsset_b__1(DownloadErrorType errorType, string errorMessage);
		}
	
		[CompilerGenerated]
		private sealed class _DeleteAllFilesImpl_d__91 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetDownloader __4__this;
			public Action onEnd;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DeleteAllFilesImpl_d__91(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0
		{
			// Fields
			public string path;
			public AssetDownloader __4__this;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass99_0();
	
			// Methods
			internal void _PostprocessOnLoadAsset_b__0();
			internal void _PostprocessOnLoadAsset_b__1();
		}
	
		// Constructors
		public AssetDownloader();
		static AssetDownloader();
	
		// Methods
		public void Initialize(string serverPath, Action<string> manipulateDetectedCallback = null);
		[RuntimeInitializeOnLoadMethod]
		private static void CheckDownloadedFiles();
		public void LoadPreinManifest(string[] variants);
		public bool ChangeManifestVersion(string version);
		public CopyOperation CopyStreamingAssetsForAndroid(Action onSuccess, Action onError);
		public Task DownloadManifest(string manifestBaseUrl, string[] variants, string version = "0");
		public void DownloadManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version = "0", Action<long> deletedSizeCallback = null);
		public void DownloadAdditionalManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version = "0", Action<long> deletedSizeCallback = null);
		public void DownloadManifests(string[] manifestBaseUrls, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string[] versions, Action<long> deletedSizeCallback = null);
		private void DownloadManifests(string[] manifestBaseUrls, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string[] versions, string manifestBaseDirectory, Action<long> deletedSizeCallback);
		private void DownloadManifest(string manifestBaseUrl, string[] variants, Action onSuccess, Action<DownloadErrorType, string> onFailed, string version, string manifestBaseDirectory);
		private void DownloadVariantManifest(AssetBundleManifest manifest, string manifestBaseUrl, string manifestDirectory, Queue<string> downloadQueue, Action onSuccess, Action<DownloadErrorType, string> onFailed);
		private void DownloadManifest(string manifestUrl, string manifestDirectory, Action<ScriptableObjectManifest> onSuccess, Action<DownloadErrorType, string> onFailed);
		private void InitializeNetworkLevelWithManifestDownloadSpeed();
		[IteratorStateMachine]
		private IEnumerator PostprocessForDownloadManifest(Action onEnd, Action<long> deletedSizeCallback);
		private void DeleteUnusedFiles(Action<long> deletedSizeCallback);
		public DownloadOperation DownloadAssets(Func<string, bool> match, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAssets(IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAssets(Func<string, bool> match, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAssets(string category, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAssets(int[] groups, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAssets(int[] groups, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public DownloadOperation DownloadAllAssets(Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		private void DownloadAssetsImpl(DownloadOperation op, Queue<string> queue, Action onSuccess, Action<DownloadErrorType, string> onFailed, Action<string> onFileDownloaded, bool debugDownloadFailure);
		[IteratorStateMachine]
		private IEnumerator DownloadAssetsImpl(DownloadOperation downloadOperation, Queue<string> downloadQueue, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed, Action<string> onInvalidFileDetected, bool debugDownloadFailure);
		private void ConfigDownloadParameters();
		[IteratorStateMachine]
		private IEnumerator DownloadAssetsFromQueue(DownloadOperation downloadOperation, Queue<string> downloadQueue, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed, bool debugDownloadFailure);
		private void DownloadAsset(DownloadOperation downloadOperation, string serverPath, string path, Action<string> onSuccess, Action<DownloadErrorType, string> onFailed);
		public void CancelDownload();
		public void DeleteAllFiles(Action onEnd);
		[IteratorStateMachine]
		private IEnumerator DeleteAllFilesImpl(Action onEnd);
		public void DeleteFiles(IEnumerable<string> paths);
		public void DeleteGroupFiles(int[] groups);
		public void DeleteMatchFiles(Func<string, bool> matchFunc);
		private void DeleteFilesByHash(HashSet<string> deleteFiles);
		private string GetAssetBundleNameFromHash(string hash);
		public long GetDownloadedFileSize(IEnumerable<string> assetNames);
		public bool IsDownloaded(string assetName);
		public ParallelJob PostprocessOnLoadAsset(string path);
		public string GetAssetsPath(string hash, out bool isPrein);
		public string GetDownloadedAssetsPath(string hash);
		public static string GetPreinAssetsPath(string hash);
		public static string GetSubDirectoryPath(string filename);
		private static bool IsValidAssetPath(string[] paths);
		private void OnDestroy();
		private static int GetVariantsHash(string[] variants);
		private static void SetException(TaskCompletionSource<VoidTaskResult> promise, DownloadErrorType e, string s);
	}
}
