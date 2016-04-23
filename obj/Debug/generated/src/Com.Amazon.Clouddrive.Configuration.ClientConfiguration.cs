using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/configuration/ClientConfiguration", DoNotGenerateAcw=true)]
	public partial class ClientConfiguration : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/configuration/ClientConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientConfiguration); }
		}

		protected ClientConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/constructor[@name='ClientConfiguration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClientConfiguration (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ClientConfiguration)) {
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

		static IntPtr id_ctor_Lcom_amazon_clouddrive_configuration_ClientConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/constructor[@name='ClientConfiguration' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.configuration.ClientConfiguration']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", "")]
		public unsafe ClientConfiguration (global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ClientConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args);
			} finally {
			}
		}

		static Delegate cb_getConnectionTimeOutMillis;
#pragma warning disable 0169
		static Delegate GetGetConnectionTimeOutMillisHandler ()
		{
			if (cb_getConnectionTimeOutMillis == null)
				cb_getConnectionTimeOutMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionTimeOutMillis);
			return cb_getConnectionTimeOutMillis;
		}

		static int n_GetConnectionTimeOutMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionTimeOutMillis;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectionTimeOutMillis_I;
#pragma warning disable 0169
		static Delegate GetSetConnectionTimeOutMillis_IHandler ()
		{
			if (cb_setConnectionTimeOutMillis_I == null)
				cb_setConnectionTimeOutMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectionTimeOutMillis_I);
			return cb_setConnectionTimeOutMillis_I;
		}

		static void n_SetConnectionTimeOutMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionTimeOutMillis = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionTimeOutMillis;
		static IntPtr id_setConnectionTimeOutMillis_I;
		public virtual unsafe int ConnectionTimeOutMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getConnectionTimeOutMillis' and count(parameter)=0]"
			[Register ("getConnectionTimeOutMillis", "()I", "GetGetConnectionTimeOutMillisHandler")]
			get {
				if (id_getConnectionTimeOutMillis == IntPtr.Zero)
					id_getConnectionTimeOutMillis = JNIEnv.GetMethodID (class_ref, "getConnectionTimeOutMillis", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getConnectionTimeOutMillis);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionTimeOutMillis", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setConnectionTimeOutMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectionTimeOutMillis", "(I)V", "GetSetConnectionTimeOutMillis_IHandler")]
			set {
				if (id_setConnectionTimeOutMillis_I == IntPtr.Zero)
					id_setConnectionTimeOutMillis_I = JNIEnv.GetMethodID (class_ref, "setConnectionTimeOutMillis", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConnectionTimeOutMillis_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionTimeOutMillis", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMasterEndpoint;
#pragma warning disable 0169
		static Delegate GetGetMasterEndpointHandler ()
		{
			if (cb_getMasterEndpoint == null)
				cb_getMasterEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMasterEndpoint);
			return cb_getMasterEndpoint;
		}

		static IntPtr n_GetMasterEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MasterEndpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setMasterEndpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMasterEndpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setMasterEndpoint_Ljava_lang_String_ == null)
				cb_setMasterEndpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMasterEndpoint_Ljava_lang_String_);
			return cb_setMasterEndpoint_Ljava_lang_String_;
		}

		static void n_SetMasterEndpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MasterEndpoint = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMasterEndpoint;
		static IntPtr id_setMasterEndpoint_Ljava_lang_String_;
		public virtual unsafe string MasterEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getMasterEndpoint' and count(parameter)=0]"
			[Register ("getMasterEndpoint", "()Ljava/lang/String;", "GetGetMasterEndpointHandler")]
			get {
				if (id_getMasterEndpoint == IntPtr.Zero)
					id_getMasterEndpoint = JNIEnv.GetMethodID (class_ref, "getMasterEndpoint", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMasterEndpoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMasterEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setMasterEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMasterEndpoint", "(Ljava/lang/String;)V", "GetSetMasterEndpoint_Ljava_lang_String_Handler")]
			set {
				if (id_setMasterEndpoint_Ljava_lang_String_ == IntPtr.Zero)
					id_setMasterEndpoint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMasterEndpoint", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMasterEndpoint_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMasterEndpoint", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMaxErrorRetry;
#pragma warning disable 0169
		static Delegate GetGetMaxErrorRetryHandler ()
		{
			if (cb_getMaxErrorRetry == null)
				cb_getMaxErrorRetry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxErrorRetry);
			return cb_getMaxErrorRetry;
		}

		static int n_GetMaxErrorRetry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxErrorRetry;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxErrorRetry_I;
#pragma warning disable 0169
		static Delegate GetSetMaxErrorRetry_IHandler ()
		{
			if (cb_setMaxErrorRetry_I == null)
				cb_setMaxErrorRetry_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxErrorRetry_I);
			return cb_setMaxErrorRetry_I;
		}

		static void n_SetMaxErrorRetry_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxErrorRetry = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxErrorRetry;
		static IntPtr id_setMaxErrorRetry_I;
		public virtual unsafe int MaxErrorRetry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getMaxErrorRetry' and count(parameter)=0]"
			[Register ("getMaxErrorRetry", "()I", "GetGetMaxErrorRetryHandler")]
			get {
				if (id_getMaxErrorRetry == IntPtr.Zero)
					id_getMaxErrorRetry = JNIEnv.GetMethodID (class_ref, "getMaxErrorRetry", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxErrorRetry);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxErrorRetry", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setMaxErrorRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxErrorRetry", "(I)V", "GetSetMaxErrorRetry_IHandler")]
			set {
				if (id_setMaxErrorRetry_I == IntPtr.Zero)
					id_setMaxErrorRetry_I = JNIEnv.GetMethodID (class_ref, "setMaxErrorRetry", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxErrorRetry_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxErrorRetry", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMetricListener;
#pragma warning disable 0169
		static Delegate GetGetMetricListenerHandler ()
		{
			if (cb_getMetricListener == null)
				cb_getMetricListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetricListener);
			return cb_getMetricListener;
		}

		static IntPtr n_GetMetricListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetricListener);
		}
