using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.exceptions']/class[@name='ResourceNotFound']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/exceptions/ResourceNotFound", DoNotGenerateAcw=true)]
	public partial class ResourceNotFound : global::Com.Amazon.Clouddrive.Exceptions.NoRetryException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/exceptions/ResourceNotFound", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceNotFound); }
		}

		protected ResourceNotFound (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.exceptions']/class[@name='ResourceNotFound']/constructor[@name='ResourceNotFound' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe ResourceNotFound (string p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ResourceNotFound)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.exceptions']/class[@name='ResourceNotFound']/constructor[@name='ResourceNotFound' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ResourceNotFound (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ResourceNotFound)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.exceptions']/class[@name='ResourceNotFound']/constructor[@name='ResourceNotFound' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ResourceNotFound (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ResourceNotFound)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.exceptions']/class[@name='ResourceNotFound']/constructor[@name='ResourceNotFound' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceNotFound ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResourceNotFound)) {
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

	}
}
