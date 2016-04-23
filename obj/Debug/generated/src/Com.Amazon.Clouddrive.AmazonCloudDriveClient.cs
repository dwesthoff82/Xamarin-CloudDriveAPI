using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/AmazonCloudDriveClient", DoNotGenerateAcw=true)]
	public partial class AmazonCloudDriveClient : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.IAmazonCloudDrive {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient.BackgroundThreadFactory']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/AmazonCloudDriveClient$BackgroundThreadFactory", DoNotGenerateAcw=true)]
		public partial class BackgroundThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/AmazonCloudDriveClient$BackgroundThreadFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BackgroundThreadFactory); }
			}

			protected BackgroundThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Clouddrive.AmazonCloudDriveClient.BackgroundThreadFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient.BackgroundThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient.BackgroundThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Thread __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient.CallWithHandler']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/AmazonCloudDriveClient$CallWithHandler", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends com.amazon.clouddrive.model.CloudDriveRequest", "RESULT"})]
		public partial class CallWithHandler : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/AmazonCloudDriveClient$CallWithHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallWithHandler); }
			}

			protected CallWithHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Clouddrive.AmazonCloudDriveClient.CallWithHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient.CallWithHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			static IntPtr id_call;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient.CallWithHandler']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public virtual unsafe global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_call), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "call", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/AmazonCloudDriveClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonCloudDriveClient); }
		}

		protected AmazonCloudDriveClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/constructor[@name='AmazonCloudDriveClient' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.configuration.AccountConfiguration'] and parameter[2][@type='com.amazon.clouddrive.configuration.ClientConfiguration']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", "")]
		public unsafe AmazonCloudDriveClient (global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration p0, global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AmazonCloudDriveClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/constructor[@name='AmazonCloudDriveClient' and count(parameter)=3 and parameter[1][@type='com.amazon.clouddrive.configuration.AccountConfiguration'] and parameter[2][@type='com.amazon.clouddrive.configuration.ClientConfiguration'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe AmazonCloudDriveClient (global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration p0, global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration p1, global::Java.Util.Concurrent.IExecutorService p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AmazonCloudDriveClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_Ljava_util_concurrent_ExecutorService_, __args);
			} finally {
			}
		}

		static Delegate cb_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
#pragma warning disable 0169
		static Delegate GetAddChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Handler ()
		{
			if (cb_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ == null)
				cb_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_);
			return cb_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
		}

		static void n_AddChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChildToParent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='addChildToParent' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.AddChildToParentRequest']]"
		[Register ("addChildToParent", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)V", "GetAddChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Handler")]
		public virtual unsafe void AddChildToParent (global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0)
		{
			if (id_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ == IntPtr.Zero)
				id_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ = JNIEnv.GetMethodID (class_ref, "addChildToParent", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addChildToParent_Lcom_amazon_clouddrive_model_AddChildToParentRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChildToParent", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetAddChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_AddChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddChildToParentAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='addChildToParentAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.AddChildToParentRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.AddChildToParentRequest, java.lang.Void&gt;']]"
		[Register ("addChildToParentAsync", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetAddChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture AddChildToParentAsync (global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "addChildToParentAsync", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_addChildToParentAsync_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChildToParentAsync", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetAddNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Handler ()
		{
			if (cb_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ == null)
				cb_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_);
			return cb_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
		}

		static IntPtr n_AddNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddNodeProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='addNodeProperty' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.AddNodePropertyRequest']]"
		[Register ("addNodeProperty", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/model/AddNodePropertyResponse;", "GetAddNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.AddNodePropertyResponse AddNodeProperty (global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0)
		{
			if (id_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ == IntPtr.Zero)
				id_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "addNodeProperty", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/model/AddNodePropertyResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.AddNodePropertyResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddNodePropertyResponse> (JNIEnv.CallObjectMethod  (Handle, id_addNodeProperty_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddNodePropertyResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNodeProperty", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/model/AddNodePropertyResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetAddNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_AddNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddNodePropertyAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='addNodePropertyAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.AddNodePropertyRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.AddNodePropertyRequest, com.amazon.clouddrive.model.AddNodePropertyResponse&gt;']]"
		[Register ("addNodePropertyAsync", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetAddNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture AddNodePropertyAsync (global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "addNodePropertyAsync", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_addNodePropertyAsync_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNodePropertyAsync", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_;
#pragma warning disable 0169
		static Delegate GetCreateNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_Handler ()
		{
			if (cb_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_ == null)
				cb_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_);
			return cb_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_;
		}

		static IntPtr n_CreateNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateNode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='createNode' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CreateNodeRequest']]"
		[Register ("createNode", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;)Lcom/amazon/clouddrive/model/CreateNodeResponse;", "GetCreateNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeResponse CreateNode (global::Com.Amazon.Clouddrive.Model.CreateNodeRequest p0)
		{
			if (id_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_ == IntPtr.Zero)
				id_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_ = JNIEnv.GetMethodID (class_ref, "createNode", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;)Lcom/amazon/clouddrive/model/CreateNodeResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeResponse> (JNIEnv.CallObjectMethod  (Handle, id_createNode_Lcom_amazon_clouddrive_model_CreateNodeRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNode", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;)Lcom/amazon/clouddrive/model/CreateNodeResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetCreateNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_CreateNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateNodeAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='createNodeAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.CreateNodeRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.CreateNodeRequest, com.amazon.clouddrive.model.CreateNodeResponse&gt;']]"
		[Register ("createNodeAsync", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetCreateNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture CreateNodeAsync (global::Com.Amazon.Clouddrive.Model.CreateNodeRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "createNodeAsync", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_createNodeAsync_Lcom_amazon_clouddrive_model_CreateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNodeAsync", "(Lcom/amazon/clouddrive/model/CreateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetDeleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Handler ()
		{
			if (cb_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ == null)
				cb_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_);
			return cb_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
		}

		static void n_DeleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteNodeProperty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='deleteNodeProperty' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.DeleteNodePropertyRequest']]"
		[Register ("deleteNodeProperty", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)V", "GetDeleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Handler")]
		public virtual unsafe void DeleteNodeProperty (global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0)
		{
			if (id_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ == IntPtr.Zero)
				id_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "deleteNodeProperty", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteNodeProperty_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteNodeProperty", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetDeleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_DeleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteNodePropertyAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='deleteNodePropertyAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.DeleteNodePropertyRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.DeleteNodePropertyRequest, java.lang.Void&gt;']]"
		[Register ("deleteNodePropertyAsync", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetDeleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture DeleteNodePropertyAsync (global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "deleteNodePropertyAsync", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_deleteNodePropertyAsync_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteNodePropertyAsync", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
#pragma warning disable 0169
		static Delegate GetDownloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler ()
		{
			if (cb_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == null)
				cb_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_);
			return cb_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		}

		static void n_DownloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1 = (global::Com.Amazon.Clouddrive.Handlers.IProgressListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DownloadFile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='downloadFile' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.DownloadFileRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.ProgressListener']]"
		[Register ("downloadFile", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)V", "GetDownloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler")]
		public virtual unsafe void DownloadFile (global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0, global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1)
		{
			if (id_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == IntPtr.Zero)
				id_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNIEnv.GetMethodID (class_ref, "downloadFile", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_downloadFile_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadFile", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetDownloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_DownloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1 = (global::Com.Amazon.Clouddrive.Handlers.IProgressListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p2 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadFileAsync (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='downloadFileAsync' and count(parameter)=3 and parameter[1][@type='com.amazon.clouddrive.model.DownloadFileRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.ProgressListener'] and parameter[3][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.DownloadFileRequest, java.lang.Void&gt;']]"
		[Register ("downloadFileAsync", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetDownloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture DownloadFileAsync (global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0, global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p2)
		{
			if (id_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "downloadFileAsync", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_downloadFileAsync_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadFileAsync", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
#pragma warning disable 0169
		static Delegate GetGetAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Handler ()
		{
			if (cb_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ == null)
				cb_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_);
			return cb_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
		}

		static IntPtr n_GetAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountEndpoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountEndpoint' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountEndpointRequest']]"
		[Register ("getAccountEndpoint", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/model/GetAccountEndpointResponse;", "GetGetAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse GetAccountEndpoint (global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0)
		{
			if (id_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ == IntPtr.Zero)
				id_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ = JNIEnv.GetMethodID (class_ref, "getAccountEndpoint", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/model/GetAccountEndpointResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (JNIEnv.CallObjectMethod  (Handle, id_getAccountEndpoint_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountEndpoint", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/model/GetAccountEndpointResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountEndpointAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountEndpointAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountEndpointRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetAccountEndpointRequest, com.amazon.clouddrive.model.GetAccountEndpointResponse&gt;']]"
		[Register ("getAccountEndpointAsync", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetAccountEndpointAsync (global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getAccountEndpointAsync", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getAccountEndpointAsync_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountEndpointAsync", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
#pragma warning disable 0169
		static Delegate GetGetAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Handler ()
		{
			if (cb_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ == null)
				cb_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_);
			return cb_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
		}

		static IntPtr n_GetAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountInfo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountInfoRequest']]"
		[Register ("getAccountInfo", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/model/GetAccountInfoResponse;", "GetGetAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetAccountInfoResponse GetAccountInfo (global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0)
		{
			if (id_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ == IntPtr.Zero)
				id_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ = JNIEnv.GetMethodID (class_ref, "getAccountInfo", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/model/GetAccountInfoResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetAccountInfoResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountInfoResponse> (JNIEnv.CallObjectMethod  (Handle, id_getAccountInfo_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountInfoResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountInfo", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/model/GetAccountInfoResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountInfoAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountInfoAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountInfoRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetAccountInfoRequest, com.amazon.clouddrive.model.GetAccountInfoResponse&gt;']]"
		[Register ("getAccountInfoAsync", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetAccountInfoAsync (global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getAccountInfoAsync", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getAccountInfoAsync_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountInfoAsync", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
#pragma warning disable 0169
		static Delegate GetGetAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Handler ()
		{
			if (cb_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ == null)
				cb_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_);
			return cb_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
		}

		static IntPtr n_GetAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountQuota (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountQuota' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountQuotaRequest']]"
		[Register ("getAccountQuota", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/model/GetAccountQuotaResponse;", "GetGetAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse GetAccountQuota (global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0)
		{
			if (id_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ == IntPtr.Zero)
				id_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ = JNIEnv.GetMethodID (class_ref, "getAccountQuota", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/model/GetAccountQuotaResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (JNIEnv.CallObjectMethod  (Handle, id_getAccountQuota_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountQuota", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/model/GetAccountQuotaResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountQuotaAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountQuotaAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountQuotaRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetAccountQuotaRequest, com.amazon.clouddrive.model.GetAccountQuotaResponse&gt;']]"
		[Register ("getAccountQuotaAsync", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetAccountQuotaAsync (global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getAccountQuotaAsync", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getAccountQuotaAsync_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountQuotaAsync", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
#pragma warning disable 0169
		static Delegate GetGetAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Handler ()
		{
			if (cb_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ == null)
				cb_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_);
			return cb_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
		}

		static IntPtr n_GetAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountUsage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountUsage' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountUsageRequest']]"
		[Register ("getAccountUsage", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/model/GetAccountUsageResponse;", "GetGetAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse GetAccountUsage (global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0)
		{
			if (id_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ == IntPtr.Zero)
				id_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ = JNIEnv.GetMethodID (class_ref, "getAccountUsage", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/model/GetAccountUsageResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (JNIEnv.CallObjectMethod  (Handle, id_getAccountUsage_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountUsage", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/model/GetAccountUsageResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccountUsageAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getAccountUsageAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountUsageRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetAccountUsageRequest, com.amazon.clouddrive.model.GetAccountUsageResponse&gt;']]"
		[Register ("getAccountUsageAsync", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetAccountUsageAsync (global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getAccountUsageAsync", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getAccountUsageAsync_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountUsageAsync", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_;
#pragma warning disable 0169
		static Delegate GetGetChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_Handler ()
		{
			if (cb_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_ == null)
				cb_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_);
			return cb_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_;
		}

		static IntPtr n_GetChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChanges (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getChanges' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetChangesRequest']]"
		[Register ("getChanges", "(Lcom/amazon/clouddrive/model/GetChangesRequest;)Lcom/amazon/clouddrive/model/GetChangesResponse;", "GetGetChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetChangesResponse GetChanges (global::Com.Amazon.Clouddrive.Model.GetChangesRequest p0)
		{
			if (id_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_ == IntPtr.Zero)
				id_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_ = JNIEnv.GetMethodID (class_ref, "getChanges", "(Lcom/amazon/clouddrive/model/GetChangesRequest;)Lcom/amazon/clouddrive/model/GetChangesResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetChangesResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (JNIEnv.CallObjectMethod  (Handle, id_getChanges_Lcom_amazon_clouddrive_model_GetChangesRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChanges", "(Lcom/amazon/clouddrive/model/GetChangesRequest;)Lcom/amazon/clouddrive/model/GetChangesResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetChangesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetChangesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChangesAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getChangesAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetChangesRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetChangesRequest, com.amazon.clouddrive.model.GetChangesResponse&gt;']]"
		[Register ("getChangesAsync", "(Lcom/amazon/clouddrive/model/GetChangesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetChangesAsync (global::Com.Amazon.Clouddrive.Model.GetChangesRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getChangesAsync", "(Lcom/amazon/clouddrive/model/GetChangesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getChangesAsync_Lcom_amazon_clouddrive_model_GetChangesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChangesAsync", "(Lcom/amazon/clouddrive/model/GetChangesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_;
#pragma warning disable 0169
		static Delegate GetGetNode_Lcom_amazon_clouddrive_model_GetNodeRequest_Handler ()
		{
			if (cb_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_ == null)
				cb_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNode_Lcom_amazon_clouddrive_model_GetNodeRequest_);
			return cb_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_;
		}

		static IntPtr n_GetNode_Lcom_amazon_clouddrive_model_GetNodeRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getNode' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetNodeRequest']]"
		[Register ("getNode", "(Lcom/amazon/clouddrive/model/GetNodeRequest;)Lcom/amazon/clouddrive/model/GetNodeResponse;", "GetGetNode_Lcom_amazon_clouddrive_model_GetNodeRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetNodeResponse GetNode (global::Com.Amazon.Clouddrive.Model.GetNodeRequest p0)
		{
			if (id_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_ == IntPtr.Zero)
				id_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_ = JNIEnv.GetMethodID (class_ref, "getNode", "(Lcom/amazon/clouddrive/model/GetNodeRequest;)Lcom/amazon/clouddrive/model/GetNodeResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetNodeResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeResponse> (JNIEnv.CallObjectMethod  (Handle, id_getNode_Lcom_amazon_clouddrive_model_GetNodeRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNode", "(Lcom/amazon/clouddrive/model/GetNodeRequest;)Lcom/amazon/clouddrive/model/GetNodeResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNodeAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getNodeAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetNodeRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetNodeRequest, com.amazon.clouddrive.model.GetNodeResponse&gt;']]"
		[Register ("getNodeAsync", "(Lcom/amazon/clouddrive/model/GetNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetNodeAsync (global::Com.Amazon.Clouddrive.Model.GetNodeRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getNodeAsync", "(Lcom/amazon/clouddrive/model/GetNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getNodeAsync_Lcom_amazon_clouddrive_model_GetNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodeAsync", "(Lcom/amazon/clouddrive/model/GetNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetGetNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Handler ()
		{
			if (cb_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ == null)
				cb_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_);
			return cb_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
		}

		static IntPtr n_GetNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNodeProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getNodeProperty' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetNodePropertyRequest']]"
		[Register ("getNodeProperty", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/model/GetNodePropertyResponse;", "GetGetNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.GetNodePropertyResponse GetNodeProperty (global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0)
		{
			if (id_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ == IntPtr.Zero)
				id_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "getNodeProperty", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/model/GetNodePropertyResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.GetNodePropertyResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyResponse> (JNIEnv.CallObjectMethod  (Handle, id_getNodeProperty_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodeProperty", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/model/GetNodePropertyResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetGetNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_GetNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNodePropertyAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='getNodePropertyAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.GetNodePropertyRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.GetNodePropertyRequest, com.amazon.clouddrive.model.GetNodePropertyResponse&gt;']]"
		[Register ("getNodePropertyAsync", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetGetNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture GetNodePropertyAsync (global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "getNodePropertyAsync", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getNodePropertyAsync_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodePropertyAsync", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_;
#pragma warning disable 0169
		static Delegate GetListChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_Handler ()
		{
			if (cb_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_ == null)
				cb_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_);
			return cb_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_;
		}

		static IntPtr n_ListChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListChildren (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listChildren' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ListChildrenRequest']]"
		[Register ("listChildren", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;)Lcom/amazon/clouddrive/model/ListChildrenResponse;", "GetListChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenResponse ListChildren (global::Com.Amazon.Clouddrive.Model.ListChildrenRequest p0)
		{
			if (id_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_ == IntPtr.Zero)
				id_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_ = JNIEnv.GetMethodID (class_ref, "listChildren", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;)Lcom/amazon/clouddrive/model/ListChildrenResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenResponse> (JNIEnv.CallObjectMethod  (Handle, id_listChildren_Lcom_amazon_clouddrive_model_ListChildrenRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listChildren", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;)Lcom/amazon/clouddrive/model/ListChildrenResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetListChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_ListChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListChildrenAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listChildrenAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.ListChildrenRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.ListChildrenRequest, com.amazon.clouddrive.model.ListChildrenResponse&gt;']]"
		[Register ("listChildrenAsync", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetListChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture ListChildrenAsync (global::Com.Amazon.Clouddrive.Model.ListChildrenRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "listChildrenAsync", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_listChildrenAsync_Lcom_amazon_clouddrive_model_ListChildrenRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listChildrenAsync", "(Lcom/amazon/clouddrive/model/ListChildrenRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
#pragma warning disable 0169
		static Delegate GetListNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Handler ()
		{
			if (cb_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ == null)
				cb_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_);
			return cb_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
		}

		static IntPtr n_ListNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodeProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodeProperties' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ListNodePropertiesRequest']]"
		[Register ("listNodeProperties", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/model/ListNodePropertiesResponse;", "GetListNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse ListNodeProperties (global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0)
		{
			if (id_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ == IntPtr.Zero)
				id_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ = JNIEnv.GetMethodID (class_ref, "listNodeProperties", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/model/ListNodePropertiesResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (JNIEnv.CallObjectMethod  (Handle, id_listNodeProperties_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodeProperties", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/model/ListNodePropertiesResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetListNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_ListNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodePropertiesAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodePropertiesAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.ListNodePropertiesRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.ListNodePropertiesRequest, com.amazon.clouddrive.model.ListNodePropertiesResponse&gt;']]"
		[Register ("listNodePropertiesAsync", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetListNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture ListNodePropertiesAsync (global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "listNodePropertiesAsync", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_listNodePropertiesAsync_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodePropertiesAsync", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_;
#pragma warning disable 0169
		static Delegate GetListNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_Handler ()
		{
			if (cb_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_ == null)
				cb_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_);
			return cb_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_;
		}

		static IntPtr n_ListNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodes (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodes' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ListNodesRequest']]"
		[Register ("listNodes", "(Lcom/amazon/clouddrive/model/ListNodesRequest;)Lcom/amazon/clouddrive/model/ListNodesResponse;", "GetListNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesResponse ListNodes (global::Com.Amazon.Clouddrive.Model.ListNodesRequest p0)
		{
			if (id_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_ == IntPtr.Zero)
				id_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_ = JNIEnv.GetMethodID (class_ref, "listNodes", "(Lcom/amazon/clouddrive/model/ListNodesRequest;)Lcom/amazon/clouddrive/model/ListNodesResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesResponse> (JNIEnv.CallObjectMethod  (Handle, id_listNodes_Lcom_amazon_clouddrive_model_ListNodesRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodes", "(Lcom/amazon/clouddrive/model/ListNodesRequest;)Lcom/amazon/clouddrive/model/ListNodesResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetListNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_ListNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodesAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodesAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.ListNodesRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.ListNodesRequest, com.amazon.clouddrive.model.ListNodesResponse&gt;']]"
		[Register ("listNodesAsync", "(Lcom/amazon/clouddrive/model/ListNodesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetListNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture ListNodesAsync (global::Com.Amazon.Clouddrive.Model.ListNodesRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "listNodesAsync", "(Lcom/amazon/clouddrive/model/ListNodesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_listNodesAsync_Lcom_amazon_clouddrive_model_ListNodesRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodesAsync", "(Lcom/amazon/clouddrive/model/ListNodesRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_;
#pragma warning disable 0169
		static Delegate GetListNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Handler ()
		{
			if (cb_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_ == null)
				cb_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_);
			return cb_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_;
		}

		static IntPtr n_ListNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodesInTrash (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodesInTrash' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ListNodesInTrashRequest']]"
		[Register ("listNodesInTrash", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;)Lcom/amazon/clouddrive/model/ListNodesInTrashResponse;", "GetListNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse ListNodesInTrash (global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest p0)
		{
			if (id_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_ == IntPtr.Zero)
				id_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_ = JNIEnv.GetMethodID (class_ref, "listNodesInTrash", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;)Lcom/amazon/clouddrive/model/ListNodesInTrashResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse> (JNIEnv.CallObjectMethod  (Handle, id_listNodesInTrash_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodesInTrash", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;)Lcom/amazon/clouddrive/model/ListNodesInTrashResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetListNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ListNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_ListNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListNodesInTrashAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='listNodesInTrashAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.ListNodesInTrashRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.ListNodesInTrashRequest, com.amazon.clouddrive.model.ListNodesInTrashResponse&gt;']]"
		[Register ("listNodesInTrashAsync", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetListNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture ListNodesInTrashAsync (global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "listNodesInTrashAsync", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_listNodesInTrashAsync_Lcom_amazon_clouddrive_model_ListNodesInTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listNodesInTrashAsync", "(Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
#pragma warning disable 0169
		static Delegate GetMoveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Handler ()
		{
			if (cb_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ == null)
				cb_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_);
			return cb_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
		}

		static IntPtr n_MoveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MoveNodeToTrash (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='moveNodeToTrash' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.MoveNodeToTrashRequest']]"
		[Register ("moveNodeToTrash", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/model/MoveNodeToTrashResponse;", "GetMoveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashResponse MoveNodeToTrash (global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0)
		{
			if (id_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ == IntPtr.Zero)
				id_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ = JNIEnv.GetMethodID (class_ref, "moveNodeToTrash", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/model/MoveNodeToTrashResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashResponse> (JNIEnv.CallObjectMethod  (Handle, id_moveNodeToTrash_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveNodeToTrash", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/model/MoveNodeToTrashResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetMoveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_MoveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MoveNodeToTrashAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='moveNodeToTrashAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.MoveNodeToTrashRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.MoveNodeToTrashRequest, com.amazon.clouddrive.model.MoveNodeToTrashResponse&gt;']]"
		[Register ("moveNodeToTrashAsync", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetMoveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture MoveNodeToTrashAsync (global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "moveNodeToTrashAsync", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_moveNodeToTrashAsync_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveNodeToTrashAsync", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
#pragma warning disable 0169
		static Delegate GetRemoveChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Handler ()
		{
			if (cb_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ == null)
				cb_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_);
			return cb_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
		}

		static void n_RemoveChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveChildFromParent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='removeChildFromParent' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.RemoveChildFromParentRequest']]"
		[Register ("removeChildFromParent", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)V", "GetRemoveChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Handler")]
		public virtual unsafe void RemoveChildFromParent (global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0)
		{
			if (id_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ == IntPtr.Zero)
				id_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ = JNIEnv.GetMethodID (class_ref, "removeChildFromParent", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeChildFromParent_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeChildFromParent", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetRemoveChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_RemoveChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveChildFromParentAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='removeChildFromParentAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.RemoveChildFromParentRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.RemoveChildFromParentRequest, java.lang.Void&gt;']]"
		[Register ("removeChildFromParentAsync", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetRemoveChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture RemoveChildFromParentAsync (global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "removeChildFromParentAsync", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_removeChildFromParentAsync_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeChildFromParentAsync", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_;
#pragma warning disable 0169
		static Delegate GetRestoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Handler ()
		{
			if (cb_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_ == null)
				cb_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RestoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_);
			return cb_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_;
		}

		static IntPtr n_RestoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RestoreNodeFromTrash (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='restoreNodeFromTrash' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.RestoreNodeFromTrashRequest']]"
		[Register ("restoreNodeFromTrash", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;)Lcom/amazon/clouddrive/model/RestoreNodeFromTrashResponse;", "GetRestoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashResponse RestoreNodeFromTrash (global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest p0)
		{
			if (id_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_ == IntPtr.Zero)
				id_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_ = JNIEnv.GetMethodID (class_ref, "restoreNodeFromTrash", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;)Lcom/amazon/clouddrive/model/RestoreNodeFromTrashResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashResponse> (JNIEnv.CallObjectMethod  (Handle, id_restoreNodeFromTrash_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreNodeFromTrash", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;)Lcom/amazon/clouddrive/model/RestoreNodeFromTrashResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetRestoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RestoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_RestoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RestoreNodeFromTrashAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='restoreNodeFromTrashAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.RestoreNodeFromTrashRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.RestoreNodeFromTrashRequest, com.amazon.clouddrive.model.RestoreNodeFromTrashResponse&gt;']]"
		[Register ("restoreNodeFromTrashAsync", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetRestoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture RestoreNodeFromTrashAsync (global::Com.Amazon.Clouddrive.Model.RestoreNodeFromTrashRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "restoreNodeFromTrashAsync", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_restoreNodeFromTrashAsync_Lcom_amazon_clouddrive_model_RestoreNodeFromTrashRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreNodeFromTrashAsync", "(Lcom/amazon/clouddrive/model/RestoreNodeFromTrashRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_;
#pragma warning disable 0169
		static Delegate GetUpdateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Handler ()
		{
			if (cb_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_ == null)
				cb_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_);
			return cb_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_;
		}

		static IntPtr n_UpdateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateNode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='updateNode' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UpdateNodeRequest']]"
		[Register ("updateNode", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;)Lcom/amazon/clouddrive/model/UpdateNodeResponse;", "GetUpdateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UpdateNodeResponse UpdateNode (global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest p0)
		{
			if (id_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_ == IntPtr.Zero)
				id_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_ = JNIEnv.GetMethodID (class_ref, "updateNode", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;)Lcom/amazon/clouddrive/model/UpdateNodeResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.UpdateNodeResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UpdateNodeResponse> (JNIEnv.CallObjectMethod  (Handle, id_updateNode_Lcom_amazon_clouddrive_model_UpdateNodeRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UpdateNodeResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNode", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;)Lcom/amazon/clouddrive/model/UpdateNodeResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetUpdateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_UpdateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateNodeAsync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='updateNodeAsync' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.UpdateNodeRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.UpdateNodeRequest, com.amazon.clouddrive.model.UpdateNodeResponse&gt;']]"
		[Register ("updateNodeAsync", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetUpdateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture UpdateNodeAsync (global::Com.Amazon.Clouddrive.Model.UpdateNodeRequest p0, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p1)
		{
			if (id_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "updateNodeAsync", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_updateNodeAsync_Lcom_amazon_clouddrive_model_UpdateNodeRequest_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNodeAsync", "(Lcom/amazon/clouddrive/model/UpdateNodeRequest;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
#pragma warning disable 0169
		static Delegate GetUploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler ()
		{
			if (cb_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == null)
				cb_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_);
			return cb_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		}

		static IntPtr n_UploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1 = (global::Com.Amazon.Clouddrive.Handlers.IProgressListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadFile (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='uploadFile' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.UploadFileRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.ProgressListener']]"
		[Register ("uploadFile", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/model/UploadFileResponse;", "GetUploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UploadFileResponse UploadFile (global::Com.Amazon.Clouddrive.Model.UploadFileRequest p0, global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1)
		{
			if (id_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == IntPtr.Zero)
				id_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNIEnv.GetMethodID (class_ref, "uploadFile", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/model/UploadFileResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Amazon.Clouddrive.Model.UploadFileResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileResponse> (JNIEnv.CallObjectMethod  (Handle, id_uploadFile_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadFile", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/model/UploadFileResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
#pragma warning disable 0169
		static Delegate GetUploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler ()
		{
			if (cb_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == null)
				cb_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_);
			return cb_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		}

		static IntPtr n_UploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amazon.Clouddrive.AmazonCloudDriveClient __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.AmazonCloudDriveClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UploadFileRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UploadFileRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1 = (global::Com.Amazon.Clouddrive.Handlers.IProgressListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p2 = (global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UploadFileAsync (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive']/class[@name='AmazonCloudDriveClient']/method[@name='uploadFileAsync' and count(parameter)=3 and parameter[1][@type='com.amazon.clouddrive.model.UploadFileRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.ProgressListener'] and parameter[3][@type='com.amazon.clouddrive.handlers.AsyncHandler&lt;com.amazon.clouddrive.model.UploadFileRequest, com.amazon.clouddrive.model.UploadFileResponse&gt;']]"
		[Register ("uploadFileAsync", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;", "GetUploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture UploadFileAsync (global::Com.Amazon.Clouddrive.Model.UploadFileRequest p0, global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1, global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler p2)
		{
			if (id_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ == IntPtr.Zero)
				id_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_ = JNIEnv.GetMethodID (class_ref, "uploadFileAsync", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Util.Concurrent.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_uploadFileAsync_Lcom_amazon_clouddrive_model_UploadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Lcom_amazon_clouddrive_handlers_AsyncHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadFileAsync", "(Lcom/amazon/clouddrive/model/UploadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;Lcom/amazon/clouddrive/handlers/AsyncHandler;)Ljava/util/concurrent/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
