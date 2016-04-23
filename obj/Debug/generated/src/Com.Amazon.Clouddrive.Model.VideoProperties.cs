using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/VideoProperties", DoNotGenerateAcw=true)]
	public partial class VideoProperties : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/VideoProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoProperties); }
		}

		protected VideoProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/constructor[@name='VideoProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getAudioBitrate;
#pragma warning disable 0169
		static Delegate GetGetAudioBitrateHandler ()
		{
			if (cb_getAudioBitrate == null)
				cb_getAudioBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioBitrate);
			return cb_getAudioBitrate;
		}

		static IntPtr n_GetAudioBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioBitrate);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioBitrate_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetAudioBitrate_Ljava_lang_Double_Handler ()
		{
			if (cb_setAudioBitrate_Ljava_lang_Double_ == null)
				cb_setAudioBitrate_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioBitrate_Ljava_lang_Double_);
			return cb_setAudioBitrate_Ljava_lang_Double_;
		}

		static void n_SetAudioBitrate_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioBitrate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioBitrate;
		static IntPtr id_setAudioBitrate_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double AudioBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getAudioBitrate' and count(parameter)=0]"
			[Register ("getAudioBitrate", "()Ljava/lang/Double;", "GetGetAudioBitrateHandler")]
			get {
				if (id_getAudioBitrate == IntPtr.Zero)
					id_getAudioBitrate = JNIEnv.GetMethodID (class_ref, "getAudioBitrate", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getAudioBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioBitrate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setAudioBitrate' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setAudioBitrate", "(Ljava/lang/Double;)V", "GetSetAudioBitrate_Ljava_lang_Double_Handler")]
			set {
				if (id_setAudioBitrate_Ljava_lang_Double_ == IntPtr.Zero)
					id_setAudioBitrate_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setAudioBitrate", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAudioBitrate_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioBitrate", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioChannelLayout;
#pragma warning disable 0169
		static Delegate GetGetAudioChannelLayoutHandler ()
		{
			if (cb_getAudioChannelLayout == null)
				cb_getAudioChannelLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioChannelLayout);
			return cb_getAudioChannelLayout;
		}

		static IntPtr n_GetAudioChannelLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioChannelLayout);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioChannelLayout_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAudioChannelLayout_Ljava_lang_String_Handler ()
		{
			if (cb_setAudioChannelLayout_Ljava_lang_String_ == null)
				cb_setAudioChannelLayout_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioChannelLayout_Ljava_lang_String_);
			return cb_setAudioChannelLayout_Ljava_lang_String_;
		}

		static void n_SetAudioChannelLayout_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioChannelLayout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioChannelLayout;
		static IntPtr id_setAudioChannelLayout_Ljava_lang_String_;
		public virtual unsafe string AudioChannelLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getAudioChannelLayout' and count(parameter)=0]"
			[Register ("getAudioChannelLayout", "()Ljava/lang/String;", "GetGetAudioChannelLayoutHandler")]
			get {
				if (id_getAudioChannelLayout == IntPtr.Zero)
					id_getAudioChannelLayout = JNIEnv.GetMethodID (class_ref, "getAudioChannelLayout", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAudioChannelLayout), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioChannelLayout", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setAudioChannelLayout' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAudioChannelLayout", "(Ljava/lang/String;)V", "GetSetAudioChannelLayout_Ljava_lang_String_Handler")]
			set {
				if (id_setAudioChannelLayout_Ljava_lang_String_ == IntPtr.Zero)
					id_setAudioChannelLayout_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAudioChannelLayout", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAudioChannelLayout_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioChannelLayout", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAudioChannels;
#pragma warning disable 0169
		static Delegate GetGetAudioChannelsHandler ()
		{
			if (cb_getAudioChannels == null)
				cb_getAudioChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioChannels);
			return cb_getAudioChannels;
		}

		static IntPtr n_GetAudioChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioChannels);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioChannels_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetAudioChannels_Ljava_lang_Integer_Handler ()
		{
			if (cb_setAudioChannels_Ljava_lang_Integer_ == null)
				cb_setAudioChannels_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioChannels_Ljava_lang_Integer_);
			return cb_setAudioChannels_Ljava_lang_Integer_;
		}

		static void n_SetAudioChannels_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioChannels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioChannels;
		static IntPtr id_setAudioChannels_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer AudioChannels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getAudioChannels' and count(parameter)=0]"
			[Register ("getAudioChannels", "()Ljava/lang/Integer;", "GetGetAudioChannelsHandler")]
			get {
				if (id_getAudioChannels == IntPtr.Zero)
					id_getAudioChannels = JNIEnv.GetMethodID (class_ref, "getAudioChannels", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getAudioChannels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioChannels", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setAudioChannels' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setAudioChannels", "(Ljava/lang/Integer;)V", "GetSetAudioChannels_Ljava_lang_Integer_Handler")]
			set {
				if (id_setAudioChannels_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setAudioChannels_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setAudioChannels", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAudioChannels_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioChannels", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioCodec;
#pragma warning disable 0169
		static Delegate GetGetAudioCodecHandler ()
		{
			if (cb_getAudioCodec == null)
				cb_getAudioCodec = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioCodec);
			return cb_getAudioCodec;
		}

		static IntPtr n_GetAudioCodec (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioCodec);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioCodec_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAudioCodec_Ljava_lang_String_Handler ()
		{
			if (cb_setAudioCodec_Ljava_lang_String_ == null)
				cb_setAudioCodec_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioCodec_Ljava_lang_String_);
			return cb_setAudioCodec_Ljava_lang_String_;
		}

		static void n_SetAudioCodec_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioCodec = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioCodec;
		static IntPtr id_setAudioCodec_Ljava_lang_String_;
		public virtual unsafe string AudioCodec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getAudioCodec' and count(parameter)=0]"
			[Register ("getAudioCodec", "()Ljava/lang/String;", "GetGetAudioCodecHandler")]
			get {
				if (id_getAudioCodec == IntPtr.Zero)
					id_getAudioCodec = JNIEnv.GetMethodID (class_ref, "getAudioCodec", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAudioCodec), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioCodec", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setAudioCodec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAudioCodec", "(Ljava/lang/String;)V", "GetSetAudioCodec_Ljava_lang_String_Handler")]
			set {
				if (id_setAudioCodec_Ljava_lang_String_ == IntPtr.Zero)
					id_setAudioCodec_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAudioCodec", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAudioCodec_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioCodec", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAudioSampleRate;
#pragma warning disable 0169
		static Delegate GetGetAudioSampleRateHandler ()
		{
			if (cb_getAudioSampleRate == null)
				cb_getAudioSampleRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioSampleRate);
			return cb_getAudioSampleRate;
		}

		static IntPtr n_GetAudioSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioSampleRate);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioSampleRate_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetAudioSampleRate_Ljava_lang_Double_Handler ()
		{
			if (cb_setAudioSampleRate_Ljava_lang_Double_ == null)
				cb_setAudioSampleRate_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioSampleRate_Ljava_lang_Double_);
			return cb_setAudioSampleRate_Ljava_lang_Double_;
		}

		static void n_SetAudioSampleRate_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioSampleRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioSampleRate;
		static IntPtr id_setAudioSampleRate_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double AudioSampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getAudioSampleRate' and count(parameter)=0]"
			[Register ("getAudioSampleRate", "()Ljava/lang/Double;", "GetGetAudioSampleRateHandler")]
			get {
				if (id_getAudioSampleRate == IntPtr.Zero)
					id_getAudioSampleRate = JNIEnv.GetMethodID (class_ref, "getAudioSampleRate", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getAudioSampleRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioSampleRate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setAudioSampleRate' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setAudioSampleRate", "(Ljava/lang/Double;)V", "GetSetAudioSampleRate_Ljava_lang_Double_Handler")]
			set {
				if (id_setAudioSampleRate_Ljava_lang_Double_ == IntPtr.Zero)
					id_setAudioSampleRate_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setAudioSampleRate", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAudioSampleRate_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioSampleRate", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitrate);
			return cb_getBitrate;
		}

		static IntPtr n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitrate);
		}
