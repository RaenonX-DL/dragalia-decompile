using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriMana.Detail;
using UnityEngine;

namespace CriMana
{
	public class Player : CriDisposable
	{
		public enum Status
		{
			Stop,
			Dechead,
			WaitPrep,
			Prep,
			Ready,
			Playing,
			PlayEnd,
			Error,
			StopProcessing,
			ReadyForRendering
		}

		public enum SetMode
		{
			New,
			Append,
			AppendRepeatedly
		}

		public enum MovieEventSyncMode
		{
			FrameTime,
			PlayBackTime
		}

		public enum AudioTrack
		{
			Off,
			Auto
		}

		public delegate void CuePointCallback(ref EventPoint eventPoint);

		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint);

		public enum CriManaUnityPlayer_RenderEventAction
		{
			UPDATE = 0,
			INITIALIZE = 0x100,
			RENDER = 0x200,
			DESTROY = 768
		}

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

		public bool additiveMode
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

		public int maxFrameDrop
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool applyTargetAlpha
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

		public bool isFrameAvailable => default(bool);

		public MovieInfo movieInfo => null;

		public FrameInfo frameInfo => null;

		public Status status => default(Status);

		public int numberOfEntries => default(int);

		public IntPtr subtitleBuffer
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int subtitleSize
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CriAtomExPlayer atomExPlayer => null;

		public CriAtomEx3dSource atomEx3DsourceForAmbisonics => null;

		public CriManaMoviePlayerHolder playerHolder
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

		public Player()
		{
		}

		public Player(bool advanced_audio_mode, bool ambisonics_mode)
		{
		}

		~Player()
		{
		}

		public override void Dispose()
		{
		}

		public void CreateRendererResource(int width, int height, bool alpha)
		{
		}

		public void DisposeRendererResource()
		{
		}

		public void Prepare()
		{
		}

		public void PrepareForRendering()
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Pause(bool sw)
		{
		}

		public bool IsPaused()
		{
			return default(bool);
		}

		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New)
		{
			return default(bool);
		}

		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New)
		{
			return default(bool);
		}

		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New)
		{
			return default(bool);
		}

		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New)
		{
			return default(bool);
		}

		public void Loop(bool sw)
		{
		}

		public void SetSeekPosition(int frameNumber)
		{
		}

		public void SetMovieEventSyncMode(MovieEventSyncMode mode)
		{
		}

		public void SetSpeed(float speed)
		{
		}

		public void SetMaxPictureDataSize(uint maxDataSize)
		{
		}

		public void SetBufferingTime(float sec)
		{
		}

		public void SetMinBufferSize(int min_buffer_size)
		{
		}

		public void SetAudioTrack(int track)
		{
		}

		public void SetAudioTrack(AudioTrack track)
		{
		}

		public void SetSubAudioTrack(int track)
		{
		}

		public void SetSubAudioTrack(AudioTrack track)
		{
		}

		public void SetExtraAudioTrack(int track)
		{
		}

		public void SetExtraAudioTrack(AudioTrack track)
		{
		}

		public void SetVolume(float volume)
		{
		}

		public void SetSubAudioVolume(float volume)
		{
		}

		public void SetExtraAudioVolume(float volume)
		{
		}

		public void SetBusSendLevel(string bus_name, float level)
		{
		}

		public void SetSubAudioBusSendLevel(string bus_name, float volume)
		{
		}

		public void SetExtraAudioBusSendLevel(string bus_name, float volume)
		{
		}

		public void SetSubtitleChannel(int channel)
		{
		}

		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback)
		{
		}

		public long GetTime()
		{
			return default(long);
		}

		public int GetDisplayedFrameNo()
		{
			return default(int);
		}

		public void SetAsrRackId(int asrRackId)
		{
		}

		public void Update()
		{
		}

		public void OnWillRenderObject(CriManaMovieMaterial sender)
		{
		}

		public bool UpdateMaterial(Material material)
		{
			return default(bool);
		}

		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction)
		{
		}

		private void Dispose(bool disposing)
		{
		}

		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy)
		{
			return null;
		}

		private void DisableInfos()
		{
		}

		private void PrepareNativePlayer()
		{
		}

		private void UpdateNativePlayer()
		{
		}

		private void AllocateSubtitleBuffer(int size)
		{
		}

		private void DeallocateSubtitleBuffer()
		{
		}

		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, [In] ref EventPoint eventPoint)
		{
		}

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

		private static extern void CRIWARE5E90CA71(int player_id, [Out] MovieInfo movie_info);

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
