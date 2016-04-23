using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Serializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='CreateNodeResponseSerializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/CreateNodeResponseSerializer", DoNotGenerateAcw=true)]
	public partial class CreateNodeResponseSerializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='CreateNodeResponseSerializer.CreateNodeResponseFieldSerializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/serializer/CreateNodeResponseSerializer$CreateNodeResponseFieldSerializer", DoNotGenerateAcw=true)]
		public partial class CreateNodeResponseFieldSerializer : global::Com.Amazon.Clouddrive.Model.Serializer.NodeSerializer.NodeFieldSerializer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/model/serializer/CreateNodeResponseSerializer$CreateNodeResponseFieldSerializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CreateNodeResponseFieldSerializer); }
			}

			protected CreateNodeResponseFieldSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model.serializer']/class[@name='CreateNodeResponseSerializer.CreateNodeResponseFieldSerializer']/constructor[@name='CreateNodeResponseSerializer.CreateNodeResponseFieldSerializer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CreateNodeResponseFieldSerializer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CreateNodeResponseFieldSerializer)) {
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

		protected CreateNodeResponseSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