#pragma warning restore 0169

		static Delegate cb_setBitrate_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetBitrate_Ljava_lang_Double_Handler ()
		{
			if (cb_setBitrate_Ljava_lang_Double_ == null)
				cb_setBitrate_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitrate_Ljava_lang_Double_);
			return cb_setBitrate_Ljava_lang_Double_;
		}

		static void n_SetBitrate_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bitrate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		static IntPtr id_setBitrate_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()Ljava/lang/Double;", "GetGetBitrateHandler")]
			get {
				if (id_getBitrate == IntPtr.Zero)
					id_getBitrate = JNIEnv.GetMethodID (class_ref, "getBitrate", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitrate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setBitrate' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setBitrate", "(Ljava/lang/Double;)V", "GetSetBitrate_Ljava_lang_Double_Handler")]
			set {
				if (id_setBitrate_Ljava_lang_Double_ == IntPtr.Zero)
					id_setBitrate_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setBitrate", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBitrate_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitrate", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCreationDate;
#pragma warning disable 0169
		static Delegate GetGetCreationDateHandler ()
		{
			if (cb_getCreationDate == null)
				cb_getCreationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreationDate);
			return cb_getCreationDate;
		}

		static IntPtr n_GetCreationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreationDate);
		}
#pragma warning restore 0169

		static Delegate cb_setCreationDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreationDate_Ljava_lang_String_Handler ()
		{
			if (cb_setCreationDate_Ljava_lang_String_ == null)
				cb_setCreationDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreationDate_Ljava_lang_String_);
			return cb_setCreationDate_Ljava_lang_String_;
		}

		static void n_SetCreationDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreationDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreationDate;
		static IntPtr id_setCreationDate_Ljava_lang_String_;
		public virtual unsafe string CreationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getCreationDate' and count(parameter)=0]"
			[Register ("getCreationDate", "()Ljava/lang/String;", "GetGetCreationDateHandler")]
			get {
				if (id_getCreationDate == IntPtr.Zero)
					id_getCreationDate = JNIEnv.GetMethodID (class_ref, "getCreationDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCreationDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreationDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setCreationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreationDate", "(Ljava/lang/String;)V", "GetSetCreationDate_Ljava_lang_String_Handler")]
			set {
				if (id_setCreationDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreationDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreationDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCreationDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreationDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Duration);
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetDuration_Ljava_lang_Double_Handler ()
		{
			if (cb_setDuration_Ljava_lang_Double_ == null)
				cb_setDuration_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDuration_Ljava_lang_Double_);
			return cb_setDuration_Ljava_lang_Double_;
		}

		static void n_SetDuration_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()Ljava/lang/Double;", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getDuration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setDuration", "(Ljava/lang/Double;)V", "GetSetDuration_Ljava_lang_Double_Handler")]
			set {
				if (id_setDuration_Ljava_lang_Double_ == IntPtr.Zero)
					id_setDuration_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setDuration", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDuration_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEncoder;
#pragma warning disable 0169
		static Delegate GetGetEncoderHandler ()
		{
			if (cb_getEncoder == null)
				cb_getEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoder);
			return cb_getEncoder;
		}

		static IntPtr n_GetEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Encoder);
		}