#pragma warning restore 0169

		static Delegate cb_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_;
#pragma warning disable 0169
		static Delegate GetSetMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_Handler ()
		{
			if (cb_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_ == null)
				cb_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_);
			return cb_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_;
		}

		static void n_SetMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Metrics.IMetricListener p0 = (global::Com.Amazon.Clouddrive.Metrics.IMetricListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.IMetricListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MetricListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetricListener;
		static IntPtr id_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Metrics.IMetricListener MetricListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getMetricListener' and count(parameter)=0]"
			[Register ("getMetricListener", "()Lcom/amazon/clouddrive/metrics/MetricListener;", "GetGetMetricListenerHandler")]
			get {
				if (id_getMetricListener == IntPtr.Zero)
					id_getMetricListener = JNIEnv.GetMethodID (class_ref, "getMetricListener", "()Lcom/amazon/clouddrive/metrics/MetricListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.IMetricListener> (JNIEnv.CallObjectMethod  (Handle, id_getMetricListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.IMetricListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetricListener", "()Lcom/amazon/clouddrive/metrics/MetricListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setMetricListener' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.metrics.MetricListener']]"
			[Register ("setMetricListener", "(Lcom/amazon/clouddrive/metrics/MetricListener;)V", "GetSetMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_Handler")]
			set {
				if (id_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_ == IntPtr.Zero)
					id_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_ = JNIEnv.GetMethodID (class_ref, "setMetricListener", "(Lcom/amazon/clouddrive/metrics/MetricListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMetricListener_Lcom_amazon_clouddrive_metrics_MetricListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetricListener", "(Lcom/amazon/clouddrive/metrics/MetricListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReadTimeOutMillis;
#pragma warning disable 0169
		static Delegate GetGetReadTimeOutMillisHandler ()
		{
			if (cb_getReadTimeOutMillis == null)
				cb_getReadTimeOutMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadTimeOutMillis);
			return cb_getReadTimeOutMillis;
		}

		static int n_GetReadTimeOutMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeOutMillis;
		}
#pragma warning restore 0169

		static Delegate cb_setReadTimeOutMillis_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeOutMillis_IHandler ()
		{
			if (cb_setReadTimeOutMillis_I == null)
				cb_setReadTimeOutMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeOutMillis_I);
			return cb_setReadTimeOutMillis_I;
		}

		static void n_SetReadTimeOutMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadTimeOutMillis = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReadTimeOutMillis;
		static IntPtr id_setReadTimeOutMillis_I;
		public virtual unsafe int ReadTimeOutMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getReadTimeOutMillis' and count(parameter)=0]"
			[Register ("getReadTimeOutMillis", "()I", "GetGetReadTimeOutMillisHandler")]
			get {
				if (id_getReadTimeOutMillis == IntPtr.Zero)
					id_getReadTimeOutMillis = JNIEnv.GetMethodID (class_ref, "getReadTimeOutMillis", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getReadTimeOutMillis);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadTimeOutMillis", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setReadTimeOutMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeOutMillis", "(I)V", "GetSetReadTimeOutMillis_IHandler")]
			set {
				if (id_setReadTimeOutMillis_I == IntPtr.Zero)
					id_setReadTimeOutMillis_I = JNIEnv.GetMethodID (class_ref, "setReadTimeOutMillis", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReadTimeOutMillis_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadTimeOutMillis", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserAgent;
#pragma warning disable 0169
		static Delegate GetGetUserAgentHandler ()
		{
			if (cb_getUserAgent == null)
				cb_getUserAgent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserAgent);
			return cb_getUserAgent;
		}

		static IntPtr n_GetUserAgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserAgent);
		}
