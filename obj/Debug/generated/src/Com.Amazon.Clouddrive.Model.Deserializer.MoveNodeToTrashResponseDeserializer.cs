using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='MoveNodeToTrashResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/MoveNodeToTrashResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class MoveNodeToTrashResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='MoveNodeToTrashResponseDeserializer.MoveNodeToTrashResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/MoveNodeToTrashResponseDeserializer$MoveNodeToTrashResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class MoveNodeToTrashResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.NodeDeserializer.NodeFieldDeserializer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/model/deserializer/MoveNodeToTrashResponseDeserializer$MoveNodeToTrashResponseFieldDeserializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoveNodeToTrashResponseFieldDeserializer); }
			}

			protected MoveNodeToTrashResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='MoveNodeToTrashResponseDeserializer.MoveNodeToTrashResponseFieldDeserializer']/constructor[@name='MoveNodeToTrashResponseDeserializer.MoveNodeToTrashResponseFieldDeserializer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MoveNodeToTrashResponseFieldDeserializer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MoveNodeToTrashResponseFieldDeserializer)) {
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

		protected MoveNodeToTrashResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