#pragma warning restore 0169

		static Delegate cb_setEncoder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncoder_Ljava_lang_String_Handler ()
		{
			if (cb_setEncoder_Ljava_lang_String_ == null)
				cb_setEncoder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncoder_Ljava_lang_String_);
			return cb_setEncoder_Ljava_lang_String_;
		}

		static void n_SetEncoder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encoder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncoder;
		static IntPtr id_setEncoder_Ljava_lang_String_;
		public virtual unsafe string Encoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getEncoder' and count(parameter)=0]"
			[Register ("getEncoder", "()Ljava/lang/String;", "GetGetEncoderHandler")]
			get {
				if (id_getEncoder == IntPtr.Zero)
					id_getEncoder = JNIEnv.GetMethodID (class_ref, "getEncoder", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEncoder), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoder", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setEncoder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncoder", "(Ljava/lang/String;)V", "GetSetEncoder_Ljava_lang_String_Handler")]
			set {
				if (id_setEncoder_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncoder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncoder", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEncoder_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncoder", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Ljava_lang_Integer_Handler ()
		{
			if (cb_setHeight_Ljava_lang_Integer_ == null)
				cb_setHeight_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeight_Ljava_lang_Integer_);
			return cb_setHeight_Ljava_lang_Integer_;
		}

		static void n_SetHeight_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()Ljava/lang/Integer;", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setHeight", "(Ljava/lang/Integer;)V", "GetSetHeight_Ljava_lang_Integer_Handler")]
			set {
				if (id_setHeight_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setHeight_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setHeight", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeight_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Ljava_lang_String_Handler ()
		{
			if (cb_setLocation_Ljava_lang_String_ == null)
				cb_setLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Ljava_lang_String_);
			return cb_setLocation_Ljava_lang_String_;
		}

		static void n_SetLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Ljava_lang_String_;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocation", "(Ljava/lang/String;)V", "GetSetLocation_Ljava_lang_String_Handler")]
			set {
				if (id_setLocation_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLocation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMake;
#pragma warning disable 0169
		static Delegate GetGetMakeHandler ()
		{
			if (cb_getMake == null)
				cb_getMake = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMake);
			return cb_getMake;
		}

		static IntPtr n_GetMake (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Make);
		}
#pragma warning restore 0169

		static Delegate cb_setMake_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMake_Ljava_lang_String_Handler ()
		{
			if (cb_setMake_Ljava_lang_String_ == null)
				cb_setMake_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMake_Ljava_lang_String_);
			return cb_setMake_Ljava_lang_String_;
		}

		static void n_SetMake_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Make = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMake;
		static IntPtr id_setMake_Ljava_lang_String_;
		public virtual unsafe string Make {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getMake' and count(parameter)=0]"
			[Register ("getMake", "()Ljava/lang/String;", "GetGetMakeHandler")]
			get {
				if (id_getMake == IntPtr.Zero)
					id_getMake = JNIEnv.GetMethodID (class_ref, "getMake", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMake), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMake", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setMake' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMake", "(Ljava/lang/String;)V", "GetSetMake_Ljava_lang_String_Handler")]
			set {
				if (id_setMake_Ljava_lang_String_ == IntPtr.Zero)
					id_setMake_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMake", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMake_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMake", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		static Delegate cb_setModel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModel_Ljava_lang_String_Handler ()
		{
			if (cb_setModel_Ljava_lang_String_ == null)
				cb_setModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModel_Ljava_lang_String_);
			return cb_setModel_Ljava_lang_String_;
		}

		static void n_SetModel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Model = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getModel;
		static IntPtr id_setModel_Ljava_lang_String_;
		public virtual unsafe string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModel", "(Ljava/lang/String;)V", "GetSetModel_Ljava_lang_String_Handler")]
			set {
				if (id_setModel_Ljava_lang_String_ == IntPtr.Zero)
					id_setModel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setModel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRotate;
#pragma warning disable 0169
		static Delegate GetGetRotateHandler ()
		{
			if (cb_getRotate == null)
				cb_getRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotate);
			return cb_getRotate;
		}

		static IntPtr n_GetRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotate);
		}
