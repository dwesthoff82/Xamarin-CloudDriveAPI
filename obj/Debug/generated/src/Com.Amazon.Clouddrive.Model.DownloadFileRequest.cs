using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/DownloadFileRequest", DoNotGenerateAcw=true)]
	public partial class DownloadFileRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/DownloadFileRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadFileRequest); }
		}

		protected DownloadFileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/constructor[@name='DownloadFileRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/io/OutputStream;)V", "")]
		public unsafe DownloadFileRequest (string p0, global::System.IO.Stream p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DownloadFileRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_io_OutputStream_, __args);
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
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		static IntPtr id_setBlockSize_I;
		public virtual unsafe int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='getBlockSize' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='setBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_hasViewBoxSet;
#pragma warning disable 0169
		static Delegate GetHasViewBoxSetHandler ()
		{
			if (cb_hasViewBoxSet == null)
				cb_hasViewBoxSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasViewBoxSet);
			return cb_hasViewBoxSet;
		}

		static bool n_HasViewBoxSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasViewBoxSet;
		}
#pragma warning restore 0169

		static IntPtr id_hasViewBoxSet;
		public virtual unsafe bool HasViewBoxSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='hasViewBoxSet' and count(parameter)=0]"
			[Register ("hasViewBoxSet", "()Z", "GetHasViewBoxSetHandler")]
			get {
				if (id_hasViewBoxSet == IntPtr.Zero)
					id_hasViewBoxSet = JNIEnv.GetMethodID (class_ref, "hasViewBoxSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasViewBoxSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasViewBoxSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getViewBox;
#pragma warning disable 0169
		static Delegate GetGetViewBoxHandler ()
		{
			if (cb_getViewBox == null)
				cb_getViewBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewBox);
			return cb_getViewBox;
		}

		static int n_GetViewBox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewBox;
		}
#pragma warning restore 0169

		static Delegate cb_setViewBox_I;
#pragma warning disable 0169
		static Delegate GetSetViewBox_IHandler ()
		{
			if (cb_setViewBox_I == null)
				cb_setViewBox_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetViewBox_I);
			return cb_setViewBox_I;
		}

		static void n_SetViewBox_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ViewBox = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getViewBox;
		static IntPtr id_setViewBox_I;
		public virtual unsafe int ViewBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='getViewBox' and count(parameter)=0]"
			[Register ("getViewBox", "()I", "GetGetViewBoxHandler")]
			get {
				if (id_getViewBox == IntPtr.Zero)
					id_getViewBox = JNIEnv.GetMethodID (class_ref, "getViewBox", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getViewBox);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewBox", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='setViewBox' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setViewBox", "(I)V", "GetSetViewBox_IHandler")]
			set {
				if (id_setViewBox_I == IntPtr.Zero)
					id_setViewBox_I = JNIEnv.GetMethodID (class_ref, "setViewBox", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setViewBox_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewBox", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I"), __args);
				return __ret;
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
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBlockSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withBlockSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='withBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withBlockSize", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;", "GetWithBlockSize_IHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.DownloadFileRequest WithBlockSize (int p0)
		{
			if (id_withBlockSize_I == IntPtr.Zero)
				id_withBlockSize_I = JNIEnv.GetMethodID (class_ref, "withBlockSize", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withBlockSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBlockSize", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withViewBox_I;
#pragma warning disable 0169
		static Delegate GetWithViewBox_IHandler ()
		{
			if (cb_withViewBox_I == null)
				cb_withViewBox_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithViewBox_I);
			return cb_withViewBox_I;
		}

		static IntPtr n_WithViewBox_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithViewBox (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withViewBox_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DownloadFileRequest']/method[@name='withViewBox' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withViewBox", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;", "GetWithViewBox_IHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.DownloadFileRequest WithViewBox (int p0)
		{
			if (id_withViewBox_I == IntPtr.Zero)
				id_withViewBox_I = JNIEnv.GetMethodID (class_ref, "withViewBox", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (JNIEnv.CallObjectMethod  (Handle, id_withViewBox_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withViewBox", "(I)Lcom/amazon/clouddrive/model/DownloadFileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
