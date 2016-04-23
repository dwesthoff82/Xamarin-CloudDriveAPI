using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='Closer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/utils/Closer", DoNotGenerateAcw=true)]
	public partial class Closer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/internal/utils/Closer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Closer); }
		}

		protected Closer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='Closer']/constructor[@name='Closer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Closer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Closer)) {
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

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal.utils']/class[@name='Closer']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable p0)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

	}
}
