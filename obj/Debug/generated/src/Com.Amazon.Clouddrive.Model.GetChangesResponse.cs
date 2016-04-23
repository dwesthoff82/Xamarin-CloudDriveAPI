using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetChangesResponse", DoNotGenerateAcw=true)]
	public partial class GetChangesResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.IGetChangesResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetChangesResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetChangesResponse); }
		}

		protected GetChangesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/constructor[@name='GetChangesResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetChangesResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetChangesResponse)) {
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

		static Delegate cb_getCheckpoint;
#pragma warning disable 0169
		static Delegate GetGetCheckpointHandler ()
		{
			if (cb_getCheckpoint == null)
				cb_getCheckpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckpoint);
			return cb_getCheckpoint;
		}

		static IntPtr n_GetCheckpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Checkpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setCheckpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCheckpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setCheckpoint_Ljava_lang_String_ == null)
				cb_setCheckpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCheckpoint_Ljava_lang_String_);
			return cb_setCheckpoint_Ljava_lang_String_;
		}

		static void n_SetCheckpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Checkpoint = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckpoint;
		static IntPtr id_setCheckpoint_Ljava_lang_String_;
		public virtual unsafe string Checkpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='getCheckpoint' and count(parameter)=0]"
			[Register ("getCheckpoint", "()Ljava/lang/String;", "GetGetCheckpointHandler")]
			get {
				if (id_getCheckpoint == IntPtr.Zero)
					id_getCheckpoint = JNIEnv.GetMethodID (class_ref, "getCheckpoint", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCheckpoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='setCheckpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCheckpoint", "(Ljava/lang/String;)V", "GetSetCheckpoint_Ljava_lang_String_Handler")]
			set {
				if (id_setCheckpoint_Ljava_lang_String_ == IntPtr.Zero)
					id_setCheckpoint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCheckpoint", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCheckpoint_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCheckpoint", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isReset;
#pragma warning disable 0169
		static Delegate GetIsResetHandler ()
		{
			if (cb_isReset == null)
				cb_isReset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReset);
			return cb_isReset;
		}

		static bool n_IsReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Reset;
		}
#pragma warning restore 0169

		static Delegate cb_setReset_Z;
#pragma warning disable 0169
		static Delegate GetSetReset_ZHandler ()
		{
			if (cb_setReset_Z == null)
				cb_setReset_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReset_Z);
			return cb_setReset_Z;
		}

		static void n_SetReset_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isReset;
		static IntPtr id_setReset_Z;
		public virtual unsafe bool Reset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='isReset' and count(parameter)=0]"
			[Register ("isReset", "()Z", "GetIsResetHandler")]
			get {
				if (id_isReset == IntPtr.Zero)
					id_isReset = JNIEnv.GetMethodID (class_ref, "isReset", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReset);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReset", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='setReset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReset", "(Z)V", "GetSetReset_ZHandler")]
			set {
				if (id_setReset_Z == IntPtr.Zero)
					id_setReset_Z = JNIEnv.GetMethodID (class_ref, "setReset", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReset_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReset", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getNodes;
#pragma warning disable 0169
		static Delegate Get_getNodesHandler ()
		{
			if (cb_getNodes == null)
				cb_getNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n__getNodes);
			return cb_getNodes;
		}

		static IntPtr n__getNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (__this._getNodes ());
		}
#pragma warning restore 0169

		static IntPtr id_getNodes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='getNodes' and count(parameter)=0]"
		[Register ("getNodes", "()Ljava/util/List;", "Get_getNodesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> _getNodes ()
		{
			if (id_getNodes == IntPtr.Zero)
				id_getNodes = JNIEnv.GetMethodID (class_ref, "getNodes", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNodes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNodes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetNodes_Ljava_util_List_Handler ()
		{
			if (cb_setNodes_Ljava_util_List_ == null)
				cb_setNodes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNodes_Ljava_util_List_);
			return cb_setNodes_Ljava_util_List_;
		}

		static void n_SetNodes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNodes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNodes_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesResponse']/method[@name='setNodes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amazon.clouddrive.model.Node&gt;']]"
		[Register ("setNodes", "(Ljava/util/List;)V", "GetSetNodes_Ljava_util_List_Handler")]
		public virtual unsafe void SetNodes (global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> p0)
		{
			if (id_setNodes_Ljava_util_List_ == IntPtr.Zero)
				id_setNodes_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setNodes", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNodes_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNodes", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
