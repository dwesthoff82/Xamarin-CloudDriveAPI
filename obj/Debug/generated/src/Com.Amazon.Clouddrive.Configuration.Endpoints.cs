using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='Endpoints']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/configuration/Endpoints", DoNotGenerateAcw=true)]
	public partial class Endpoints : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/configuration/Endpoints", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Endpoints); }
		}

		protected Endpoints (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='Endpoints']/constructor[@name='Endpoints' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Endpoints (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Endpoints)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getContentEndpoint;
#pragma warning disable 0169
		static Delegate GetGetContentEndpointHandler ()
		{
			if (cb_getContentEndpoint == null)
				cb_getContentEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentEndpoint);
			return cb_getContentEndpoint;
		}

		static IntPtr n_GetContentEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.Endpoints __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getContentEndpoint;
		public virtual unsafe string ContentEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='Endpoints']/method[@name='getContentEndpoint' and count(parameter)=0]"
			[Register ("getContentEndpoint", "()Ljava/lang/String;", "GetGetContentEndpointHandler")]
			get {
				if (id_getContentEndpoint == IntPtr.Zero)
					id_getContentEndpoint = JNIEnv.GetMethodID (class_ref, "getContentEndpoint", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentEndpoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMetaDataEndpoint;
#pragma warning disable 0169
		static Delegate GetGetMetaDataEndpointHandler ()
		{
			if (cb_getMetaDataEndpoint == null)
				cb_getMetaDataEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetaDataEndpoint);
			return cb_getMetaDataEndpoint;
		}

		static IntPtr n_GetMetaDataEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.Endpoints __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MetaDataEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getMetaDataEndpoint;
		public virtual unsafe string MetaDataEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='Endpoints']/method[@name='getMetaDataEndpoint' and count(parameter)=0]"
			[Register ("getMetaDataEndpoint", "()Ljava/lang/String;", "GetGetMetaDataEndpointHandler")]
			get {
				if (id_getMetaDataEndpoint == IntPtr.Zero)
					id_getMetaDataEndpoint = JNIEnv.GetMethodID (class_ref, "getMetaDataEndpoint", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMetaDataEndpoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetaDataEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
