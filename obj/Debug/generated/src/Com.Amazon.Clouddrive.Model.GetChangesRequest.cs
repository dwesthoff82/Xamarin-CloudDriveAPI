using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetChangesRequest", DoNotGenerateAcw=true)]
	public partial class GetChangesRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetChangesRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetChangesRequest); }
		}

		protected GetChangesRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/constructor[@name='GetChangesRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetChangesRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetChangesRequest)) {
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
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Checkpoint = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckpoint;
		static IntPtr id_setCheckpoint_Ljava_lang_String_;
		public virtual unsafe string Checkpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='getCheckpoint' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='setCheckpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getChunkSize;
#pragma warning disable 0169
		static Delegate GetGetChunkSizeHandler ()
		{
			if (cb_getChunkSize == null)
				cb_getChunkSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChunkSize);
			return cb_getChunkSize;
		}

		static IntPtr n_GetChunkSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChunkSize);
		}
#pragma warning restore 0169

		static Delegate cb_setChunkSize_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetChunkSize_Ljava_lang_Integer_Handler ()
		{
			if (cb_setChunkSize_Ljava_lang_Integer_ == null)
				cb_setChunkSize_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChunkSize_Ljava_lang_Integer_);
			return cb_setChunkSize_Ljava_lang_Integer_;
		}

		static void n_SetChunkSize_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChunkSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChunkSize;
		static IntPtr id_setChunkSize_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ChunkSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='getChunkSize' and count(parameter)=0]"
			[Register ("getChunkSize", "()Ljava/lang/Integer;", "GetGetChunkSizeHandler")]
			get {
				if (id_getChunkSize == IntPtr.Zero)
					id_getChunkSize = JNIEnv.GetMethodID (class_ref, "getChunkSize", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getChunkSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChunkSize", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='setChunkSize' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setChunkSize", "(Ljava/lang/Integer;)V", "GetSetChunkSize_Ljava_lang_Integer_Handler")]
			set {
				if (id_setChunkSize_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setChunkSize_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setChunkSize", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setChunkSize_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChunkSize", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIncludePurged;
#pragma warning disable 0169
		static Delegate GetGetIncludePurgedHandler ()
		{
			if (cb_getIncludePurged == null)
				cb_getIncludePurged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIncludePurged);
			return cb_getIncludePurged;
		}

		static IntPtr n_GetIncludePurged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IncludePurged);
		}
#pragma warning restore 0169

		static Delegate cb_setIncludePurged_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIncludePurged_Ljava_lang_String_Handler ()
		{
			if (cb_setIncludePurged_Ljava_lang_String_ == null)
				cb_setIncludePurged_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIncludePurged_Ljava_lang_String_);
			return cb_setIncludePurged_Ljava_lang_String_;
		}

		static void n_SetIncludePurged_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IncludePurged = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIncludePurged;
		static IntPtr id_setIncludePurged_Ljava_lang_String_;
		public virtual unsafe string IncludePurged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='getIncludePurged' and count(parameter)=0]"
			[Register ("getIncludePurged", "()Ljava/lang/String;", "GetGetIncludePurgedHandler")]
			get {
				if (id_getIncludePurged == IntPtr.Zero)
					id_getIncludePurged = JNIEnv.GetMethodID (class_ref, "getIncludePurged", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIncludePurged), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIncludePurged", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='setIncludePurged' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIncludePurged", "(Ljava/lang/String;)V", "GetSetIncludePurged_Ljava_lang_String_Handler")]
			set {
				if (id_setIncludePurged_Ljava_lang_String_ == IntPtr.Zero)
					id_setIncludePurged_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIncludePurged", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIncludePurged_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIncludePurged", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimit);
			return cb_getLimit;
		}

		static IntPtr n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit);
		}
#pragma warning restore 0169

		static Delegate cb_setLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_setLimit_Ljava_lang_Integer_ == null)
				cb_setLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLimit_Ljava_lang_Integer_);
			return cb_setLimit_Ljava_lang_Integer_;
		}

		static void n_SetLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Limit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLimit;
		static IntPtr id_setLimit_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()Ljava/lang/Integer;", "GetGetLimitHandler")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getLimit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimit", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setLimit", "(Ljava/lang/Integer;)V", "GetSetLimit_Ljava_lang_Integer_Handler")]
			set {
				if (id_setLimit_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setLimit", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLimit_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimit", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxNodes;
#pragma warning disable 0169
		static Delegate GetGetMaxNodesHandler ()
		{
			if (cb_getMaxNodes == null)
				cb_getMaxNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaxNodes);
			return cb_getMaxNodes;
		}

		static IntPtr n_GetMaxNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxNodes);
		}
