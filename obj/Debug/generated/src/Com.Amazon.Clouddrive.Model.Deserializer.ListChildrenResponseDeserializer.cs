using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListChildrenResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListChildrenResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class ListChildrenResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListChildrenResponseDeserializer.ListChildrenResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListChildrenResponseDeserializer$ListChildrenResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class ListChildrenResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.PaginatedCloudDriveResponseFieldDeserializer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/model/deserializer/ListChildrenResponseDeserializer$ListChildrenResponseFieldDeserializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListChildrenResponseFieldDeserializer); }
			}

			protected ListChildrenResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListChildrenResponseDeserializer.ListChildrenResponseFieldDeserializer']/constructor[@name='ListChildrenResponseDeserializer.ListChildrenResponseFieldDeserializer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ListChildrenResponseFieldDeserializer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ListChildrenResponseFieldDeserializer)) {
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

		protected ListChildrenResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
