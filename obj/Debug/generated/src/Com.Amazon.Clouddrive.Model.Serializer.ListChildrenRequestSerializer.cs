using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Serializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='ListChildrenRequestSerializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/ListChildrenRequestSerializer", DoNotGenerateAcw=true)]
	public partial class ListChildrenRequestSerializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='ListChildrenRequestSerializer.ListChildrenRequestFieldSerializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/ListChildrenRequestSerializer$ListChildrenRequestFieldSerializer", DoNotGenerateAcw=true)]
		public partial class ListChildrenRequestFieldSerializer : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/model/serializer/ListChildrenRequestSerializer$ListChildrenRequestFieldSerializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListChildrenRequestFieldSerializer); }
			}

			protected ListChildrenRequestFieldSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='ListChildrenRequestSerializer.ListChildrenRequestFieldSerializer']/constructor[@name='ListChildrenRequestSerializer.ListChildrenRequestFieldSerializer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ListChildrenRequestFieldSerializer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ListChildrenRequestFieldSerializer)) {
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

		protected ListChildrenRequestSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