#pragma warning restore 0169

		static Delegate cb_setRotate_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRotate_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRotate_Ljava_lang_Integer_ == null)
				cb_setRotate_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRotate_Ljava_lang_Integer_);
			return cb_setRotate_Ljava_lang_Integer_;
		}

		static void n_SetRotate_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Rotate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRotate;
		static IntPtr id_setRotate_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()Ljava/lang/Integer;", "GetGetRotateHandler")]
			get {
				if (id_getRotate == IntPtr.Zero)
					id_getRotate = JNIEnv.GetMethodID (class_ref, "getRotate", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getRotate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotate", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRotate", "(Ljava/lang/Integer;)V", "GetSetRotate_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRotate_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRotate_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRotate", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRotate_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotate", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVideoBitrate;
#pragma warning disable 0169
		static Delegate GetGetVideoBitrateHandler ()
		{
			if (cb_getVideoBitrate == null)
				cb_getVideoBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoBitrate);
			return cb_getVideoBitrate;
		}

		static IntPtr n_GetVideoBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoBitrate);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoBitrate_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetVideoBitrate_Ljava_lang_Double_Handler ()
		{
			if (cb_setVideoBitrate_Ljava_lang_Double_ == null)
				cb_setVideoBitrate_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoBitrate_Ljava_lang_Double_);
			return cb_setVideoBitrate_Ljava_lang_Double_;
		}

		static void n_SetVideoBitrate_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoBitrate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoBitrate;
		static IntPtr id_setVideoBitrate_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double VideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getVideoBitrate' and count(parameter)=0]"
			[Register ("getVideoBitrate", "()Ljava/lang/Double;", "GetGetVideoBitrateHandler")]
			get {
				if (id_getVideoBitrate == IntPtr.Zero)
					id_getVideoBitrate = JNIEnv.GetMethodID (class_ref, "getVideoBitrate", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getVideoBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoBitrate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setVideoBitrate' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setVideoBitrate", "(Ljava/lang/Double;)V", "GetSetVideoBitrate_Ljava_lang_Double_Handler")]
			set {
				if (id_setVideoBitrate_Ljava_lang_Double_ == IntPtr.Zero)
					id_setVideoBitrate_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setVideoBitrate", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVideoBitrate_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoBitrate", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoCodec;
#pragma warning disable 0169
		static Delegate GetGetVideoCodecHandler ()
		{
			if (cb_getVideoCodec == null)
				cb_getVideoCodec = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoCodec);
			return cb_getVideoCodec;
		}

		static IntPtr n_GetVideoCodec (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VideoCodec);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoCodec_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoCodec_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoCodec_Ljava_lang_String_ == null)
				cb_setVideoCodec_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoCodec_Ljava_lang_String_);
			return cb_setVideoCodec_Ljava_lang_String_;
		}

		static void n_SetVideoCodec_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoCodec = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoCodec;
		static IntPtr id_setVideoCodec_Ljava_lang_String_;
		public virtual unsafe string VideoCodec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getVideoCodec' and count(parameter)=0]"
			[Register ("getVideoCodec", "()Ljava/lang/String;", "GetGetVideoCodecHandler")]
			get {
				if (id_getVideoCodec == IntPtr.Zero)
					id_getVideoCodec = JNIEnv.GetMethodID (class_ref, "getVideoCodec", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVideoCodec), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoCodec", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setVideoCodec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVideoCodec", "(Ljava/lang/String;)V", "GetSetVideoCodec_Ljava_lang_String_Handler")]
			set {
				if (id_setVideoCodec_Ljava_lang_String_ == IntPtr.Zero)
					id_setVideoCodec_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideoCodec", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVideoCodec_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoCodec", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVideoFrameRate;
#pragma warning disable 0169
		static Delegate GetGetVideoFrameRateHandler ()
		{
			if (cb_getVideoFrameRate == null)
				cb_getVideoFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoFrameRate);
			return cb_getVideoFrameRate;
		}

		static IntPtr n_GetVideoFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoFrameRate);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoFrameRate_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetVideoFrameRate_Ljava_lang_Double_Handler ()
		{
			if (cb_setVideoFrameRate_Ljava_lang_Double_ == null)
				cb_setVideoFrameRate_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoFrameRate_Ljava_lang_Double_);
			return cb_setVideoFrameRate_Ljava_lang_Double_;
		}

		static void n_SetVideoFrameRate_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoFrameRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoFrameRate;
		static IntPtr id_setVideoFrameRate_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double VideoFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getVideoFrameRate' and count(parameter)=0]"
			[Register ("getVideoFrameRate", "()Ljava/lang/Double;", "GetGetVideoFrameRateHandler")]
			get {
				if (id_getVideoFrameRate == IntPtr.Zero)
					id_getVideoFrameRate = JNIEnv.GetMethodID (class_ref, "getVideoFrameRate", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getVideoFrameRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoFrameRate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setVideoFrameRate' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setVideoFrameRate", "(Ljava/lang/Double;)V", "GetSetVideoFrameRate_Ljava_lang_Double_Handler")]
			set {
				if (id_setVideoFrameRate_Ljava_lang_Double_ == IntPtr.Zero)
					id_setVideoFrameRate_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setVideoFrameRate", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVideoFrameRate_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoFrameRate", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWidth);
			return cb_getWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Width);
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetWidth_Ljava_lang_Integer_Handler ()
		{
			if (cb_setWidth_Ljava_lang_Integer_ == null)
				cb_setWidth_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWidth_Ljava_lang_Integer_);
			return cb_setWidth_Ljava_lang_Integer_;
		}

		static void n_SetWidth_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()Ljava/lang/Integer;", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getWidth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setWidth", "(Ljava/lang/Integer;)V", "GetSetWidth_Ljava_lang_Integer_Handler")]
			set {
				if (id_setWidth_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setWidth_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setWidth", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWidth_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_VideoProperties_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_VideoProperties_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_VideoProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.VideoProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.VideoProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='VideoProperties']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.VideoProperties']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/VideoProperties;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_VideoProperties_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.VideoProperties p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/VideoProperties;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_VideoProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/VideoProperties;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
