/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class UnityAsyncExtensions
	{
		// Nested types
		public struct AsyncOperationAwaiter : IAwaiter
		{
			// Fields
			private AsyncOperation asyncOperation;
			private Action<AsyncOperation> continuationAction;
			private AwaiterStatus status;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public AsyncOperationAwaiter(AsyncOperation asyncOperation);
	
			// Methods
			public void GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class AsyncOperationConfiguredAwaiter : IAwaiter, IPlayerLoopItem
		{
			// Fields
			private AsyncOperation asyncOperation;
			private IProgress<float> progress;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public AsyncOperationConfiguredAwaiter(AsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken);
	
			// Methods
			public void GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		public struct ResourceRequestAwaiter : IAwaiter<UnityEngine.Object>
		{
			// Fields
			private ResourceRequest asyncOperation;
			private Action<AsyncOperation> continuationAction;
			private AwaiterStatus status;
			private UnityEngine.Object result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public ResourceRequestAwaiter(ResourceRequest asyncOperation);
	
			// Methods
			public UnityEngine.Object GetResult();
			void IAwaiter.GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class ResourceRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem
		{
			// Fields
			private ResourceRequest asyncOperation;
			private IProgress<float> progress;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
			private UnityEngine.Object result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public ResourceRequestConfiguredAwaiter(ResourceRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken);
	
			// Methods
			void IAwaiter.GetResult();
			public UnityEngine.Object GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		public struct AssetBundleRequestAwaiter : IAwaiter<UnityEngine.Object>
		{
			// Fields
			private AssetBundleRequest asyncOperation;
			private Action<AsyncOperation> continuationAction;
			private AwaiterStatus status;
			private UnityEngine.Object result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation);
	
			// Methods
			public UnityEngine.Object GetResult();
			void IAwaiter.GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class AssetBundleRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IPlayerLoopItem
		{
			// Fields
			private AssetBundleRequest asyncOperation;
			private IProgress<float> progress;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
			private UnityEngine.Object result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public AssetBundleRequestConfiguredAwaiter(AssetBundleRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken);
	
			// Methods
			void IAwaiter.GetResult();
			public UnityEngine.Object GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class WWWConfiguredAwaiter : IAwaiter, IPlayerLoopItem
		{
			// Fields
			private WWW asyncOperation;
			private IProgress<float> progress;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public WWWConfiguredAwaiter(WWW asyncOperation, IProgress<float> progress, CancellationToken cancellationToken);
	
			// Methods
			public void GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		public struct UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest>
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation;
			private Action<AsyncOperation> continuationAction;
			private AwaiterStatus status;
			private UnityWebRequest result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation);
	
			// Methods
			public UnityWebRequest GetResult();
			void IAwaiter.GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class UnityWebRequestAsyncOperationConfiguredAwaiter : IAwaiter<UnityWebRequest>, IPlayerLoopItem
		{
			// Fields
			private UnityWebRequestAsyncOperation asyncOperation;
			private IProgress<float> progress;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
			private UnityWebRequest result;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public UnityWebRequestAsyncOperationConfiguredAwaiter(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken);
	
			// Methods
			void IAwaiter.GetResult();
			public UnityWebRequest GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		private class JobHandleAwaiter : IAwaiter, IPlayerLoopItem
		{
			// Fields
			private JobHandle jobHandle;
			private CancellationToken cancellationToken;
			private AwaiterStatus status;
			private Action continuation;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public JobHandleAwaiter(JobHandle jobHandle, CancellationToken cancellationToken, int skipFrame = 2);
	
			// Methods
			public void GetResult();
			public bool MoveNext();
			private void InvokeContinuation(AwaiterStatus status);
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
		}
	
		// Extension methods
		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation);
		public static UniTask ToUniTask(this AsyncOperation asyncOperation);
		public static UniTask ConfigureAwait(this AsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellation = default);
		public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest resourceRequest);
		public static UniTask<UnityEngine.Object> ToUniTask(this ResourceRequest resourceRequest);
		public static UniTask<UnityEngine.Object> ConfigureAwait(this ResourceRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellation = default);
		public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest resourceRequest);
		public static UniTask<UnityEngine.Object> ToUniTask(this AssetBundleRequest resourceRequest);
		public static UniTask<UnityEngine.Object> ConfigureAwait(this AssetBundleRequest resourceRequest, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellation = default);
		public static IAwaiter GetAwaiter(this WWW www);
		public static UniTask ToUniTask(this WWW www);
		public static UniTask ConfigureAwait(this WWW www, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellation = default);
		public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation);
		public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation);
		public static UniTask<UnityWebRequest> ConfigureAwait(this UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellation = default);
		public static IAwaiter GetAwaiter(this JobHandle jobHandle);
		public static UniTask ToUniTask(this JobHandle jobHandle, CancellationToken cancellation = default);
		public static UniTask ConfigureAwait(this JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellation = default);
		public static AsyncUnityEventHandler GetAsyncEventHandler(this UnityEvent unityEvent, CancellationToken cancellationToken);
		public static UniTask OnInvokeAsync(this UnityEvent unityEvent, CancellationToken cancellationToken);
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button);
		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button, CancellationToken cancellationToken);
		public static UniTask OnClickAsync(this Button button);
		public static UniTask OnClickAsync(this Button button, CancellationToken cancellationToken);
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle);
		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle, CancellationToken cancellationToken);
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle);
		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle, CancellationToken cancellationToken);
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar);
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar, CancellationToken cancellationToken);
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar);
		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar, CancellationToken cancellationToken);
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect);
		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect, CancellationToken cancellationToken);
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect);
		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect, CancellationToken cancellationToken);
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider);
		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider, CancellationToken cancellationToken);
		public static UniTask<float> OnValueChangedAsync(this Slider slider);
		public static UniTask<float> OnValueChangedAsync(this Slider slider, CancellationToken cancellationToken);
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField);
		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField, CancellationToken cancellationToken);
		public static UniTask<string> OnEndEditAsync(this InputField inputField);
		public static UniTask<string> OnEndEditAsync(this InputField inputField, CancellationToken cancellationToken);
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown);
		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown, CancellationToken cancellationToken);
		public static UniTask<int> OnValueChanged(this Dropdown dropdown);
		public static UniTask<int> OnValueChanged(this Dropdown dropdown, CancellationToken cancellationToken);
	}
}