#pragma warning restore 0169

		static Delegate cb_setUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgent_Ljava_lang_String_ == null)
				cb_setUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgent_Ljava_lang_String_);
			return cb_setUserAgent_Ljava_lang_String_;
		}

		static void n_SetUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserAgent = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserAgent;
		static IntPtr id_setUserAgent_Ljava_lang_String_;
		public virtual unsafe string UserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='getUserAgent' and count(parameter)=0]"
			[Register ("getUserAgent", "()Ljava/lang/String;", "GetGetUserAgentHandler")]
			get {
				if (id_getUserAgent == IntPtr.Zero)
					id_getUserAgent = JNIEnv.GetMethodID (class_ref, "getUserAgent", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserAgent), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserAgent", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='ClientConfiguration']/method[@name='setUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserAgent", "(Ljava/lang/String;)V", "GetSetUserAgent_Ljava_lang_String_Handler")]
			set {
				if (id_setUserAgent_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserAgent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserAgent", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUserAgent_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAgent", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

#region "Event implementation for Com.Amazon.Clouddrive.Metrics.IMetricListener"
		public event EventHandler<global::Com.Amazon.Clouddrive.Metrics.MetricEventArgs> Metric {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amazon.Clouddrive.Metrics.IMetricListener, global::Com.Amazon.Clouddrive.Metrics.IMetricListenerImplementor>(
						ref weak_implementor___SetMetricListener,
						__CreateIMetricListenerImplementor,
						__v => MetricListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amazon.Clouddrive.Metrics.IMetricListener, global::Com.Amazon.Clouddrive.Metrics.IMetricListenerImplementor>(
						ref weak_implementor___SetMetricListener,
						global::Com.Amazon.Clouddrive.Metrics.IMetricListenerImplementor.__IsEmpty,
						__v => MetricListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetMetricListener;

		global::Com.Amazon.Clouddrive.Metrics.IMetricListenerImplementor __CreateIMetricListenerImplementor ()
		{
			return new global::Com.Amazon.Clouddrive.Metrics.IMetricListenerImplementor (this);
		}
#endregion
	}
}
