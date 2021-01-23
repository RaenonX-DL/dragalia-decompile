/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using CriMana.Detail;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana
{
	public class Player : CriDisposable
	{
		// Fields
		private const int InvalidPlayerId = -1;
		private static Player updatingPlayer;
		private int playerId;
		private bool isDisposed;
		private Status requiredStatus;
		private Status nativeStatus;
		private bool isNativeStartInvoked;
		private bool isNativeInitialized;
		private RendererResource rendererResource;
		private MovieInfo _movieInfo;
		private FrameInfo _frameInfo;
		private bool isMovieInfoAvailable;
		private bool isFrameInfoAvailable;
		private ShaderDispatchCallback _shaderDispatchCallback;
		private bool enableSubtitle;
		private int subtitleBufferSize;
		private uint droppedFrameCount;
		private CriAtomExPlayer _atomExPlayer;
		private CriAtomEx3dSource _atomEx3Dsource;
		public CuePointCallback cuePointCallback;
		[CompilerGenerated]
		private bool _additiveMode_k__BackingField;
		[CompilerGenerated]
		private int _maxFrameDrop_k__BackingField;
		[CompilerGenerated]
		private bool _applyTargetAlpha_k__BackingField;
		[CompilerGenerated]
		private IntPtr _subtitleBuffer_k__BackingField;
		[CompilerGenerated]
		private int _subtitleSize_k__BackingField;
		[CompilerGenerated]
		private CriManaMoviePlayerHolder _playerHolder_k__BackingField;
	
		// Properties
		public bool additiveMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int maxFrameDrop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool applyTargetAlpha { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFrameAvailable { get; }
		public MovieInfo movieInfo { get; }
		public FrameInfo frameInfo { get; }
		public Status status { get; }
		public int numberOfEntries { get; }
		public IntPtr subtitleBuffer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int subtitleSize { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CriAtomExPlayer atomExPlayer { get; }
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { get; }
		public CriManaMoviePlayerHolder playerHolder { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum Status
		{
			Stop = 0,
			Dechead = 1,
			WaitPrep = 2,
			Prep = 3,
			Ready = 4,
			Playing = 5,
			PlayEnd = 6,
			Error = 7,
			StopProcessing = 8,
			ReadyForRendering = 9
		}
	
		public enum SetMode
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack
		{
			Off = 0,
			Auto = 1
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint);
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode);
	
		[UnmanagedFunctionPointer]
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint);
	
		public enum CriManaUnityPlayer_RenderEventAction
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		[CompilerGenerated]
		private sealed class _IssuePluginUpdatesForFrames_d__109 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Player __4__this;
			public int frameCount;
			public bool destroy;
			public MonoBehaviour playerHolder;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _IssuePluginUpdatesForFrames_d__109(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Player();
		public Player(bool advanced_audio_mode, bool ambisonics_mode);
		static Player();
	
		// Methods
		~Player();
		public override void Dispose();
		public void CreateRendererResource(int width, int height, bool alpha);
		public void DisposeRendererResource();
		public void Prepare();
		public void PrepareForRendering();
		public void Start();
		public void Stop();
		public void Pause(bool sw);
		public bool IsPaused();
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New);
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New);
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New);
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New);
		public void Loop(bool sw);
		public void SetSeekPosition(int frameNumber);
		public void SetMovieEventSyncMode(MovieEventSyncMode mode);
		public void SetSpeed(float speed);
		public void SetMaxPictureDataSize(uint maxDataSize);
		public void SetBufferingTime(float sec);
		public void SetMinBufferSize(int min_buffer_size);
		public void SetAudioTrack(int track);
		public void SetAudioTrack(AudioTrack track);
		public void SetSubAudioTrack(int track);
		public void SetSubAudioTrack(AudioTrack track);
		public void SetExtraAudioTrack(int track);
		public void SetExtraAudioTrack(AudioTrack track);
		public void SetVolume(float volume);
		public void SetSubAudioVolume(float volume);
		public void SetExtraAudioVolume(float volume);
		public void SetBusSendLevel(string bus_name, float level);
		public void SetSubAudioBusSendLevel(string bus_name, float volume);
		public void SetExtraAudioBusSendLevel(string bus_name, float volume);
		public void SetSubtitleChannel(int channel);
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback);
		public long GetTime();
		public int GetDisplayedFrameNo();
		public void SetAsrRackId(int asrRackId);
		public void Update();
		public void OnWillRenderObject(CriManaMovieMaterial sender);
		public bool UpdateMaterial(Material material);
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction);
		private void Dispose(bool disposing);
		[IteratorStateMachine]
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy);
		private void DisableInfos();
		private void PrepareNativePlayer();
		private void UpdateNativePlayer();
		private void AllocateSubtitleBuffer(int size);
		private void DeallocateSubtitleBuffer();
		[MonoPInvokeCallback]
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint);
		private static extern int CRIWAREA26BB8B2();
		private static extern int CRIWARE24719E0F();
		private static extern void CRIWARE2521A295(int player_id);
		private static extern void CRIWAREDA7020AB(int player_id, IntPtr binder, string path);
		private static extern void CRIWARE63277F6F(int player_id, IntPtr binder, int content_id);
		private static extern void CRIWARECB0E14E2(int player_id, string path, ulong offset, long range);
		private static extern void CRIWAREE313321C(int player_id, byte[] data, long datasize);
		private static extern bool CRIWAREB83D23AD(int player_id, IntPtr binder, string path, bool repeat);
		private static extern bool CRIWAREE0B9EFC2(int player_id, IntPtr binder, int content_id, bool repeat);
		private static extern bool CRIWARE5BAB5E33(int player_id, string path, ulong offset, long range, bool repeat);
		private static extern bool CRIWARE21520488(int player_id, byte[] data, long datasize, bool repeat);
		private static extern void CRIWARE5FCB5D7D(int player_id);
		private static extern int CRIWARE70236B44(int player_id);
		private static extern void CRIWARE08B3B694(int player_id, CuePointCallbackFromNativeDelegate cbfunc);
		private static extern void CRIWARE5E90CA71(int player_id, out MovieInfo movie_info);
		private static extern int CRIWAREEF57F36F(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size);
		private static extern void CRIWARE8445DC8A(int player_id);
		private static extern void CRIWARE816059CA(int player_id);
		private static extern void CRIWARE9E8B8158(int player_id);
		private static extern void CRIWARE5AEC2F15(int player_id, int seek_frame_no);
		private static extern void CRIWARE5FA753A4(int player_id, MovieEventSyncMode mode);
		private static extern void CRIWARE4909F06A(int player_id, int sw);
		private static extern bool CRIWARE8B4A3952(int player_id);
		private static extern void CRIWAREB0E53BA9(int player_id, int sw);
		private static extern long CRIWAREB3D5B710(int player_id);
		private static extern int CRIWAREDCB9402A(int player_id);
		private static extern IntPtr CRIWARE2647B0E8(int player_id);
		private static extern int CRIWARE9BD23668(int player_id);
		private static extern void CRIWARED336541F(int player_id, int track);
		private static extern void CRIWARE096C6782(int player_id, float vol);
		private static extern void CRIWARE90CD2D75(int player_id, int track);
		private static extern void CRIWARE9652D27A(int player_id, float vol);
		private static extern void CRIWAREF7A5FA03(int player_id, int track);
		private static extern void CRIWARE9D9FC302(int player_id, float vol);
		private static extern void CRIWARE64C0F341(int player_id, string bus_name, float level);
		private static extern void CRIWARE64013CA1(int player_id, string bus_name, float level);
		private static extern void CRIWAREBCACA7C0(int player_id, string bus_name, float level);
		private static extern void CRIWAREDF48E484(int player_id, int channel);
		private static extern void CRIWARED1F899CC(int player_id, float speed);
		private static extern void CRIWARED5BA6462(int player_id, uint max_data_size);
		public static extern void CRIWARE90471FC2(int player_id, float sec);
		public static extern void CRIWAREA6F66CFB(int player_id, int min_buffer_size);
		public static extern void CRIWARE8E5602ED(int player_id, int asr_rack_id);
		private static extern void CRIWARE9289E5B2(int player_id);
		private static extern IntPtr criWareUnity_GetRenderEventFunc();
	}
}
