using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/metrics/MetricEvent", DoNotGenerateAcw=true)]
	public partial class MetricEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/metrics/MetricEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetricEvent); }
		}

		protected MetricEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JILcom_amazon_clouddrive_exceptions_CloudDriveException_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/constructor[@name='MetricEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='com.amazon.clouddrive.exceptions.CloudDriveException']]"
		[Register (".ctor", "(Ljava/lang/String;JILcom/amazon/clouddrive/exceptions/CloudDriveException;)V", "")]
		public unsafe MetricEvent (string p0, long p1, int p2, global::Com.Amazon.Clouddrive.Exceptions.CloudDriveException p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (MetricEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JILcom/amazon/clouddrive/exceptions/CloudDriveException;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JILcom/amazon/clouddrive/exceptions/CloudDriveException;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JILcom_amazon_clouddrive_exceptions_CloudDriveException_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JILcom_amazon_clouddrive_exceptions_CloudDriveException_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JILcom/amazon/clouddrive/exceptions/CloudDriveException;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JILcom_amazon_clouddrive_exceptions_CloudDriveException_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JILcom_amazon_clouddrive_exceptions_CloudDriveException_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCloudDriveException;
#pragma warning disable 0169
		static Delegate GetGetCloudDriveExceptionHandler ()
		{
			if (cb_getCloudDriveException == null)
				cb_getCloudDriveException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloudDriveException);
			return cb_getCloudDriveException;
		}

		static IntPtr n_GetCloudDriveException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloudDriveException);
		}
#pragma warning restore 0169

		static IntPtr id_getCloudDriveException;
		public virtual unsafe global::Com.Amazon.Clouddrive.Exceptions.CloudDriveException CloudDriveException {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/method[@name='getCloudDriveException' and count(parameter)=0]"
			[Register ("getCloudDriveException", "()Lcom/amazon/clouddrive/exceptions/CloudDriveException;", "GetGetCloudDriveExceptionHandler")]
			get {
				if (id_getCloudDriveException == IntPtr.Zero)
					id_getCloudDriveException = JNIEnv.GetMethodID (class_ref, "getCloudDriveException", "()Lcom/amazon/clouddrive/exceptions/CloudDriveException;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Exceptions.CloudDriveException> (JNIEnv.CallObjectMethod  (Handle, id_getCloudDriveException), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Exceptions.CloudDriveException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCloudDriveException", "()Lcom/amazon/clouddrive/exceptions/CloudDriveException;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasSucceeded;
#pragma warning disable 0169
		static Delegate GetHasSucceededHandler ()
		{
			if (cb_hasSucceeded == null)
				cb_hasSucceeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSucceeded);
			return cb_hasSucceeded;
		}

		static bool n_HasSucceeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSucceeded;
		}
#pragma warning restore 0169

		static IntPtr id_hasSucceeded;
		public virtual unsafe bool HasSucceeded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/method[@name='hasSucceeded' and count(parameter)=0]"
			[Register ("hasSucceeded", "()Z", "GetHasSucceededHandler")]
			get {
				if (id_hasSucceeded == IntPtr.Zero)
					id_hasSucceeded = JNIEnv.GetMethodID (class_ref, "hasSucceeded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasSucceeded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSucceeded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOperationName;
#pragma warning disable 0169
		static Delegate GetGetOperationNameHandler ()
		{
			if (cb_getOperationName == null)
				cb_getOperationName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOperationName);
			return cb_getOperationName;
		}

		static IntPtr n_GetOperationName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OperationName);
		}
#pragma warning restore 0169

		static IntPtr id_getOperationName;
		public virtual unsafe string OperationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/method[@name='getOperationName' and count(parameter)=0]"
			[Register ("getOperationName", "()Ljava/lang/String;", "GetGetOperationNameHandler")]
			get {
				if (id_getOperationName == IntPtr.Zero)
					id_getOperationName = JNIEnv.GetMethodID (class_ref, "getOperationName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOperationName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOperationName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryCount;
#pragma warning disable 0169
		static Delegate GetGetRetryCountHandler ()
		{
			if (cb_getRetryCount == null)
				cb_getRetryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryCount);
			return cb_getRetryCount;
		}

		static int n_GetRetryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryCount;
		public virtual unsafe int RetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/method[@name='getRetryCount' and count(parameter)=0]"
			[Register ("getRetryCount", "()I", "GetGetRetryCountHandler")]
			get {
				if (id_getRetryCount == IntPtr.Zero)
					id_getRetryCount = JNIEnv.GetMethodID (class_ref, "getRetryCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRetryCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimeInMillis;
#pragma warning disable 0169
		static Delegate GetGetTimeInMillisHandler ()
		{
			if (cb_getTimeInMillis == null)
				cb_getTimeInMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeInMillis);
			return cb_getTimeInMillis;
		}

		static long n_GetTimeInMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeInMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeInMillis;
		public virtual unsafe long TimeInMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/class[@name='MetricEvent']/method[@name='getTimeInMillis' and count(parameter)=0]"
			[Register ("getTimeInMillis", "()J", "GetGetTimeInMillisHandler")]
			get {
				if (id_getTimeInMillis == IntPtr.Zero)
					id_getTimeInMillis = JNIEnv.GetMethodID (class_ref, "getTimeInMillis", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getTimeInMillis);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeInMillis", "()J"));
				} finally {
				}
			}
		}

	}
}
