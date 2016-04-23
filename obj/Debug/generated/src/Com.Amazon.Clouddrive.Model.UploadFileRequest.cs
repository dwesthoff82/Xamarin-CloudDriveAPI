using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/UploadFileRequest", DoNotGenerateAcw=true)]
	public partial class UploadFileRequest : global::Com.Amazon.Clouddrive.Model.PostNodeRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/UploadFileRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadFileRequest); }
		}

		protected UploadFileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_io_InputStream_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/constructor[@name='UploadFileRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/io/InputStream;J)V", "")]
		public unsafe UploadFileRequest (string p0, global::System.IO.Stream p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UploadFileRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/io/InputStream;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/io/InputStream;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_io_InputStream_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_io_InputStream_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_io_InputStream_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_io_InputStream_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBlockSize;
#pragma warning disable 0169
		static Delegate GetGetBlockSizeHandler ()
		{
			if (cb_getBlockSize == null)
				cb_getBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlockSize);
			return cb_getBlockSize;
		}

		static int n_GetBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static Delegate cb_setBlockSize_I;
#pragma warning disable 0169
		static Delegate GetSetBlockSize_IHandler ()
		{
			if (cb_setBlockSize_I == null)
				cb_setBlockSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlockSize_I);
			return cb_setBlockSize_I;
		}

		static void n_SetBlockSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		static IntPtr id_setBlockSize_I;
		public virtual unsafe int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler")]
			get {
				if (id_getBlockSize == IntPtr.Zero)
					id_getBlockSize = JNIEnv.GetMethodID (class_ref, "getBlockSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBlockSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlockSize", "(I)V", "GetSetBlockSize_IHandler")]
			set {
				if (id_setBlockSize_I == IntPtr.Zero)
					id_setBlockSize_I = JNIEnv.GetMethodID (class_ref, "setBlockSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBlockSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChunkSize;
#pragma warning disable 0169
		static Delegate GetGetChunkSizeHandler ()
		{
			if (cb_getChunkSize == null)
				cb_getChunkSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChunkSize);
			return cb_getChunkSize;
		}

		static int n_GetChunkSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChunkSize;
		}
#pragma warning restore 0169

		static Delegate cb_setChunkSize_I;
#pragma warning disable 0169
		static Delegate GetSetChunkSize_IHandler ()
		{
			if (cb_setChunkSize_I == null)
				cb_setChunkSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChunkSize_I);
			return cb_setChunkSize_I;
		}

		static void n_SetChunkSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChunkSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChunkSize;
		static IntPtr id_setChunkSize_I;
		public virtual unsafe int ChunkSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getChunkSize' and count(parameter)=0]"
			[Register ("getChunkSize", "()I", "GetGetChunkSizeHandler")]
			get {
				if (id_getChunkSize == IntPtr.Zero)
					id_getChunkSize = JNIEnv.GetMethodID (class_ref, "getChunkSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChunkSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChunkSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setChunkSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setChunkSize", "(I)V", "GetSetChunkSize_IHandler")]
			set {
				if (id_setChunkSize_I == IntPtr.Zero)
					id_setChunkSize_I = JNIEnv.GetMethodID (class_ref, "setChunkSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setChunkSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChunkSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static Delegate cb_setContentLength_J;
#pragma warning disable 0169
		static Delegate GetSetContentLength_JHandler ()
		{
			if (cb_setContentLength_J == null)
				cb_setContentLength_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetContentLength_J);
			return cb_setContentLength_J;
		}

		static void n_SetContentLength_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContentLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentLength;
		static IntPtr id_setContentLength_J;
		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getContentLength);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentLength", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setContentLength' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setContentLength", "(J)V", "GetSetContentLength_JHandler")]
			set {
				if (id_setContentLength_J == IntPtr.Zero)
					id_setContentLength_J = JNIEnv.GetMethodID (class_ref, "setContentLength", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentLength_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentLength", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static Delegate cb_setInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_setInputStream_Ljava_io_InputStream_ == null)
				cb_setInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputStream_Ljava_io_InputStream_);
			return cb_setInputStream_Ljava_io_InputStream_;
		}

		static void n_SetInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputStream = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		static IntPtr id_setInputStream_Ljava_io_InputStream_;
		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("setInputStream", "(Ljava/io/InputStream;)V", "GetSetInputStream_Ljava_io_InputStream_Handler")]
			set {
				if (id_setInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
					id_setInputStream_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setInputStream", "(Ljava/io/InputStream;)V");
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInputStream_Ljava_io_InputStream_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputStream", "(Ljava/io/InputStream;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMD5;
#pragma warning disable 0169
		static Delegate GetGetMD5Handler ()
		{
			if (cb_getMD5 == null)
				cb_getMD5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMD5);
			return cb_getMD5;
		}

		static IntPtr n_GetMD5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MD5);
		}