#pragma warning restore 0169

		static Delegate cb_setMaxNodes_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMaxNodes_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMaxNodes_Ljava_lang_Integer_ == null)
				cb_setMaxNodes_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaxNodes_Ljava_lang_Integer_);
			return cb_setMaxNodes_Ljava_lang_Integer_;
		}

		static void n_SetMaxNodes_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaxNodes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxNodes;
		static IntPtr id_setMaxNodes_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer MaxNodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='getMaxNodes' and count(parameter)=0]"
			[Register ("getMaxNodes", "()Ljava/lang/Integer;", "GetGetMaxNodesHandler")]
			get {
				if (id_getMaxNodes == IntPtr.Zero)
					id_getMaxNodes = JNIEnv.GetMethodID (class_ref, "getMaxNodes", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getMaxNodes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxNodes", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='setMaxNodes' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMaxNodes", "(Ljava/lang/Integer;)V", "GetSetMaxNodes_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMaxNodes_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMaxNodes_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMaxNodes", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxNodes_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxNodes", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withCheckpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithCheckpoint_Ljava_lang_String_Handler ()
		{
			if (cb_withCheckpoint_Ljava_lang_String_ == null)
				cb_withCheckpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCheckpoint_Ljava_lang_String_);
			return cb_withCheckpoint_Ljava_lang_String_;
		}

		static IntPtr n_WithCheckpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCheckpoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCheckpoint_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='withCheckpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withCheckpoint", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;", "GetWithCheckpoint_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesRequest WithCheckpoint (string p0)
		{
			if (id_withCheckpoint_Ljava_lang_String_ == IntPtr.Zero)
				id_withCheckpoint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withCheckpoint", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallObjectMethod  (Handle, id_withCheckpoint_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCheckpoint", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withChunkSize_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithChunkSize_Ljava_lang_Integer_Handler ()
		{
			if (cb_withChunkSize_Ljava_lang_Integer_ == null)
				cb_withChunkSize_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithChunkSize_Ljava_lang_Integer_);
			return cb_withChunkSize_Ljava_lang_Integer_;
		}

		static IntPtr n_WithChunkSize_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithChunkSize (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withChunkSize_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='withChunkSize' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withChunkSize", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;", "GetWithChunkSize_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesRequest WithChunkSize (global::Java.Lang.Integer p0)
		{
			if (id_withChunkSize_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withChunkSize_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withChunkSize", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallObjectMethod  (Handle, id_withChunkSize_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChunkSize", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIncludePurged_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithIncludePurged_Ljava_lang_String_Handler ()
		{
			if (cb_withIncludePurged_Ljava_lang_String_ == null)
				cb_withIncludePurged_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIncludePurged_Ljava_lang_String_);
			return cb_withIncludePurged_Ljava_lang_String_;
		}

		static IntPtr n_WithIncludePurged_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIncludePurged (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIncludePurged_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='withIncludePurged' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withIncludePurged", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;", "GetWithIncludePurged_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesRequest WithIncludePurged (string p0)
		{
			if (id_withIncludePurged_Ljava_lang_String_ == IntPtr.Zero)
				id_withIncludePurged_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIncludePurged", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallObjectMethod  (Handle, id_withIncludePurged_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIncludePurged", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/GetChangesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_withLimit_Ljava_lang_Integer_ == null)
				cb_withLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLimit_Ljava_lang_Integer_);
			return cb_withLimit_Ljava_lang_Integer_;
		}

		static IntPtr n_WithLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLimit (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLimit_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='withLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;", "GetWithLimit_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesRequest WithLimit (global::Java.Lang.Integer p0)
		{
			if (id_withLimit_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLimit_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMaxNodes_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithMaxNodes_Ljava_lang_Integer_Handler ()
		{
			if (cb_withMaxNodes_Ljava_lang_Integer_ == null)
				cb_withMaxNodes_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMaxNodes_Ljava_lang_Integer_);
			return cb_withMaxNodes_Ljava_lang_Integer_;
		}

		static IntPtr n_WithMaxNodes_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMaxNodes (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMaxNodes_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetChangesRequest']/method[@name='withMaxNodes' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withMaxNodes", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;", "GetWithMaxNodes_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesRequest WithMaxNodes (global::Java.Lang.Integer p0)
		{
			if (id_withMaxNodes_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withMaxNodes_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withMaxNodes", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallObjectMethod  (Handle, id_withMaxNodes_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMaxNodes", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/GetChangesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
