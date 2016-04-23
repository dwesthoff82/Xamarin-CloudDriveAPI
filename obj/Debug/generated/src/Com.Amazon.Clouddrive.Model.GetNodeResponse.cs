using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodeResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetNodeResponse", DoNotGenerateAcw=true)]
	public partial class GetNodeResponse : global::Com.Amazon.Clouddrive.Model.Node {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetNodeResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetNodeResponse); }
		}

		protected GetNodeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodeResponse']/constructor[@name='GetNodeResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetNodeResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetNodeResponse)) {
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
			global::Com.Amazon.Clouddrive.Model.GetNodeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.GetNodeResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Ljava_lang_String_;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodeResponse']/method[@name='getLocation' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodeResponse']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