#pragma warning restore 0169

		static Delegate cb_setMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setMD5_Ljava_lang_String_ == null)
				cb_setMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMD5_Ljava_lang_String_);
			return cb_setMD5_Ljava_lang_String_;
		}

		static void n_SetMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MD5 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMD5;
		static IntPtr id_setMD5_Ljava_lang_String_;
		public virtual unsafe string MD5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getMD5' and count(parameter)=0]"
			[Register ("getMD5", "()Ljava/lang/String;", "GetGetMD5Handler")]
			get {
				if (id_getMD5 == IntPtr.Zero)
					id_getMD5 = JNIEnv.GetMethodID (class_ref, "getMD5", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMD5), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMD5", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMD5", "(Ljava/lang/String;)V", "GetSetMD5_Ljava_lang_String_Handler")]
			set {
				if (id_setMD5_Ljava_lang_String_ == IntPtr.Zero)
					id_setMD5_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMD5", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMD5_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMD5", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSuppress;
#pragma warning disable 0169
		static Delegate GetGetSuppressHandler ()
		{
			if (cb_getSuppress == null)
				cb_getSuppress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuppress);
			return cb_getSuppress;
		}

		static IntPtr n_GetSuppress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Suppress);
		}
#pragma warning restore 0169

		static IntPtr id_getSuppress;
		public virtual unsafe string Suppress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='getSuppress' and count(parameter)=0]"
			[Register ("getSuppress", "()Ljava/lang/String;", "GetGetSuppressHandler")]
			get {
				if (id_getSuppress == IntPtr.Zero)
					id_getSuppress = JNIEnv.GetMethodID (class_ref, "getSuppress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSuppress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuppress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setChunkedStreaming_Z;
#pragma warning disable 0169
		static Delegate GetSetChunkedStreaming_ZHandler ()
		{
			if (cb_setChunkedStreaming_Z == null)
				cb_setChunkedStreaming_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetChunkedStreaming_Z);
			return cb_setChunkedStreaming_Z;
		}

		static void n_SetChunkedStreaming_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChunkedStreaming (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChunkedStreaming_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setChunkedStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChunkedStreaming", "(Z)V", "GetSetChunkedStreaming_ZHandler")]
		public virtual unsafe void SetChunkedStreaming (bool p0)
		{
			if (id_setChunkedStreaming_Z == IntPtr.Zero)
				id_setChunkedStreaming_Z = JNIEnv.GetMethodID (class_ref, "setChunkedStreaming", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChunkedStreaming_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChunkedStreaming", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSuppress_Lcom_amazon_clouddrive_model_Suppress_;
#pragma warning disable 0169
		static Delegate GetSetSuppress_Lcom_amazon_clouddrive_model_Suppress_Handler ()
		{
			if (cb_setSuppress_Lcom_amazon_clouddrive_model_Suppress_ == null)
				cb_setSuppress_Lcom_amazon_clouddrive_model_Suppress_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuppress_Lcom_amazon_clouddrive_model_Suppress_);
			return cb_setSuppress_Lcom_amazon_clouddrive_model_Suppress_;
		}

		static void n_SetSuppress_Lcom_amazon_clouddrive_model_Suppress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.Suppress p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Suppress> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSuppress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSuppress_Lcom_amazon_clouddrive_model_Suppress_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='setSuppress' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.Suppress']]"
		[Register ("setSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)V", "GetSetSuppress_Lcom_amazon_clouddrive_model_Suppress_Handler")]
		public virtual unsafe void SetSuppress (global::Com.Amazon.Clouddrive.Model.Suppress p0)
		{
			if (id_setSuppress_Lcom_amazon_clouddrive_model_Suppress_ == IntPtr.Zero)
				id_setSuppress_Lcom_amazon_clouddrive_model_Suppress_ = JNIEnv.GetMethodID (class_ref, "setSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSuppress_Lcom_amazon_clouddrive_model_Suppress_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_useChunkedStreaming;
#pragma warning disable 0169
		static Delegate GetUseChunkedStreamingHandler ()
		{
			if (cb_useChunkedStreaming == null)
				cb_useChunkedStreaming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseChunkedStreaming);
			return cb_useChunkedStreaming;
		}

		static bool n_UseChunkedStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseChunkedStreaming ();
		}
#pragma warning restore 0169

		static IntPtr id_useChunkedStreaming;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='useChunkedStreaming' and count(parameter)=0]"
		[Register ("useChunkedStreaming", "()Z", "GetUseChunkedStreamingHandler")]
		public virtual unsafe bool UseChunkedStreaming ()
		{
			if (id_useChunkedStreaming == IntPtr.Zero)
				id_useChunkedStreaming = JNIEnv.GetMethodID (class_ref, "useChunkedStreaming", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_useChunkedStreaming);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useChunkedStreaming", "()Z"));
			} finally {
			}
		}

		static Delegate cb_withBlockSize_I;
#pragma warning disable 0169
		static Delegate GetWithBlockSize_IHandler ()
		{
			if (cb_withBlockSize_I == null)
				cb_withBlockSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithBlockSize_I);
			return cb_withBlockSize_I;
		}

		static IntPtr n_WithBlockSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBlockSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withBlockSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withBlockSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithBlockSize_IHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithBlockSize (int p0)
		{
			if (id_withBlockSize_I == IntPtr.Zero)
				id_withBlockSize_I = JNIEnv.GetMethodID (class_ref, "withBlockSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withBlockSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBlockSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withChunkSize_I;
#pragma warning disable 0169
		static Delegate GetWithChunkSize_IHandler ()
		{
			if (cb_withChunkSize_I == null)
				cb_withChunkSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithChunkSize_I);
			return cb_withChunkSize_I;
		}

		static IntPtr n_WithChunkSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithChunkSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withChunkSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withChunkSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withChunkSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithChunkSize_IHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithChunkSize (int p0)
		{
			if (id_withChunkSize_I == IntPtr.Zero)
				id_withChunkSize_I = JNIEnv.GetMethodID (class_ref, "withChunkSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withChunkSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChunkSize", "(I)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withChunkedStreaming_Z;
#pragma warning disable 0169
		static Delegate GetWithChunkedStreaming_ZHandler ()
		{
			if (cb_withChunkedStreaming_Z == null)
				cb_withChunkedStreaming_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithChunkedStreaming_Z);
			return cb_withChunkedStreaming_Z;
		}

		static IntPtr n_WithChunkedStreaming_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithChunkedStreaming (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withChunkedStreaming_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withChunkedStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withChunkedStreaming", "(Z)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithChunkedStreaming_ZHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithChunkedStreaming (bool p0)
		{
			if (id_withChunkedStreaming_Z == IntPtr.Zero)
				id_withChunkedStreaming_Z = JNIEnv.GetMethodID (class_ref, "withChunkedStreaming", "(Z)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withChunkedStreaming_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChunkedStreaming", "(Z)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
#pragma warning disable 0169
		static Delegate GetWithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler ()
		{
			if (cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == null)
				cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_);
			return cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		}

		static IntPtr n_WithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithContentProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withContentProperties' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ContentProperties']]"
		[Register ("withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithContentProperties (global::Com.Amazon.Clouddrive.Model.ContentProperties p0)
		{
			if (id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
				id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithDescription_Ljava_lang_String_Handler ()
		{
			if (cb_withDescription_Ljava_lang_String_ == null)
				cb_withDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDescription_Ljava_lang_String_);
			return cb_withDescription_Ljava_lang_String_;
		}

		static IntPtr n_WithDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDescription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithDescription (string p0)
		{
			if (id_withDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_withDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withDescription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withKind_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithKind_Ljava_lang_String_Handler ()
		{
			if (cb_withKind_Ljava_lang_String_ == null)
				cb_withKind_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithKind_Ljava_lang_String_);
			return cb_withKind_Ljava_lang_String_;
		}

		static IntPtr n_WithKind_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithKind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withKind_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withKind' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithKind_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithKind (string p0)
		{
			if (id_withKind_Ljava_lang_String_ == IntPtr.Zero)
				id_withKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withKind_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLabels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithLabels_Ljava_util_List_Handler ()
		{
			if (cb_withLabels_Ljava_util_List_ == null)
				cb_withLabels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLabels_Ljava_util_List_);
			return cb_withLabels_Ljava_util_List_;
		}

		static IntPtr n_WithLabels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLabels (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLabels_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withLabels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithLabels_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithLabels (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_withLabels_Ljava_util_List_ == IntPtr.Zero)
				id_withLabels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLabels_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLocalId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithLocalId_Ljava_lang_String_Handler ()
		{
			if (cb_withLocalId_Ljava_lang_String_ == null)
				cb_withLocalId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocalId_Ljava_lang_String_);
			return cb_withLocalId_Ljava_lang_String_;
		}

		static IntPtr n_WithLocalId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocalId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLocalId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withLocalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithLocalId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithLocalId (string p0)
		{
			if (id_withLocalId_Ljava_lang_String_ == IntPtr.Zero)
				id_withLocalId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLocalId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithMD5_Ljava_lang_String_Handler ()
		{
			if (cb_withMD5_Ljava_lang_String_ == null)
				cb_withMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMD5_Ljava_lang_String_);
			return cb_withMD5_Ljava_lang_String_;
		}

		static IntPtr n_WithMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMD5 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMD5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withMD5", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithMD5_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithMD5 (string p0)
		{
			if (id_withMD5_Ljava_lang_String_ == IntPtr.Zero)
				id_withMD5_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withMD5", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withMD5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMD5", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withParents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithParents_Ljava_util_List_Handler ()
		{
			if (cb_withParents_Ljava_util_List_ == null)
				cb_withParents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithParents_Ljava_util_List_);
			return cb_withParents_Ljava_util_List_;
		}

		static IntPtr n_WithParents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithParents (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withParents_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withParents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithParents_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithParents (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_withParents_Ljava_util_List_ == IntPtr.Zero)
				id_withParents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withParents_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetWithProperties_Ljava_util_Map_Handler ()
		{
			if (cb_withProperties_Ljava_util_Map_ == null)
				cb_withProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithProperties_Ljava_util_Map_);
			return cb_withProperties_Ljava_util_Map_;
		}

		static IntPtr n_WithProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithProperties_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithProperties (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> p0)
		{
			if (id_withProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_withProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withProperties_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withSuppress_Lcom_amazon_clouddrive_model_Suppress_;
#pragma warning disable 0169
		static Delegate GetWithSuppress_Lcom_amazon_clouddrive_model_Suppress_Handler ()
		{
			if (cb_withSuppress_Lcom_amazon_clouddrive_model_Suppress_ == null)
				cb_withSuppress_Lcom_amazon_clouddrive_model_Suppress_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSuppress_Lcom_amazon_clouddrive_model_Suppress_);
			return cb_withSuppress_Lcom_amazon_clouddrive_model_Suppress_;
		}

		static IntPtr n_WithSuppress_Lcom_amazon_clouddrive_model_Suppress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.Suppress p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Suppress> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSuppress (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSuppress_Lcom_amazon_clouddrive_model_Suppress_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UploadFileRequest']/method[@name='withSuppress' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.Suppress']]"
		[Register ("withSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)Lcom/amazon/clouddrive/model/UploadFileRequest;", "GetWithSuppress_Lcom_amazon_clouddrive_model_Suppress_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileRequest WithSuppress (global::Com.Amazon.Clouddrive.Model.Suppress p0)
		{
			if (id_withSuppress_Lcom_amazon_clouddrive_model_Suppress_ == IntPtr.Zero)
				id_withSuppress_Lcom_amazon_clouddrive_model_Suppress_ = JNIEnv.GetMethodID (class_ref, "withSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)Lcom/amazon/clouddrive/model/UploadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.UploadFileRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withSuppress_Lcom_amazon_clouddrive_model_Suppress_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSuppress", "(Lcom/amazon/clouddrive/model/Suppress;)Lcom/amazon/clouddrive/model/UploadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
