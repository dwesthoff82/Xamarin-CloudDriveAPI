using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Serializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='GetNodeRequestSerializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/GetNodeRequestSerializer", DoNotGenerateAcw=true)]
	public partial class GetNodeRequestSerializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='GetNodeRequestSerializer.GetNodeRequestFieldSerializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/GetNodeRequestSerializer$GetNodeRequestFieldSerializer", DoNotGenerateAcw=true)]
		public partial class GetNodeRequestFieldSerializer : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/model/serializer/GetNodeRequestSerializer$GetNodeRequestFieldSerializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetNodeRequestFieldSerializer); }
			}

			protected GetNodeRequestFieldSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='GetNodeRequestSerializer.GetNodeRequestFieldSerializer']/constructor[@name='GetNodeRequestSerializer.GetNodeRequestFieldSerializer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GetNodeRequestFieldSerializer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (GetNodeRequestFieldSerializer)) {
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

		protected GetNodeRequestSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
